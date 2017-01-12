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
            this.AllRecipesButton.Location = new System.Drawing.Point(411, 63);
            this.AllRecipesButton.Name = "AllRecipesButton";
            this.AllRecipesButton.Size = new System.Drawing.Size(320, 33);
            this.AllRecipesButton.TabIndex = 1;
            this.AllRecipesButton.Text = "All recipes";
            this.AllRecipesButton.UseVisualStyleBackColor = true;
            // 
            // RecipesDisplay
            // 
            this.RecipesDisplay.Location = new System.Drawing.Point(12, 112);
            this.RecipesDisplay.Name = "RecipesDisplay";
            this.RecipesDisplay.Size = new System.Drawing.Size(1183, 22);
            this.RecipesDisplay.TabIndex = 2;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 685);
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
    }
}