using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Arriola_MealOrderForm
{
   
    public partial class frm_MealOrder : Form
    {
        private Dictionary<string, decimal> mainDishPrices;
        private Dictionary<CheckBox, decimal> addOnPrices;

        public frm_MealOrder()
        {
            InitializeComponent();
        }

        private void frm_MealOrder_Load(object sender, EventArgs e)
        {
            lst_Order.Font = new Font("Consolas", 10);
            LoadMainDishes();
            LoadPrices();
        }

        private void LoadMainDishes()
        {
            cmb_MainDish.Items.AddRange(new[]
            {
                "Classic Pork Sisig",
                "Chicken Sisig",
                "Beef Sisig",
                "Pork BBQ",
                "Liempo",
                "Seafood Sisig Medley",
                "Tofu & Mushroom Sisig",
                "Creamy Sisig Carbonara",
                "Sisig Nacho Bake",
                "Sisig Bibimbap Fusion",
                "Sisig Sliders"
            });
        }

        private void LoadPrices()
        {
            mainDishPrices = new Dictionary<string, decimal>
            {
                { "Classic Pork Sisig", 220 },
                { "Chicken Sisig", 200 },
                { "Beef Sisig", 240 },
                { "Pork BBQ", 180 },
                { "Liempo", 230 },
                { "Seafood Sisig Medley", 280 },
                { "Tofu & Mushroom Sisig", 190 },
                { "Creamy Sisig Carbonara", 260 },
                { "Sisig Nacho Bake", 250 },
                { "Sisig Bibimbap Fusion", 270 },
                { "Sisig Sliders", 210 }
            };

            addOnPrices = new Dictionary<CheckBox, decimal>
            {
                { chk_Egg, 20 },
                { chk_Calamansi, 15 },
                { chk_Chili, 15 },
                { chk_Atchara, 20 },
                { chk_SoyVinegarDip, 15 },
                { chk_Rice, 25 }
            };
        }

        /* ================= RECEIPT HELPERS ================= */

        private const int ReceiptWidth = 32;

        private string Line() => new string('-', ReceiptWidth);

        private string Center(string text)
        {
            return text.PadLeft((ReceiptWidth + text.Length) / 2)
                       .PadRight(ReceiptWidth);
        }

        private string Item(string name, decimal price)
        {
            return $"{name,-22} ₱{price,6}";
        }

        private bool IsProtected(string text)
        {
            return text.Contains("SISIG HOUSE")
                || text.Contains("OFFICIAL RECEIPT")
                || text.Contains("TOTAL")
                || text.Contains("----");
        }

        /* ================= ADD ORDER ================= */

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            lst_Order.Items.Clear();

            lst_Order.Items.Add(Center("SISIG HOUSE"));
            lst_Order.Items.Add(Center("OFFICIAL RECEIPT"));
            lst_Order.Items.Add(Line());

            string dish = cmb_MainDish.SelectedItem.ToString();
            lst_Order.Items.Add(Item(dish, mainDishPrices[dish]));

            foreach (var addOn in addOnPrices)
            {
                if (addOn.Key.Checked)
                    lst_Order.Items.Add(Item(" + " + addOn.Key.Text, addOn.Value));
            }

            lst_Order.Items.Add(Line());
            lst_Order.Items.Add($"DINE : {(rb_DineIn.Checked ? "IN" : rb_TakeOut.Checked ? "OUT" : "DELIVERY")}");
            lst_Order.Items.Add($"PAY  : {(rb_Cash.Checked ? "CASH" : rb_Card.Checked ? "CARD" : "E-WALLET")}");

            lst_Order.Items.Add(Line());
            RecalculateTotal();

            ResetInputs();
            {
                MessageBox.Show("Added Successfully");
            }
        }

        /* ================= AUTO RECALCULATE ================= */

        private void RecalculateTotal()
        {
            decimal total = 0;

            foreach (string item in lst_Order.Items)
            {
                if (item.Contains("₱") && !item.Contains("TOTAL"))
                {
                    string priceText = item.Substring(item.LastIndexOf("₱") + 1).Trim();
                    if (decimal.TryParse(priceText, out decimal price))
                        total += price;
                }
            }

            for (int i = lst_Order.Items.Count - 1; i >= 0; i--)
            {
                if (lst_Order.Items[i].ToString().Contains("TOTAL"))
                {
                    lst_Order.Items.RemoveAt(i);
                    break;
                }
            }

            lst_Order.Items.Add(Item("TOTAL", total));
        }

        /* ================= REMOVE ITEM ================= */

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (lst_Order.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an item to remove.");
                return;
            }

            foreach (string item in lst_Order.SelectedItems)
            {
                if (IsProtected(item))
                {
                    MessageBox.Show("You cannot delete receipt headers or TOTAL.");
                    return;
                }
            }

            if (MessageBox.Show("Delete selected item(s)?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            for (int i = lst_Order.SelectedIndices.Count - 1; i >= 0; i--)
                lst_Order.Items.RemoveAt(lst_Order.SelectedIndices[i]);

            RecalculateTotal();
        }

        /* ================= CUSTOMER NOTE ================= */

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string note = txt_InputBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(note))
            {
                MessageBox.Show("Enter a note.");
                return;
            }

            lst_Order.Items.Add(Line());
            lst_Order.Items.Add("CUSTOMER NOTE:");
            lst_Order.Items.Add(note);

            txt_InputBox.Clear();
        }

        /* ================= CONFIRM / CLEAR ================= */

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (lst_Order.Items.Count == 0)
            { 
            MessageBox.Show("No Seleted Items. ","Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            {
                MessageBox.Show(string.Join("\n", lst_Order.Items.Cast<string>()), "Receipt",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }  
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lst_Order.Items.Clear();
        }
        /* ================= VALIDATION & RESET ================= */
        private bool ValidateInputs()
        {
            if (cmb_MainDish.SelectedIndex == -1)
            {
                MessageBox.Show("Select a main dish.");
                return false;
            }

            if (!rb_DineIn.Checked && !rb_TakeOut.Checked && !rb_Delivery.Checked)
            {
                MessageBox.Show("Select dine option.");
                return false;
            }

            if (!rb_Cash.Checked && !rb_Card.Checked && !rb_EWallet.Checked)
            {
                MessageBox.Show("Select payment method.");
                return false;
            }

            return true;
        }
        private void ResetInputs()
        {
            cmb_MainDish.SelectedIndex = -1;

            foreach (var cb in addOnPrices.Keys)
                cb.Checked = false;

            rb_DineIn.Checked = rb_TakeOut.Checked = rb_Delivery.Checked = false;
            rb_Cash.Checked = rb_Card.Checked = rb_EWallet.Checked = false;
        }

        private void txt_InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Send.PerformClick(); 
                e.SuppressKeyPress = true; 
            }
        }

        private void lst_Order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
