using System;
using System.Windows.Forms;

namespace Arriola_MealOrderForm
{
    public partial class frm_MealOrder : Form
    {
        public frm_MealOrder()
        {
            InitializeComponent();
        }

        private void frm_MealOrder_Load(object sender, EventArgs e)
        {
            cmb_MainDish.Items.Add("Classic Pork Sisig");
            cmb_MainDish.Items.Add("Chicken Sisig");
            cmb_MainDish.Items.Add("Beef Sisig");
            cmb_MainDish.Items.Add("Pork BBQ");
            cmb_MainDish.Items.Add("Liempo");
            cmb_MainDish.Items.Add("Seafood Sisig Medley");
            cmb_MainDish.Items.Add("Tofu & Mushroom Sisig");
            cmb_MainDish.Items.Add("Creamy Sisig Carbonara");
            cmb_MainDish.Items.Add("Sisig Nacho Bake");
            cmb_MainDish.Items.Add("Sisig Bibimbap Fusion");
            cmb_MainDish.Items.Add("Sisig Bibimbap Fusion");
            cmb_MainDish.Items.Add("Sisig Sliders");

            cmb_MainDish.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_MainDish.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmb_MainDish.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Main Dish
            string selectedDish = cmb_MainDish.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedDish))
            {
                MessageBox.Show("Please select a Main Dish", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lst_Order.Items.Add("Main Dish:" + " " + selectedDish);
            }

            //Extra Add Ons
            lst_Order.Items.Add("Add Ons:");
            if (chk_Egg.Checked)
            {
                lst_Order.Items.Add("-Egg");
            }
            if (chk_Calamansi.Checked)
            {
                lst_Order.Items.Add("-Calamansi");
            }
            if (chk_Chili.Checked)
            {
                lst_Order.Items.Add("-Chili");
            }
            if (chk_Atchara.Checked)
            {
                lst_Order.Items.Add("-Atchara");
            }
            if (chk_SoyVinegarDip.Checked)
            {
                lst_Order.Items.Add("-Soy-vinegar Dip");
            }
            if (chk_Rice.Checked)
            {
                lst_Order.Items.Add("-Rice");
            }
            
            //Dine Option
            lst_Order.Items.Add("Dine Option:");
            if (rb_DineIn.Checked)
            {
                lst_Order.Items.Add("Dine In");
            }
            else if (rb_TakeOut.Checked)
            {
                lst_Order.Items.Add("Take Out");
            }
            else if (rb_Delivery.Checked)
            {
                lst_Order.Items.Add("Delivery");
            }
            else 
            {
                MessageBox.Show("Please select Dine Option," + "\n" + "Thank you", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //Payment Method
            lst_Order.Items.Add("Payment Method:");
            if (rb_Cash.Checked)
            {
                lst_Order.Items.Add("Cash");
            }
            else if (rb_Card.Checked)
            {
                lst_Order.Items.Add("Card");
            }
            else if (rb_EWallet.Checked)
            {
                lst_Order.Items.Add("E-Wallet");
            }
            else
            {
               MessageBox.Show("Please select Payment Method," + "\n" + "Thank you", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Restart or Refresh
            cmb_MainDish.SelectedIndex = -1;
            chk_Atchara.Checked = false;
            chk_Calamansi.Checked = false;
            chk_Chili.Checked = false;
            chk_Egg.Checked = false;
            chk_Rice.Checked = false;
            chk_SoyVinegarDip.Checked = false;
            rb_Card.Checked = false;
            rb_Cash.Checked = false;
            rb_EWallet.Checked = false;
            rb_DineIn.Checked = false;
            rb_TakeOut.Checked = false;
            rb_Delivery.Checked = false;

            MessageBox.Show("Please leave a note if you'd like to have a request or needed, Thank you", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(string.IsNullOrEmpty(selectedDish))
            {
                lst_Order.Items.Clear();
                return;
            }
        }

        

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            while (lst_Order.SelectedItems.Count > 0)
            {
                lst_Order.Items.Remove(lst_Order.SelectedItems[0]);
            }
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            lst_Order.Items.Clear();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            lst_Order.Items.Add("Note:");
            lst_Order.Items.Add(txt_InputBox.Text);
            txt_InputBox.Clear();
            txt_InputBox.Focus();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string Order = "";
            foreach (string Item  in lst_Order.Items)
            {
                Order += Item + "\n";
            }
            MessageBox.Show(Order,"Order Summary",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
