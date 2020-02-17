namespace BonelessPizzasTest
{
    partial class Form5
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
            this.size = new System.Windows.Forms.ComboBox();
            this.crust = new System.Windows.Forms.ComboBox();
            this.DrinkSize = new System.Windows.Forms.ComboBox();
            this.Topping1 = new System.Windows.Forms.ComboBox();
            this.PizzaButton = new System.Windows.Forms.Button();
            this.DrinksButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentOrder = new System.Windows.Forms.Label();
            this.Topping2 = new System.Windows.Forms.ComboBox();
            this.Topping3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Drinks = new System.Windows.Forms.ComboBox();
            this.Topping4 = new System.Windows.Forms.ComboBox();
            this.CurrentTotalCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // size
            // 
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "Small ($10.00)",
            "Medium ($15.00)",
            "Large ($20.00)",
            "Huge ($25.00)"});
            this.size.Location = new System.Drawing.Point(26, 72);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(255, 39);
            this.size.TabIndex = 0;
            // 
            // crust
            // 
            this.crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.crust.FormattingEnabled = true;
            this.crust.Items.AddRange(new object[] {
            "Thin Crust (+ $0.00)",
            "Hand Tossed Crust (+ $0.00)",
            "Deep Dish (+ $2.00)"});
            this.crust.Location = new System.Drawing.Point(26, 167);
            this.crust.Name = "crust";
            this.crust.Size = new System.Drawing.Size(255, 39);
            this.crust.TabIndex = 1;
            // 
            // DrinkSize
            // 
            this.DrinkSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.DrinkSize.FormattingEnabled = true;
            this.DrinkSize.Items.AddRange(new object[] {
            "Small ($1.00)",
            "Medium ($2.00)",
            "Large ($3.00)"});
            this.DrinkSize.Location = new System.Drawing.Point(378, 167);
            this.DrinkSize.Name = "DrinkSize";
            this.DrinkSize.Size = new System.Drawing.Size(255, 39);
            this.DrinkSize.TabIndex = 2;
            // 
            // Topping1
            // 
            this.Topping1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.Topping1.FormattingEnabled = true;
            this.Topping1.Items.AddRange(new object[] {
            "Pepperoni (+ $0.00)",
            "Olives (+ $0.00)",
            "Onions (+ $0.00)",
            "Sausage (+ $0.00)",
            "Bacon (+ $0.00)",
            "Jalapenos (+ $0.00)",
            "Pineapple (+ $0.00)",
            "Basil (+ $0.00)"});
            this.Topping1.Location = new System.Drawing.Point(26, 284);
            this.Topping1.Name = "Topping1";
            this.Topping1.Size = new System.Drawing.Size(255, 39);
            this.Topping1.TabIndex = 5;
            // 
            // PizzaButton
            // 
            this.PizzaButton.Location = new System.Drawing.Point(26, 672);
            this.PizzaButton.Name = "PizzaButton";
            this.PizzaButton.Size = new System.Drawing.Size(255, 64);
            this.PizzaButton.TabIndex = 6;
            this.PizzaButton.Text = "Add To Cart";
            this.PizzaButton.UseVisualStyleBackColor = true;
            this.PizzaButton.Click += new System.EventHandler(this.PizzaButton_Click);
            // 
            // DrinksButton
            // 
            this.DrinksButton.Location = new System.Drawing.Point(378, 672);
            this.DrinksButton.Name = "DrinksButton";
            this.DrinksButton.Size = new System.Drawing.Size(255, 64);
            this.DrinksButton.TabIndex = 7;
            this.DrinksButton.Text = "Add To Cart";
            this.DrinksButton.UseVisualStyleBackColor = true;
            this.DrinksButton.Click += new System.EventHandler(this.DrinksButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(79, 594);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(255, 64);
            this.CheckOutButton.TabIndex = 8;
            this.CheckOutButton.Text = "Checkout";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Crust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Topping 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Topping 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Topping 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Drink Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Current Order";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CurrentTotalCost);
            this.panel1.Controls.Add(this.CurrentOrder);
            this.panel1.Controls.Add(this.CheckOutButton);
            this.panel1.Location = new System.Drawing.Point(698, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 661);
            this.panel1.TabIndex = 17;
            // 
            // CurrentOrder
            // 
            this.CurrentOrder.AutoSize = true;
            this.CurrentOrder.Location = new System.Drawing.Point(73, 16);
            this.CurrentOrder.Name = "CurrentOrder";
            this.CurrentOrder.Size = new System.Drawing.Size(0, 32);
            this.CurrentOrder.TabIndex = 18;
            // 
            // Topping2
            // 
            this.Topping2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.Topping2.FormattingEnabled = true;
            this.Topping2.Items.AddRange(new object[] {
            "Pepperoni (+ $0.20)",
            "Olives (+ $0.20)",
            "Onions (+ $0.20)",
            "Sausage (+ $0.20)",
            "Bacon (+ $0.30)",
            "Jalapenos (+ $0.30)",
            "Pineapple (+ $0.30)",
            "Basil (+ $0.30)"});
            this.Topping2.Location = new System.Drawing.Point(26, 370);
            this.Topping2.Name = "Topping2";
            this.Topping2.Size = new System.Drawing.Size(255, 39);
            this.Topping2.TabIndex = 18;
            // 
            // Topping3
            // 
            this.Topping3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.Topping3.FormattingEnabled = true;
            this.Topping3.Items.AddRange(new object[] {
            "Pepperoni (+ $0.20)",
            "Olives (+ $0.20)",
            "Onions (+ $0.20)",
            "Sausage (+ $0.20)",
            "Bacon (+ $0.30)",
            "Jalapenos (+ $0.30)",
            "Pineapple (+ $0.30)",
            "Basil (+ $0.30)"});
            this.Topping3.Location = new System.Drawing.Point(26, 460);
            this.Topping3.Name = "Topping3";
            this.Topping3.Size = new System.Drawing.Size(255, 39);
            this.Topping3.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Topping 4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Drinks";
            // 
            // Drinks
            // 
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.Drinks.FormattingEnabled = true;
            this.Drinks.Items.AddRange(new object[] {
            "Coke",
            "Diet Coke",
            "Lemonade",
            "Sweet Tea",
            "Unsweet Tea"});
            this.Drinks.Location = new System.Drawing.Point(378, 72);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(255, 39);
            this.Drinks.TabIndex = 22;
            // 
            // Topping4
            // 
            this.Topping4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.Topping4.FormattingEnabled = true;
            this.Topping4.Items.AddRange(new object[] {
            "Pepperoni (+ $0.20)",
            "Olives (+ $0.20)",
            "Onions (+ $0.20)",
            "Sausage (+ $0.20)",
            "Bacon (+ $0.30)",
            "Jalapenos (+ $0.30)",
            "Pineapple (+ $0.30)",
            "Basil (+ $0.30)"});
            this.Topping4.Location = new System.Drawing.Point(26, 550);
            this.Topping4.Name = "Topping4";
            this.Topping4.Size = new System.Drawing.Size(255, 39);
            this.Topping4.TabIndex = 24;
            // 
            // CurrentTotalCost
            // 
            this.CurrentTotalCost.AutoSize = true;
            this.CurrentTotalCost.Location = new System.Drawing.Point(59, 551);
            this.CurrentTotalCost.Name = "CurrentTotalCost";
            this.CurrentTotalCost.Size = new System.Drawing.Size(292, 32);
            this.CurrentTotalCost.TabIndex = 19;
            this.CurrentTotalCost.Text = "Total: --------------$0.00";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 812);
            this.Controls.Add(this.Topping4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Topping3);
            this.Controls.Add(this.Topping2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrinksButton);
            this.Controls.Add(this.PizzaButton);
            this.Controls.Add(this.Topping1);
            this.Controls.Add(this.DrinkSize);
            this.Controls.Add(this.crust);
            this.Controls.Add(this.size);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.ComboBox crust;
        private System.Windows.Forms.ComboBox DrinkSize;
        private System.Windows.Forms.ComboBox Topping1;
        private System.Windows.Forms.Button PizzaButton;
        private System.Windows.Forms.Button DrinksButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentOrder;
        private System.Windows.Forms.ComboBox Topping2;
        private System.Windows.Forms.ComboBox Topping3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Drinks;
        private System.Windows.Forms.ComboBox Topping4;
        private System.Windows.Forms.Label CurrentTotalCost;
    }
}