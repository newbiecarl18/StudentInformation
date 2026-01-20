using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        double priceSteak = 120;
        double priceCurry = 100;
        double priceHotdog = 80;

        double addonSteak = 20;
        double addonCurry = 15;
        double addonHotdog = 10;

        public Form1()
        {
            InitializeComponent();
            comboBoxMenu.Items.Add("Steak");
            comboBoxMenu.Items.Add("Curry");
            comboBoxMenu.Items.Add("Hotdog");

           
            comboBoxPayment.Items.Add("Cash on Delivery");
            comboBoxPayment.Items.Add("Card");

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            listViewSummary.View = View.Details;
            listViewSummary.Columns.Clear();
            listViewSummary.Columns.Add("Item", 200);
            listViewSummary.Columns.Add("Details", 200);
            listViewSummary.Columns.Add("Price", 100);

            if (comboBoxMenu.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a main dish.");
                return;
            }
            if (!radioTakeOut.Checked && !radioDineIn.Checked)
            {
                MessageBox.Show("Please choose a dine option.");
                return;
            }
            if (comboBoxPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment option.");
                return;
            }

            listViewSummary.Items.Clear();
            listBoxSummary.Items.Clear();

            // Random prices for main dishes
            double priceSteak = rand.Next(200, 500);
            double priceCurry = rand.Next(150, 400);
            double priceHotdog = rand.Next(50, 200);

            string mainDish = comboBoxMenu.SelectedItem.ToString();
            double mainPrice = 500;

            if (mainDish == "Burger") mainPrice = priceSteak;
            if (mainDish == "French Fries") mainPrice = priceCurry;
            if (mainDish == "teriyaki") mainPrice = priceHotdog;

            // Random prices for add-ons
            double addonSteak = rand.Next(100, 300);
            double addonCurry = rand.Next(80, 200);
            double addonHotdog = rand.Next(30, 100);

            string addons = "";
            if (checkSteak.Checked) addons += $"Extra Steak (₱{addonSteak})\n";
            if (checkCurry.Checked) addons += $"Extra Curry (₱{addonCurry})\n";
            if (checkHotdog.Checked) addons += $"Extra Hotdog (₱{addonHotdog})\n";
            if (addons == "") addons = "None\n";

            string dineOption = radioTakeOut.Checked ? "Take Out" : "Dine In";
            string payment = comboBoxPayment.SelectedItem.ToString();

            // ===== RECEIPT OUTPUT (ListView) =====
            listViewSummary.Items.Add(new ListViewItem(new[] { "======= PandaGoFood Receipt =======", "", "" }));

            ListViewItem mainDishItem = new ListViewItem("Main Dish");
            mainDishItem.SubItems.Add(mainDish);
            mainDishItem.SubItems.Add("₱" + mainPrice);
            listViewSummary.Items.Add(mainDishItem);

            ListViewItem addonsHeader = new ListViewItem("Add-ons");
            addonsHeader.SubItems.Add("");
            addonsHeader.SubItems.Add("");
            listViewSummary.Items.Add(addonsHeader);

            foreach (string line in addons.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    ListViewItem addonItem = new ListViewItem(line);
                    addonItem.SubItems.Add("");
                    addonItem.SubItems.Add("");
                    listViewSummary.Items.Add(addonItem);
                }
            }

            ListViewItem dineItem = new ListViewItem("Dine Option");
            dineItem.SubItems.Add(dineOption);
            dineItem.SubItems.Add("");
            listViewSummary.Items.Add(dineItem);

            ListViewItem paymentItem = new ListViewItem("Payment Method");
            paymentItem.SubItems.Add(payment);
            paymentItem.SubItems.Add("");
            listViewSummary.Items.Add(paymentItem);

            listViewSummary.Items.Add(new ListViewItem(new[] { "====================================", "", "" }));
            listViewSummary.Items.Add(new ListViewItem(new[] { "     Thank you for ordering!", "", "" }));
            listViewSummary.Items.Add(new ListViewItem(new[] { "====================================", "", "" }));

            listViewSummary.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewSummary.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // ===== RECEIPT OUTPUT (ListBox) =====
            listBoxSummary.Items.Add("======= PandaGoFood Receipt =======");
            listBoxSummary.Items.Add("Main Dish:");
            listBoxSummary.Items.Add($"  {mainDish} (₱{mainPrice})");
            listBoxSummary.Items.Add("");
            listBoxSummary.Items.Add("Add-ons:");
            foreach (string line in addons.Split('\n'))
            {
                if (!string.IsNullOrWhiteSpace(line))
                    listBoxSummary.Items.Add("  " + line);
            }
            listBoxSummary.Items.Add("");
            listBoxSummary.Items.Add("Dine Option:");
            listBoxSummary.Items.Add("  " + dineOption);
            listBoxSummary.Items.Add("");
            listBoxSummary.Items.Add("Payment Method:");
            listBoxSummary.Items.Add("  " + payment);
            listBoxSummary.Items.Add("");
            listBoxSummary.Items.Add("====================================");
            listBoxSummary.Items.Add("     Thank you for ordering!");
            listBoxSummary.Items.Add("====================================");


        }


        private void Clear_Click(object sender, EventArgs e)
        {
            listBoxSummary.Items.Clear();

            comboBoxMenu.SelectedIndex = -1;
            comboBoxPayment.SelectedIndex = -1;

            checkSteak.Checked = false;
            checkCurry.Checked = false;
            checkHotdog.Checked = false;

            radioDineIn.Checked = false;
            radioTakeOut.Checked = false;
        }
    }
}
