using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Arriola_MealOrderForm
{
   
    public partial class frm_MealOrder : Form
    {
        private Dictionary<string, decimal> mainDishPrices;
        private Dictionary<CheckBox, decimal> addOnPrices;
        private decimal totalAmount = 0m;

        public frm_MealOrder()
        {
            InitializeComponent();
        }

        private void frm_MealOrder_Load(object sender, EventArgs e)
        {
            LoadMainDishes();
            LoadPrices();

            // Option 1: Allow typing and autocomplete
            cmb_MainDish.DropDownStyle = ComboBoxStyle.DropDown;
            cmb_MainDish.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_MainDish.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Option 2: Keep as DropDownList, but disable autocomplete
            cmb_MainDish.AutoCompleteMode = AutoCompleteMode.None;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            totalAmount = 0;
            lst_Order.Items.Add("MAIN DISH");

            string dish = cmb_MainDish.SelectedItem.ToString();
            decimal dishPrice = mainDishPrices[dish];
            totalAmount += dishPrice;

            lst_Order.Items.Add($"{dish} - ₱{dishPrice}");

            AddAddOns();
            AddDineOption();
            AddPaymentMethod();

            lst_Order.Items.Add("----------------------");
            lst_Order.Items.Add($"TOTAL: ₱{totalAmount}");

            ResetInputs();

            MessageBox.Show("Order added successfully!", "Success");
        }

        private void AddAddOns()
        {
            lst_Order.Items.Add("ADD ONS");

            foreach (var addOn in addOnPrices)
            {
                if (addOn.Key.Checked)
                {
                    totalAmount += addOn.Value;
                    lst_Order.Items.Add($"- {addOn.Key.Text} ₱{addOn.Value}");
                }
            }
        }

        private void AddDineOption()
        {
            lst_Order.Items.Add("DINE OPTION");

            if (rb_DineIn.Checked) lst_Order.Items.Add("Dine In");
            else if (rb_TakeOut.Checked) lst_Order.Items.Add("Take Out");
            else lst_Order.Items.Add("Delivery");
        }

        private void AddPaymentMethod()
        {
            lst_Order.Items.Add("PAYMENT METHOD");

            if (rb_Cash.Checked) lst_Order.Items.Add("Cash");
            else if (rb_Card.Checked) lst_Order.Items.Add("Card");
            else lst_Order.Items.Add("E-Wallet");
        }

        private bool ValidateInputs()
        {
            if (cmb_MainDish.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Main Dish.");
                return false;
            }

            if (!rb_DineIn.Checked && !rb_TakeOut.Checked && !rb_Delivery.Checked)
            {
                MessageBox.Show("Please select Dine Option.");
                return false;
            }

            if (!rb_Cash.Checked && !rb_Card.Checked && !rb_EWallet.Checked)
            {
                MessageBox.Show("Please select Payment Method.");
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


        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string summary = string.Join("\n", lst_Order.Items.Cast<string>());
            MessageBox.Show(summary, "Order Summary");
        }

        private void btn_Send_Click(object sender, EventArgs e)

        {
            string note = txt_InputBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(note))
            {
                MessageBox.Show("Please enter your instruction or feedback.",
                                "Reminder",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txt_InputBox.Focus();
                return;
            }
            // Avoid duplicate "NOTE:" header
            if (!lst_Order.Items.Contains("CUSTOMER NOTE:"))
            {
                lst_Order.Items.Add("CUSTOMER NOTE:");
            }
            lst_Order.Items.Add(note);
            txt_InputBox.Clear();
            txt_InputBox.Focus();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (lst_Order.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.",
                                "Reminder",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // Headers / protected items
            string[] protectedItems =
            {
        "MAIN DISH",
        "ADD ONS",
        "DINE OPTION",
        "PAYMENT METHOD",
        "CUSTOMER NOTE:",
        "----------------------",
    };

            bool skippedProtected = false;

            // Ask for confirmation
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the selected item(s)?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // Delete safely (backwards)
            for (int i = lst_Order.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lst_Order.SelectedIndices[i];
                string itemText = lst_Order.Items[index].ToString();

                if (protectedItems.Contains(itemText))
                {
                    skippedProtected = true; // mark that we skipped it
                    continue; // skip deletion
                }

                lst_Order.Items.RemoveAt(index);
            }

            // Show one message if any protected items were skipped
            if (skippedProtected)
            {
                MessageBox.Show("Some protected items were not deleted.",
                                "Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }


        private void txt_InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the beep / new line
                btn_Send.PerformClick();   // acts like clicking Send
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lst_Order.Items.Clear();
        }
    }
}
