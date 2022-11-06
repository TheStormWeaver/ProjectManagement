namespace ProjectManagement
{
    partial class User
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
            this.firstnamel = new System.Windows.Forms.Label();
            this.firstnamet = new System.Windows.Forms.TextBox();
            this.surnamel = new System.Windows.Forms.Label();
            this.surnamet = new System.Windows.Forms.TextBox();
            this.lastnamel = new System.Windows.Forms.Label();
            this.lastnamet = new System.Windows.Forms.TextBox();
            this.typel = new System.Windows.Forms.Label();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstnamel
            // 
            this.firstnamel.AutoSize = true;
            this.firstnamel.Location = new System.Drawing.Point(58, 41);
            this.firstnamel.Name = "firstnamel";
            this.firstnamel.Size = new System.Drawing.Size(52, 13);
            this.firstnamel.TabIndex = 3;
            this.firstnamel.Text = "Firstname";
            // 
            // firstnamet
            // 
            this.firstnamet.Location = new System.Drawing.Point(138, 38);
            this.firstnamet.Name = "firstnamet";
            this.firstnamet.Size = new System.Drawing.Size(121, 20);
            this.firstnamet.TabIndex = 2;
            // 
            // surnamel
            // 
            this.surnamel.AutoSize = true;
            this.surnamel.Location = new System.Drawing.Point(61, 76);
            this.surnamel.Name = "surnamel";
            this.surnamel.Size = new System.Drawing.Size(49, 13);
            this.surnamel.TabIndex = 5;
            this.surnamel.Text = "Surname";
            // 
            // surnamet
            // 
            this.surnamet.Location = new System.Drawing.Point(138, 73);
            this.surnamet.Name = "surnamet";
            this.surnamet.Size = new System.Drawing.Size(121, 20);
            this.surnamet.TabIndex = 4;
            // 
            // lastnamel
            // 
            this.lastnamel.AutoSize = true;
            this.lastnamel.Location = new System.Drawing.Point(61, 112);
            this.lastnamel.Name = "lastnamel";
            this.lastnamel.Size = new System.Drawing.Size(53, 13);
            this.lastnamel.TabIndex = 7;
            this.lastnamel.Text = "Lastname";
            // 
            // lastnamet
            // 
            this.lastnamet.Location = new System.Drawing.Point(138, 109);
            this.lastnamet.Name = "lastnamet";
            this.lastnamet.Size = new System.Drawing.Size(121, 20);
            this.lastnamet.TabIndex = 6;
            // 
            // typel
            // 
            this.typel.AutoSize = true;
            this.typel.Location = new System.Drawing.Point(79, 147);
            this.typel.Name = "typel";
            this.typel.Size = new System.Drawing.Size(31, 13);
            this.typel.TabIndex = 9;
            this.typel.Text = "Type";
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(138, 147);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(121, 21);
            this.typecb.TabIndex = 10;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 228);
            this.Controls.Add(this.typecb);
            this.Controls.Add(this.typel);
            this.Controls.Add(this.lastnamel);
            this.Controls.Add(this.lastnamet);
            this.Controls.Add(this.surnamel);
            this.Controls.Add(this.surnamet);
            this.Controls.Add(this.firstnamel);
            this.Controls.Add(this.firstnamet);
            this.Name = "User";
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnamel;
        private System.Windows.Forms.TextBox firstnamet;
        private System.Windows.Forms.Label surnamel;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.Label lastnamel;
        private System.Windows.Forms.TextBox lastnamet;
        private System.Windows.Forms.Label typel;
        private System.Windows.Forms.ComboBox typecb;
    }
}