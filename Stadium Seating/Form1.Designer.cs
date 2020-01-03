namespace Stadium_Seating
{
    partial class stadiumSeating
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
            this.ticketsSold = new System.Windows.Forms.GroupBox();
            this.revenueGen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateRevenue = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.classALabel = new System.Windows.Forms.Label();
            this.classBLabel = new System.Windows.Forms.Label();
            this.classCLabel = new System.Windows.Forms.Label();
            this.classABox = new System.Windows.Forms.TextBox();
            this.classCBox = new System.Windows.Forms.TextBox();
            this.classBBox = new System.Windows.Forms.TextBox();
            this.classARevenue = new System.Windows.Forms.TextBox();
            this.classBRevenue = new System.Windows.Forms.TextBox();
            this.classCRevenue = new System.Windows.Forms.TextBox();
            this.totalRevenue = new System.Windows.Forms.TextBox();
            this.classALabel2 = new System.Windows.Forms.Label();
            this.classBLabel2 = new System.Windows.Forms.Label();
            this.classCLabel2 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.ticketsSold.SuspendLayout();
            this.revenueGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSold
            // 
            this.ticketsSold.Controls.Add(this.classBBox);
            this.ticketsSold.Controls.Add(this.classCBox);
            this.ticketsSold.Controls.Add(this.classABox);
            this.ticketsSold.Controls.Add(this.classCLabel);
            this.ticketsSold.Controls.Add(this.classBLabel);
            this.ticketsSold.Controls.Add(this.classALabel);
            this.ticketsSold.Controls.Add(this.label1);
            this.ticketsSold.Location = new System.Drawing.Point(23, 30);
            this.ticketsSold.Name = "ticketsSold";
            this.ticketsSold.Size = new System.Drawing.Size(315, 285);
            this.ticketsSold.TabIndex = 0;
            this.ticketsSold.TabStop = false;
            this.ticketsSold.Text = "Tickets Sold";
            // 
            // revenueGen
            // 
            this.revenueGen.Controls.Add(this.totalLabel);
            this.revenueGen.Controls.Add(this.classCLabel2);
            this.revenueGen.Controls.Add(this.classBLabel2);
            this.revenueGen.Controls.Add(this.classALabel2);
            this.revenueGen.Controls.Add(this.totalRevenue);
            this.revenueGen.Controls.Add(this.classCRevenue);
            this.revenueGen.Controls.Add(this.classBRevenue);
            this.revenueGen.Controls.Add(this.classARevenue);
            this.revenueGen.Location = new System.Drawing.Point(400, 30);
            this.revenueGen.Name = "revenueGen";
            this.revenueGen.Size = new System.Drawing.Size(315, 285);
            this.revenueGen.TabIndex = 1;
            this.revenueGen.TabStop = false;
            this.revenueGen.Text = "Revenue Generated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets \r\nsold for each class of seats.";
            // 
            // calculateRevenue
            // 
            this.calculateRevenue.Location = new System.Drawing.Point(88, 358);
            this.calculateRevenue.Name = "calculateRevenue";
            this.calculateRevenue.Size = new System.Drawing.Size(113, 57);
            this.calculateRevenue.TabIndex = 2;
            this.calculateRevenue.Text = "Calculate Revenue";
            this.calculateRevenue.UseVisualStyleBackColor = true;
            this.calculateRevenue.Click += new System.EventHandler(this.CalculateRevenue_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(255, 358);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 57);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(400, 358);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 57);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // classALabel
            // 
            this.classALabel.AutoSize = true;
            this.classALabel.Location = new System.Drawing.Point(62, 137);
            this.classALabel.Name = "classALabel";
            this.classALabel.Size = new System.Drawing.Size(59, 17);
            this.classALabel.TabIndex = 1;
            this.classALabel.Text = "Class A:";
            // 
            // classBLabel
            // 
            this.classBLabel.AutoSize = true;
            this.classBLabel.Location = new System.Drawing.Point(62, 176);
            this.classBLabel.Name = "classBLabel";
            this.classBLabel.Size = new System.Drawing.Size(59, 17);
            this.classBLabel.TabIndex = 2;
            this.classBLabel.Text = "Class B:";
            // 
            // classCLabel
            // 
            this.classCLabel.AutoSize = true;
            this.classCLabel.Location = new System.Drawing.Point(62, 214);
            this.classCLabel.Name = "classCLabel";
            this.classCLabel.Size = new System.Drawing.Size(59, 17);
            this.classCLabel.TabIndex = 3;
            this.classCLabel.Text = "Class C:";
            // 
            // classABox
            // 
            this.classABox.Location = new System.Drawing.Point(146, 132);
            this.classABox.Name = "classABox";
            this.classABox.Size = new System.Drawing.Size(100, 22);
            this.classABox.TabIndex = 4;
            // 
            // classCBox
            // 
            this.classCBox.Location = new System.Drawing.Point(146, 209);
            this.classCBox.Name = "classCBox";
            this.classCBox.Size = new System.Drawing.Size(100, 22);
            this.classCBox.TabIndex = 5;
            // 
            // classBBox
            // 
            this.classBBox.Location = new System.Drawing.Point(146, 171);
            this.classBBox.Name = "classBBox";
            this.classBBox.Size = new System.Drawing.Size(100, 22);
            this.classBBox.TabIndex = 6;
            // 
            // classARevenue
            // 
            this.classARevenue.Location = new System.Drawing.Point(155, 87);
            this.classARevenue.Name = "classARevenue";
            this.classARevenue.ReadOnly = true;
            this.classARevenue.Size = new System.Drawing.Size(100, 22);
            this.classARevenue.TabIndex = 0;
            // 
            // classBRevenue
            // 
            this.classBRevenue.Location = new System.Drawing.Point(155, 127);
            this.classBRevenue.Name = "classBRevenue";
            this.classBRevenue.ReadOnly = true;
            this.classBRevenue.Size = new System.Drawing.Size(100, 22);
            this.classBRevenue.TabIndex = 1;
            // 
            // classCRevenue
            // 
            this.classCRevenue.Location = new System.Drawing.Point(155, 166);
            this.classCRevenue.Name = "classCRevenue";
            this.classCRevenue.ReadOnly = true;
            this.classCRevenue.Size = new System.Drawing.Size(100, 22);
            this.classCRevenue.TabIndex = 2;
            // 
            // totalRevenue
            // 
            this.totalRevenue.Location = new System.Drawing.Point(155, 219);
            this.totalRevenue.Name = "totalRevenue";
            this.totalRevenue.ReadOnly = true;
            this.totalRevenue.Size = new System.Drawing.Size(100, 22);
            this.totalRevenue.TabIndex = 3;
            // 
            // classALabel2
            // 
            this.classALabel2.AutoSize = true;
            this.classALabel2.Location = new System.Drawing.Point(54, 92);
            this.classALabel2.Name = "classALabel2";
            this.classALabel2.Size = new System.Drawing.Size(59, 17);
            this.classALabel2.TabIndex = 7;
            this.classALabel2.Text = "Class A:";
            // 
            // classBLabel2
            // 
            this.classBLabel2.AutoSize = true;
            this.classBLabel2.Location = new System.Drawing.Point(54, 132);
            this.classBLabel2.Name = "classBLabel2";
            this.classBLabel2.Size = new System.Drawing.Size(59, 17);
            this.classBLabel2.TabIndex = 7;
            this.classBLabel2.Text = "Class B:";
            // 
            // classCLabel2
            // 
            this.classCLabel2.AutoSize = true;
            this.classCLabel2.Location = new System.Drawing.Point(54, 166);
            this.classCLabel2.Name = "classCLabel2";
            this.classCLabel2.Size = new System.Drawing.Size(59, 17);
            this.classCLabel2.TabIndex = 7;
            this.classCLabel2.Text = "Class C:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(69, 224);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 17);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // stadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateRevenue);
            this.Controls.Add(this.revenueGen);
            this.Controls.Add(this.ticketsSold);
            this.Name = "stadiumSeating";
            this.Text = "Stadium Seating";
            this.ticketsSold.ResumeLayout(false);
            this.ticketsSold.PerformLayout();
            this.revenueGen.ResumeLayout(false);
            this.revenueGen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox revenueGen;
        private System.Windows.Forms.Button calculateRevenue;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label classALabel;
        private System.Windows.Forms.Label classCLabel;
        private System.Windows.Forms.Label classBLabel;
        private System.Windows.Forms.TextBox classABox;
        private System.Windows.Forms.TextBox classBBox;
        private System.Windows.Forms.TextBox classCBox;
        private System.Windows.Forms.TextBox classARevenue;
        private System.Windows.Forms.TextBox totalRevenue;
        private System.Windows.Forms.TextBox classCRevenue;
        private System.Windows.Forms.TextBox classBRevenue;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label classCLabel2;
        private System.Windows.Forms.Label classBLabel2;
        private System.Windows.Forms.Label classALabel2;
    }
}

