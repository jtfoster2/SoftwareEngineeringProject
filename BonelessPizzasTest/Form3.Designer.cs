namespace BonelessPizzasTest
{
    partial class Form3
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
            this.NewOrder = new System.Windows.Forms.Button();
            this.OrderHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(75, 326);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(255, 64);
            this.NewOrder.TabIndex = 0;
            this.NewOrder.Text = "Place New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // OrderHistory
            // 
            this.OrderHistory.Location = new System.Drawing.Point(689, 326);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(255, 64);
            this.OrderHistory.TabIndex = 1;
            this.OrderHistory.Text = "Order History";
            this.OrderHistory.UseVisualStyleBackColor = true;
            this.OrderHistory.Click += new System.EventHandler(this.OrderHistory_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 812);
            this.Controls.Add(this.OrderHistory);
            this.Controls.Add(this.NewOrder);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button OrderHistory;
    }
}