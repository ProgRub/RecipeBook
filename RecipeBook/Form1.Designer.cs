
namespace RecipeBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homeScreen1 = new RecipeBook.HomeScreen();
            this.SuspendLayout();
            // 
            // homeScreen1
            // 
            this.homeScreen1.AutoSize = true;
            this.homeScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeScreen1.BackColor = System.Drawing.Color.Transparent;
            this.homeScreen1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.homeScreen1.Location = new System.Drawing.Point(12, 12);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.Size = new System.Drawing.Size(131, 69);
            this.homeScreen1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeScreen1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(255)))), ((int)(((byte)(49)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HomeScreen homeScreen1;
    }
}

