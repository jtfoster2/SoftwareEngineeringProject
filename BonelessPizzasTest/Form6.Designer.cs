namespace BonelessPizzasTest
{
    partial class Form6
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.ClosingMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 66);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 66);
            this.comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Restart Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 656);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "Finish Payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(110, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 64);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox2.Location = new System.Drawing.Point(110, 516);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 64);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Card Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClosingMessage);
            this.panel1.Controls.Add(this.CompanyName);
            this.panel1.Controls.Add(this.tax);
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Subtotal);
            this.panel1.Location = new System.Drawing.Point(664, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 577);
            this.panel1.TabIndex = 10;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(50, 310);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(129, 32);
            this.Subtotal.TabIndex = 0;
            this.Subtotal.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Signature:___________";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(50, 409);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(87, 32);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total:";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(50, 356);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(70, 32);
            this.tax.TabIndex = 3;
            this.tax.Text = "Tax:";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.CompanyName.Location = new System.Drawing.Point(6, 10);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(355, 52);
            this.CompanyName.TabIndex = 4;
            this.CompanyName.Text = "Boneless Pizzas";
            // 
            // ClosingMessage
            // 
            this.ClosingMessage.AutoSize = true;
            this.ClosingMessage.Location = new System.Drawing.Point(27, 68);
            this.ClosingMessage.Name = "ClosingMessage";
            this.ClosingMessage.Size = new System.Drawing.Size(307, 32);
            this.ClosingMessage.TabIndex = 11;
            this.ClosingMessage.Text = "Thank you for ordering!";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 812);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label ClosingMessage;
        private System.Windows.Forms.Label CompanyName;
    }
}