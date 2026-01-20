namespace Camacaylan_ListOfNames
{
    partial class frmNames
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
            this.lstListOfNames = new System.Windows.Forms.ListBox();
            this.txt_InputName = new System.Windows.Forms.TextBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.btn_CLEAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListOfNames
            // 
            this.lstListOfNames.FormattingEnabled = true;
            this.lstListOfNames.Location = new System.Drawing.Point(65, 58);
            this.lstListOfNames.Name = "lstListOfNames";
            this.lstListOfNames.Size = new System.Drawing.Size(417, 329);
            this.lstListOfNames.TabIndex = 0;
            this.lstListOfNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstListOfNames_KeyDown);
            // 
            // txt_InputName
            // 
            this.txt_InputName.Location = new System.Drawing.Point(65, 409);
            this.txt_InputName.Name = "txt_InputName";
            this.txt_InputName.Size = new System.Drawing.Size(417, 20);
            this.txt_InputName.TabIndex = 1;
            this.txt_InputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_InputName_KeyDown);
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(65, 435);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(111, 52);
            this.btn_ADD.TabIndex = 2;
            this.btn_ADD.Text = "Add";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.Location = new System.Drawing.Point(217, 435);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(105, 52);
            this.btn_DELETE.TabIndex = 3;
            this.btn_DELETE.Text = "Delete";
            this.btn_DELETE.UseVisualStyleBackColor = true;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // btn_CLEAR
            // 
            this.btn_CLEAR.Location = new System.Drawing.Point(380, 435);
            this.btn_CLEAR.Name = "btn_CLEAR";
            this.btn_CLEAR.Size = new System.Drawing.Size(102, 52);
            this.btn_CLEAR.TabIndex = 4;
            this.btn_CLEAR.Text = "Clear";
            this.btn_CLEAR.UseVisualStyleBackColor = true;
            this.btn_CLEAR.Click += new System.EventHandler(this.btn_CLEAR_Click);
            // 
            // frmNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 526);
            this.Controls.Add(this.btn_CLEAR);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.txt_InputName);
            this.Controls.Add(this.lstListOfNames);
            this.Name = "frmNames";
            this.Text = "List of Names";
            this.Load += new System.EventHandler(this.frmNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListOfNames;
        private System.Windows.Forms.TextBox txt_InputName;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.Button btn_CLEAR;
    }
}
