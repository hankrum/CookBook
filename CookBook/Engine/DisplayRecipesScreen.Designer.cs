namespace CookBook.Engine
{
    partial class DisplayRecipesScreen
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
            this.DisplayRecipesHeading = new System.Windows.Forms.Label();
            this.DisplayRecipesText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DisplayRecipesHeading
            // 
            this.DisplayRecipesHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DisplayRecipesHeading.AutoSize = true;
            this.DisplayRecipesHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayRecipesHeading.Location = new System.Drawing.Point(157, 34);
            this.DisplayRecipesHeading.Name = "DisplayRecipesHeading";
            this.DisplayRecipesHeading.Size = new System.Drawing.Size(79, 29);
            this.DisplayRecipesHeading.TabIndex = 0;
            this.DisplayRecipesHeading.Text = "label1";
            this.DisplayRecipesHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayRecipesText
            // 
            this.DisplayRecipesText.Location = new System.Drawing.Point(34, 90);
            this.DisplayRecipesText.Name = "DisplayRecipesText";
            this.DisplayRecipesText.Size = new System.Drawing.Size(1171, 22);
            this.DisplayRecipesText.TabIndex = 1;
            // 
            // DisplayRecipesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 673);
            this.Controls.Add(this.DisplayRecipesText);
            this.Controls.Add(this.DisplayRecipesHeading);
            this.Name = "DisplayRecipesScreen";
            this.Text = "DisplayRecipesScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayRecipesHeading;
        private System.Windows.Forms.TextBox DisplayRecipesText;
    }
}