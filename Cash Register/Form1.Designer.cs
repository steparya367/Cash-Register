namespace Cash_Register
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.printreceiptButton = new System.Windows.Forms.Button();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.neworderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(240, 183);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(95, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Calculate1Button_Click);
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(240, 76);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(121, 20);
            this.burgerBox.TabIndex = 1;
            // 
            // printreceiptButton
            // 
            this.printreceiptButton.BackColor = System.Drawing.Color.Transparent;
            this.printreceiptButton.ForeColor = System.Drawing.Color.Black;
            this.printreceiptButton.Location = new System.Drawing.Point(192, 359);
            this.printreceiptButton.Name = "printreceiptButton";
            this.printreceiptButton.Size = new System.Drawing.Size(95, 31);
            this.printreceiptButton.TabIndex = 2;
            this.printreceiptButton.Text = "Print Receipt";
            this.printreceiptButton.UseVisualStyleBackColor = false;
            this.printreceiptButton.Click += new System.EventHandler(this.PrintrecieptButton_Click);
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(240, 132);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(121, 20);
            this.drinkBox.TabIndex = 3;
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(240, 102);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(121, 20);
            this.friesBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1064, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bob\'s Burger";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number Of Burgers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number Of Fries";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number Of Drinks";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(170, 221);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(56, 65);
            this.subTotalLabel.TabIndex = 14;
            this.subTotalLabel.Text = "Sub Total:\r\n\r\nTax:\r\n\r\nTotal:\r\n";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(237, 221);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(100, 65);
            this.displayLabel.TabIndex = 15;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // neworderButton
            // 
            this.neworderButton.BackColor = System.Drawing.Color.Transparent;
            this.neworderButton.ForeColor = System.Drawing.Color.Black;
            this.neworderButton.Location = new System.Drawing.Point(399, 359);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(95, 31);
            this.neworderButton.TabIndex = 16;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.NeworderButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(586, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 14);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(815, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 317);
            this.label6.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(586, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 317);
            this.label7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(586, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 14);
            this.label8.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1064, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.printreceiptButton);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.Button printreceiptButton;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.TextBox friesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

