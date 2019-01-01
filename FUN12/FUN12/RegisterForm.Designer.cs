namespace FUN12
{
    partial class RegisterForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(203, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(285, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(285, 110);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Gebruikernaam";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(452, 305);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registeren";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(380, 107);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(100, 20);
            this.txbUserName.TabIndex = 7;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(380, 149);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Voornaam";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(380, 240);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "achternaam";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(380, 194);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 14;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbPassword);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFirstName;
    }
}