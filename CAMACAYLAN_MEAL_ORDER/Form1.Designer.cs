namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkSteak = new System.Windows.Forms.CheckBox();
            this.checkHotdog = new System.Windows.Forms.CheckBox();
            this.checkCurry = new System.Windows.Forms.CheckBox();
            this.radioTakeOut = new System.Windows.Forms.RadioButton();
            this.radioDineIn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.listBoxSummary = new System.Windows.Forms.ListBox();
            this.listViewSummary = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 62F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "PandaGoFood ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 56);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Summary";
            // 
            // checkSteak
            // 
            this.checkSteak.AutoSize = true;
            this.checkSteak.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSteak.ForeColor = System.Drawing.Color.Black;
            this.checkSteak.Location = new System.Drawing.Point(42, 237);
            this.checkSteak.Name = "checkSteak";
            this.checkSteak.Size = new System.Drawing.Size(165, 36);
            this.checkSteak.TabIndex = 5;
            this.checkSteak.Text = "Softdrinks";
            this.checkSteak.UseVisualStyleBackColor = true;
            this.checkSteak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkHotdog
            // 
            this.checkHotdog.AutoSize = true;
            this.checkHotdog.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHotdog.ForeColor = System.Drawing.Color.Black;
            this.checkHotdog.Location = new System.Drawing.Point(513, 237);
            this.checkHotdog.Name = "checkHotdog";
            this.checkHotdog.Size = new System.Drawing.Size(126, 36);
            this.checkHotdog.TabIndex = 6;
            this.checkHotdog.Text = "Hotdog";
            this.checkHotdog.UseVisualStyleBackColor = true;
            // 
            // checkCurry
            // 
            this.checkCurry.AutoSize = true;
            this.checkCurry.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCurry.ForeColor = System.Drawing.Color.Black;
            this.checkCurry.Location = new System.Drawing.Point(273, 237);
            this.checkCurry.Name = "checkCurry";
            this.checkCurry.Size = new System.Drawing.Size(216, 36);
            this.checkCurry.TabIndex = 9;
            this.checkCurry.Text = "Chicken Curry";
            this.checkCurry.UseVisualStyleBackColor = true;
            // 
            // radioTakeOut
            // 
            this.radioTakeOut.AutoSize = true;
            this.radioTakeOut.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTakeOut.Location = new System.Drawing.Point(133, 333);
            this.radioTakeOut.Name = "radioTakeOut";
            this.radioTakeOut.Size = new System.Drawing.Size(149, 40);
            this.radioTakeOut.TabIndex = 13;
            this.radioTakeOut.TabStop = true;
            this.radioTakeOut.Text = "TakeOut";
            this.radioTakeOut.UseVisualStyleBackColor = true;
            // 
            // radioDineIn
            // 
            this.radioDineIn.AutoSize = true;
            this.radioDineIn.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDineIn.Location = new System.Drawing.Point(354, 333);
            this.radioDineIn.Name = "radioDineIn";
            this.radioDineIn.Size = new System.Drawing.Size(135, 40);
            this.radioDineIn.TabIndex = 14;
            this.radioDineIn.TabStop = true;
            this.radioDineIn.Text = "Dine In";
            this.radioDineIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(401, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.Clear.Location = new System.Drawing.Point(108, 501);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(187, 55);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Payment options ";
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Location = new System.Drawing.Point(222, 158);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(366, 32);
            this.comboBoxMenu.TabIndex = 18;
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Location = new System.Drawing.Point(255, 435);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(366, 32);
            this.comboBoxPayment.TabIndex = 19;
            // 
            // listBoxSummary
            // 
            this.listBoxSummary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSummary.FormattingEnabled = true;
            this.listBoxSummary.ItemHeight = 16;
            this.listBoxSummary.Location = new System.Drawing.Point(703, 96);
            this.listBoxSummary.Name = "listBoxSummary";
            this.listBoxSummary.Size = new System.Drawing.Size(390, 196);
            this.listBoxSummary.TabIndex = 3;
            // 
            // listViewSummary
            // 
            this.listViewSummary.GridLines = true;
            this.listViewSummary.HideSelection = false;
            this.listViewSummary.Location = new System.Drawing.Point(703, 329);
            this.listViewSummary.Name = "listViewSummary";
            this.listViewSummary.Size = new System.Drawing.Size(390, 277);
            this.listViewSummary.TabIndex = 20;
            this.listViewSummary.UseCompatibleStateImageBehavior = false;
            this.listViewSummary.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1141, 618);
            this.Controls.Add(this.listViewSummary);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioDineIn);
            this.Controls.Add(this.radioTakeOut);
            this.Controls.Add(this.checkCurry);
            this.Controls.Add(this.checkHotdog);
            this.Controls.Add(this.checkSteak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkSteak;
        private System.Windows.Forms.CheckBox checkHotdog;
        private System.Windows.Forms.CheckBox checkCurry;
        private System.Windows.Forms.RadioButton radioTakeOut;
        private System.Windows.Forms.RadioButton radioDineIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.ListBox listBoxSummary;
        private System.Windows.Forms.ListView listViewSummary;
    }
}

