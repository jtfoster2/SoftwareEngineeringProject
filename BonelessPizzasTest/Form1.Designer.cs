namespace BonelessPizzasTest
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
            this.HomeRegister = new System.Windows.Forms.Button();
            this.HomeLogin = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeRegister
            // 
            this.HomeRegister.Location = new System.Drawing.Point(559, 523);
            this.HomeRegister.Name = "HomeRegister";
            this.HomeRegister.Size = new System.Drawing.Size(237, 79);
            this.HomeRegister.TabIndex = 0;
            this.HomeRegister.Text = "Register";
            this.HomeRegister.UseVisualStyleBackColor = true;
            this.HomeRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeLogin
            // 
            this.HomeLogin.Location = new System.Drawing.Point(234, 523);
            this.HomeLogin.Name = "HomeLogin";
            this.HomeLogin.Size = new System.Drawing.Size(237, 79);
            this.HomeLogin.TabIndex = 1;
            this.HomeLogin.Text = "Log In";
            this.HomeLogin.UseVisualStyleBackColor = true;
            this.HomeLogin.Click += new System.EventHandler(this.HomeLogin_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PhoneNumber.Location = new System.Drawing.Point(234, 373);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(562, 83);
            this.PhoneNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(228, 315);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 32);
            this.ErrorMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 812);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.HomeLogin);
            this.Controls.Add(this.HomeRegister);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeRegister;
        private System.Windows.Forms.Button HomeLogin;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

