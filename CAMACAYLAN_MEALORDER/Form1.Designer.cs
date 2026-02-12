namespace Arriola_MealOrderForm
{
    partial class frm_MealOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_ListOrder = new System.Windows.Forms.Panel();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_InputBox = new System.Windows.Forms.TextBox();
            this.lst_Order = new System.Windows.Forms.ListBox();
            this.gb_DineOption = new System.Windows.Forms.GroupBox();
            this.rb_Delivery = new System.Windows.Forms.RadioButton();
            this.rb_TakeOut = new System.Windows.Forms.RadioButton();
            this.rb_DineIn = new System.Windows.Forms.RadioButton();
            this.gb_PaymentMethod = new System.Windows.Forms.GroupBox();
            this.rb_EWallet = new System.Windows.Forms.RadioButton();
            this.rb_Card = new System.Windows.Forms.RadioButton();
            this.rb_Cash = new System.Windows.Forms.RadioButton();
            this.lbl_MainDish = new System.Windows.Forms.Label();
            this.cmb_MainDish = new System.Windows.Forms.ComboBox();
            this.gb_ExtraAddOns = new System.Windows.Forms.GroupBox();
            this.chk_Calamansi = new System.Windows.Forms.CheckBox();
            this.chk_SoyVinegarDip = new System.Windows.Forms.CheckBox();
            this.chk_Atchara = new System.Windows.Forms.CheckBox();
            this.chk_Chili = new System.Windows.Forms.CheckBox();
            this.chk_Rice = new System.Windows.Forms.CheckBox();
            this.chk_Egg = new System.Windows.Forms.CheckBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Greetings = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_ListOrder.SuspendLayout();
            this.gb_DineOption.SuspendLayout();
            this.gb_PaymentMethod.SuspendLayout();
            this.gb_ExtraAddOns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ListOrder
            // 
            this.pnl_ListOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_ListOrder.Controls.Add(this.btn_Confirm);
            this.pnl_ListOrder.Controls.Add(this.btn_Clear);
            this.pnl_ListOrder.Controls.Add(this.btn_Remove);
            this.pnl_ListOrder.Controls.Add(this.btn_Send);
            this.pnl_ListOrder.Controls.Add(this.txt_InputBox);
            this.pnl_ListOrder.Controls.Add(this.lst_Order);
            this.pnl_ListOrder.Location = new System.Drawing.Point(12, 12);
            this.pnl_ListOrder.Name = "pnl_ListOrder";
            this.pnl_ListOrder.Size = new System.Drawing.Size(362, 543);
            this.pnl_ListOrder.TabIndex = 0;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(122, 492);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(108, 36);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Clear.Location = new System.Drawing.Point(122, 452);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(108, 34);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(236, 452);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(111, 34);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(14, 452);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(102, 34);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_InputBox
            // 
            this.txt_InputBox.Location = new System.Drawing.Point(14, 393);
            this.txt_InputBox.Multiline = true;
            this.txt_InputBox.Name = "txt_InputBox";
            this.txt_InputBox.Size = new System.Drawing.Size(333, 53);
            this.txt_InputBox.TabIndex = 1;
            this.txt_InputBox.TextChanged += new System.EventHandler(this.txt_InputBox_TextChanged);
            this.txt_InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_InputBox_KeyDown);
            // 
            // lst_Order
            // 
            this.lst_Order.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Order.FormattingEnabled = true;
            this.lst_Order.ItemHeight = 19;
            this.lst_Order.Location = new System.Drawing.Point(14, 12);
            this.lst_Order.Name = "lst_Order";
            this.lst_Order.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Order.Size = new System.Drawing.Size(333, 365);
            this.lst_Order.TabIndex = 0;
            this.lst_Order.SelectedIndexChanged += new System.EventHandler(this.lst_Order_SelectedIndexChanged);
            // 
            // gb_DineOption
            // 
            this.gb_DineOption.BackColor = System.Drawing.Color.Transparent;
            this.gb_DineOption.Controls.Add(this.rb_Delivery);
            this.gb_DineOption.Controls.Add(this.rb_TakeOut);
            this.gb_DineOption.Controls.Add(this.rb_DineIn);
            this.gb_DineOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DineOption.ForeColor = System.Drawing.Color.White;
            this.gb_DineOption.Location = new System.Drawing.Point(395, 327);
            this.gb_DineOption.Name = "gb_DineOption";
            this.gb_DineOption.Size = new System.Drawing.Size(322, 70);
            this.gb_DineOption.TabIndex = 1;
            this.gb_DineOption.TabStop = false;
            this.gb_DineOption.Text = "Dine Option";
            // 
            // rb_Delivery
            // 
            this.rb_Delivery.AutoSize = true;
            this.rb_Delivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Delivery.Location = new System.Drawing.Point(228, 27);
            this.rb_Delivery.Name = "rb_Delivery";
            this.rb_Delivery.Size = new System.Drawing.Size(88, 25);
            this.rb_Delivery.TabIndex = 2;
            this.rb_Delivery.TabStop = true;
            this.rb_Delivery.Text = "Delivery";
            this.rb_Delivery.UseVisualStyleBackColor = true;
            // 
            // rb_TakeOut
            // 
            this.rb_TakeOut.AutoSize = true;
            this.rb_TakeOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TakeOut.Location = new System.Drawing.Point(111, 27);
            this.rb_TakeOut.Name = "rb_TakeOut";
            this.rb_TakeOut.Size = new System.Drawing.Size(103, 25);
            this.rb_TakeOut.TabIndex = 1;
            this.rb_TakeOut.TabStop = true;
            this.rb_TakeOut.Text = " Take Out";
            this.rb_TakeOut.UseVisualStyleBackColor = true;
            // 
            // rb_DineIn
            // 
            this.rb_DineIn.AutoSize = true;
            this.rb_DineIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_DineIn.Location = new System.Drawing.Point(18, 27);
            this.rb_DineIn.Name = "rb_DineIn";
            this.rb_DineIn.Size = new System.Drawing.Size(83, 25);
            this.rb_DineIn.TabIndex = 0;
            this.rb_DineIn.TabStop = true;
            this.rb_DineIn.Text = "Dine In";
            this.rb_DineIn.UseVisualStyleBackColor = true;
            // 
            // gb_PaymentMethod
            // 
            this.gb_PaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.gb_PaymentMethod.Controls.Add(this.rb_EWallet);
            this.gb_PaymentMethod.Controls.Add(this.rb_Card);
            this.gb_PaymentMethod.Controls.Add(this.rb_Cash);
            this.gb_PaymentMethod.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_PaymentMethod.ForeColor = System.Drawing.Color.White;
            this.gb_PaymentMethod.Location = new System.Drawing.Point(395, 405);
            this.gb_PaymentMethod.Name = "gb_PaymentMethod";
            this.gb_PaymentMethod.Size = new System.Drawing.Size(322, 68);
            this.gb_PaymentMethod.TabIndex = 2;
            this.gb_PaymentMethod.TabStop = false;
            this.gb_PaymentMethod.Text = "Payment Method ";
            // 
            // rb_EWallet
            // 
            this.rb_EWallet.AutoSize = true;
            this.rb_EWallet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EWallet.Location = new System.Drawing.Point(210, 27);
            this.rb_EWallet.Name = "rb_EWallet";
            this.rb_EWallet.Size = new System.Drawing.Size(92, 25);
            this.rb_EWallet.TabIndex = 5;
            this.rb_EWallet.TabStop = true;
            this.rb_EWallet.Text = "E-Wallet";
            this.rb_EWallet.UseVisualStyleBackColor = true;
            // 
            // rb_Card
            // 
            this.rb_Card.AutoSize = true;
            this.rb_Card.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Card.Location = new System.Drawing.Point(121, 27);
            this.rb_Card.Name = "rb_Card";
            this.rb_Card.Size = new System.Drawing.Size(69, 25);
            this.rb_Card.TabIndex = 4;
            this.rb_Card.TabStop = true;
            this.rb_Card.Text = "Card ";
            this.rb_Card.UseVisualStyleBackColor = true;
            // 
            // rb_Cash
            // 
            this.rb_Cash.AutoSize = true;
            this.rb_Cash.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Cash.Location = new System.Drawing.Point(18, 27);
            this.rb_Cash.Name = "rb_Cash";
            this.rb_Cash.Size = new System.Drawing.Size(65, 25);
            this.rb_Cash.TabIndex = 3;
            this.rb_Cash.TabStop = true;
            this.rb_Cash.Text = "Cash";
            this.rb_Cash.UseVisualStyleBackColor = true;
            // 
            // lbl_MainDish
            // 
            this.lbl_MainDish.AutoSize = true;
            this.lbl_MainDish.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainDish.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainDish.ForeColor = System.Drawing.Color.White;
            this.lbl_MainDish.Location = new System.Drawing.Point(391, 117);
            this.lbl_MainDish.Name = "lbl_MainDish";
            this.lbl_MainDish.Size = new System.Drawing.Size(91, 22);
            this.lbl_MainDish.TabIndex = 3;
            this.lbl_MainDish.Text = "Main Dish";
            // 
            // cmb_MainDish
            // 
            this.cmb_MainDish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmb_MainDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MainDish.FormattingEnabled = true;
            this.cmb_MainDish.Location = new System.Drawing.Point(395, 142);
            this.cmb_MainDish.Name = "cmb_MainDish";
            this.cmb_MainDish.Size = new System.Drawing.Size(322, 29);
            this.cmb_MainDish.TabIndex = 4;
            // 
            // gb_ExtraAddOns
            // 
            this.gb_ExtraAddOns.BackColor = System.Drawing.Color.Transparent;
            this.gb_ExtraAddOns.Controls.Add(this.chk_Calamansi);
            this.gb_ExtraAddOns.Controls.Add(this.chk_SoyVinegarDip);
            this.gb_ExtraAddOns.Controls.Add(this.chk_Atchara);
            this.gb_ExtraAddOns.Controls.Add(this.chk_Chili);
            this.gb_ExtraAddOns.Controls.Add(this.chk_Rice);
            this.gb_ExtraAddOns.Controls.Add(this.chk_Egg);
            this.gb_ExtraAddOns.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ExtraAddOns.ForeColor = System.Drawing.Color.White;
            this.gb_ExtraAddOns.Location = new System.Drawing.Point(395, 177);
            this.gb_ExtraAddOns.Name = "gb_ExtraAddOns";
            this.gb_ExtraAddOns.Size = new System.Drawing.Size(322, 144);
            this.gb_ExtraAddOns.TabIndex = 5;
            this.gb_ExtraAddOns.TabStop = false;
            this.gb_ExtraAddOns.Text = "Extra Add Ons";
            // 
            // chk_Calamansi
            // 
            this.chk_Calamansi.AutoSize = true;
            this.chk_Calamansi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chk_Calamansi.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Calamansi.Location = new System.Drawing.Point(18, 71);
            this.chk_Calamansi.Name = "chk_Calamansi";
            this.chk_Calamansi.Size = new System.Drawing.Size(107, 25);
            this.chk_Calamansi.TabIndex = 5;
            this.chk_Calamansi.Text = "Calamansi";
            this.chk_Calamansi.UseVisualStyleBackColor = true;
            // 
            // chk_SoyVinegarDip
            // 
            this.chk_SoyVinegarDip.AutoSize = true;
            this.chk_SoyVinegarDip.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chk_SoyVinegarDip.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SoyVinegarDip.Location = new System.Drawing.Point(154, 102);
            this.chk_SoyVinegarDip.Name = "chk_SoyVinegarDip";
            this.chk_SoyVinegarDip.Size = new System.Drawing.Size(148, 25);
            this.chk_SoyVinegarDip.TabIndex = 4;
            this.chk_SoyVinegarDip.Text = "Soy-vinegar dip";
            this.chk_SoyVinegarDip.UseVisualStyleBackColor = true;
            // 
            // chk_Atchara
            // 
            this.chk_Atchara.AutoSize = true;
            this.chk_Atchara.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chk_Atchara.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Atchara.Location = new System.Drawing.Point(154, 40);
            this.chk_Atchara.Name = "chk_Atchara";
            this.chk_Atchara.Size = new System.Drawing.Size(88, 25);
            this.chk_Atchara.TabIndex = 3;
            this.chk_Atchara.Text = "Atchara";
            this.chk_Atchara.UseVisualStyleBackColor = true;
            // 
            // chk_Chili
            // 
            this.chk_Chili.AutoSize = true;
            this.chk_Chili.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chk_Chili.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Chili.Location = new System.Drawing.Point(18, 102);
            this.chk_Chili.Name = "chk_Chili";
            this.chk_Chili.Size = new System.Drawing.Size(62, 25);
            this.chk_Chili.TabIndex = 2;
            this.chk_Chili.Text = "Chili";
            this.chk_Chili.UseVisualStyleBackColor = true;
            // 
            // chk_Rice
            // 
            this.chk_Rice.AutoSize = true;
            this.chk_Rice.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chk_Rice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Rice.Location = new System.Drawing.Point(154, 71);
            this.chk_Rice.Name = "chk_Rice";
            this.chk_Rice.Size = new System.Drawing.Size(60, 25);
            this.chk_Rice.TabIndex = 1;
            this.chk_Rice.Text = "Rice";
            this.chk_Rice.UseVisualStyleBackColor = true;
            // 
            // chk_Egg
            // 
            this.chk_Egg.AutoSize = true;
            this.chk_Egg.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chk_Egg.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Egg.Location = new System.Drawing.Point(18, 40);
            this.chk_Egg.Name = "chk_Egg";
            this.chk_Egg.Size = new System.Drawing.Size(58, 25);
            this.chk_Egg.TabIndex = 0;
            this.chk_Egg.Text = "Egg";
            this.chk_Egg.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(395, 487);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(322, 53);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Greetings
            // 
            this.lbl_Greetings.AutoSize = true;
            this.lbl_Greetings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Greetings.ForeColor = System.Drawing.Color.White;
            this.lbl_Greetings.Location = new System.Drawing.Point(391, 42);
            this.lbl_Greetings.Name = "lbl_Greetings";
            this.lbl_Greetings.Size = new System.Drawing.Size(331, 63);
            this.lbl_Greetings.TabIndex = 7;
            this.lbl_Greetings.Text = "\"Hungry? You’ve come to the right place! \r\nSelect your meal, add your favorites, " +
    "\r\nand we’ll take care of the rest.\"";
            this.lbl_Greetings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(390, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(327, 28);
            this.lbl_Title.TabIndex = 8;
            this.lbl_Title.Text = "\"Welcome to Sisig Sensation\"\r\n";
            // 
            // frm_MealOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arriola_MealOrderForm.Properties.Resources.download__28_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 564);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Greetings);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_ExtraAddOns);
            this.Controls.Add(this.cmb_MainDish);
            this.Controls.Add(this.lbl_MainDish);
            this.Controls.Add(this.gb_PaymentMethod);
            this.Controls.Add(this.gb_DineOption);
            this.Controls.Add(this.pnl_ListOrder);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_MealOrder";
            this.Text = "Meal Order Form";
            this.Load += new System.EventHandler(this.frm_MealOrder_Load);
            this.pnl_ListOrder.ResumeLayout(false);
            this.pnl_ListOrder.PerformLayout();
            this.gb_DineOption.ResumeLayout(false);
            this.gb_DineOption.PerformLayout();
            this.gb_PaymentMethod.ResumeLayout(false);
            this.gb_PaymentMethod.PerformLayout();
            this.gb_ExtraAddOns.ResumeLayout(false);
            this.gb_ExtraAddOns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ListOrder;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_InputBox;
        private System.Windows.Forms.ListBox lst_Order;
        private System.Windows.Forms.GroupBox gb_DineOption;
        private System.Windows.Forms.GroupBox gb_PaymentMethod;
        private System.Windows.Forms.Label lbl_MainDish;
        private System.Windows.Forms.RadioButton rb_Delivery;
        private System.Windows.Forms.RadioButton rb_TakeOut;
        private System.Windows.Forms.RadioButton rb_DineIn;
        private System.Windows.Forms.RadioButton rb_EWallet;
        private System.Windows.Forms.RadioButton rb_Card;
        private System.Windows.Forms.RadioButton rb_Cash;
        private System.Windows.Forms.ComboBox cmb_MainDish;
        private System.Windows.Forms.GroupBox gb_ExtraAddOns;
        private System.Windows.Forms.CheckBox chk_Calamansi;
        private System.Windows.Forms.CheckBox chk_SoyVinegarDip;
        private System.Windows.Forms.CheckBox chk_Atchara;
        private System.Windows.Forms.CheckBox chk_Chili;
        private System.Windows.Forms.CheckBox chk_Rice;
        private System.Windows.Forms.CheckBox chk_Egg;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Greetings;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Confirm;
    }
}

