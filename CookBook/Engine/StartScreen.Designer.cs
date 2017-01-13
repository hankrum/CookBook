namespace CookBook.Engine
{
    partial class StartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.AllRecipesButton = new System.Windows.Forms.Button();
            this.RecipesDisplay = new System.Windows.Forms.TextBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.RecipeTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your Cook Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AllRecipesButton
            // 
            this.AllRecipesButton.Location = new System.Drawing.Point(1365, 76);
            this.AllRecipesButton.Name = "AllRecipesButton";
            this.AllRecipesButton.Size = new System.Drawing.Size(114, 33);
            this.AllRecipesButton.TabIndex = 1;
            this.AllRecipesButton.Text = "All recipes";
            this.AllRecipesButton.UseVisualStyleBackColor = true;
            // 
            // RecipesDisplay
            // 
            this.RecipesDisplay.Location = new System.Drawing.Point(12, 112);
            this.RecipesDisplay.Name = "RecipesDisplay";
            this.RecipesDisplay.Size = new System.Drawing.Size(1467, 22);
            this.RecipesDisplay.TabIndex = 2;
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(30, 61);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(57, 17);
            this.ProductLabel.TabIndex = 3;
            this.ProductLabel.Text = "Product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 4;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(393, 61);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(140, 17);
            this.DurationLabel.TabIndex = 5;
            this.DurationLabel.Text = "Max preparation time";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(396, 81);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 22);
            this.DurationTextBox.TabIndex = 6;
            // 
            // RecipeTypeLabel
            // 
            this.RecipeTypeLabel.AutoSize = true;
            this.RecipeTypeLabel.Location = new System.Drawing.Point(211, 58);
            this.RecipeTypeLabel.Name = "RecipeTypeLabel";
            this.RecipeTypeLabel.Size = new System.Drawing.Size(83, 17);
            this.RecipeTypeLabel.TabIndex = 7;
            this.RecipeTypeLabel.Text = "Recipe type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(575, 61);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(68, 17);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Max price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(555, 81);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 10;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 685);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RecipeTypeLabel);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.RecipesDisplay);
            this.Controls.Add(this.AllRecipesButton);
            this.Controls.Add(this.label1);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AllRecipesButton;
        private System.Windows.Forms.TextBox RecipesDisplay;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label RecipeTypeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}