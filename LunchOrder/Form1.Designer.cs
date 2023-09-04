namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new System.Windows.Forms.GroupBox();
            radioSalad = new System.Windows.Forms.RadioButton();
            radioPizza = new System.Windows.Forms.RadioButton();
            radioHamburger = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtOrderTotal = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtSalesTax = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnPlaceOrder = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            checkTopping = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            checkFries = new System.Windows.Forms.CheckBox();
            checkSauces = new System.Windows.Forms.CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(radioSalad);
            gbxMainCourse.Controls.Add(radioPizza);
            gbxMainCourse.Controls.Add(radioHamburger);
            gbxMainCourse.Location = new System.Drawing.Point(49, 28);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Size = new System.Drawing.Size(227, 163);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // radioSalad
            // 
            radioSalad.AutoSize = true;
            radioSalad.Location = new System.Drawing.Point(22, 108);
            radioSalad.Name = "radioSalad";
            radioSalad.Size = new System.Drawing.Size(141, 29);
            radioSalad.TabIndex = 2;
            radioSalad.TabStop = true;
            radioSalad.Text = "Salad - $4.95";
            radioSalad.UseVisualStyleBackColor = true;
            radioSalad.CheckedChanged += radioSalad_CheckedChanged;
            // 
            // radioPizza
            // 
            radioPizza.AutoSize = true;
            radioPizza.Location = new System.Drawing.Point(22, 73);
            radioPizza.Name = "radioPizza";
            radioPizza.Size = new System.Drawing.Size(137, 29);
            radioPizza.TabIndex = 1;
            radioPizza.TabStop = true;
            radioPizza.Text = "Pizza - $5.95";
            radioPizza.UseVisualStyleBackColor = true;
            radioPizza.CheckedChanged += radioPizza_CheckedChanged;
            // 
            // radioHamburger
            // 
            radioHamburger.AutoSize = true;
            radioHamburger.Location = new System.Drawing.Point(22, 38);
            radioHamburger.Name = "radioHamburger";
            radioHamburger.Size = new System.Drawing.Size(189, 29);
            radioHamburger.TabIndex = 0;
            radioHamburger.TabStop = true;
            radioHamburger.Text = "Hamburger - $6.95";
            radioHamburger.UseVisualStyleBackColor = true;
            radioHamburger.CheckedChanged += radioHamburger_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(49, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(371, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new System.Drawing.Point(160, 127);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new System.Drawing.Size(150, 31);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new System.Drawing.Point(160, 83);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new System.Drawing.Size(150, 31);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(160, 38);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(150, 31);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(457, 222);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(111, 42);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(457, 354);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(111, 42);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // checkTopping
            // 
            checkTopping.AutoSize = true;
            checkTopping.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkTopping.Location = new System.Drawing.Point(19, 39);
            checkTopping.Name = "checkTopping";
            checkTopping.Size = new System.Drawing.Size(201, 25);
            checkTopping.TabIndex = 4;
            checkTopping.Text = "Lettuce, Tomato, Onions";
            checkTopping.UseVisualStyleBackColor = true;
            checkTopping.CheckedChanged += chkToppings_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkFries);
            groupBox1.Controls.Add(checkSauces);
            groupBox1.Controls.Add(checkTopping);
            groupBox1.Location = new System.Drawing.Point(282, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(324, 163);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add-ons ($0.75 Each)";
            // 
            // checkFries
            // 
            checkFries.AutoSize = true;
            checkFries.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkFries.Location = new System.Drawing.Point(19, 112);
            checkFries.Name = "checkFries";
            checkFries.Size = new System.Drawing.Size(120, 25);
            checkFries.TabIndex = 6;
            checkFries.Text = "French Fries";
            checkFries.UseVisualStyleBackColor = true;
            checkFries.CheckedChanged += chkFries_CheckedChanged;
            // 
            // checkSauces
            // 
            checkSauces.AutoSize = true;
            checkSauces.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkSauces.Location = new System.Drawing.Point(19, 77);
            checkSauces.Name = "checkSauces";
            checkSauces.Size = new System.Drawing.Size(203, 25);
            checkSauces.TabIndex = 5;
            checkSauces.Text = "Ketchup, Mustard, Mayo";
            checkSauces.UseVisualStyleBackColor = true;
            checkSauces.CheckedChanged += chkSauce_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(618, 457);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioSalad;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioHamburger;
        private System.Windows.Forms.CheckBox checkTopping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkFries;
        private System.Windows.Forms.CheckBox checkSauces;
    }
}

