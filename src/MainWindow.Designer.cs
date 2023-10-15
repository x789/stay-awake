
namespace StayAwake
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AllowDisplaySleep = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AllowDisplaySleep
            // 
            this.AllowDisplaySleep.AutoSize = true;
            this.AllowDisplaySleep.Location = new System.Drawing.Point(12, 7);
            this.AllowDisplaySleep.Name = "AllowDisplaySleep";
            this.AllowDisplaySleep.Size = new System.Drawing.Size(153, 19);
            this.AllowDisplaySleep.TabIndex = 0;
            this.AllowDisplaySleep.Text = "Allow display to turn off";
            this.AllowDisplaySleep.UseVisualStyleBackColor = true;
            this.AllowDisplaySleep.CheckedChanged += new System.EventHandler(this.HandleChangedSettings);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 41);
            this.Controls.Add(this.AllowDisplaySleep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 80);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 80);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stay Awake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AllowDisplaySleep;
    }
}

