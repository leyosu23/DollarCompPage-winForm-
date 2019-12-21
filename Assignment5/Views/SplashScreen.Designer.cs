namespace Assignment5.Views
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.SpalshLoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashWelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpalshLoadingTimer
            // 
            this.SpalshLoadingTimer.Enabled = true;
            this.SpalshLoadingTimer.Interval = 3000;
            this.SpalshLoadingTimer.Tick += new System.EventHandler(this.SpalshLoadingTimer_Tick);
            // 
            // SplashWelcomeLabel
            // 
            this.SplashWelcomeLabel.AutoSize = true;
            this.SplashWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashWelcomeLabel.Font = new System.Drawing.Font("Gulim", 24F);
            this.SplashWelcomeLabel.ForeColor = System.Drawing.Color.Gold;
            this.SplashWelcomeLabel.Location = new System.Drawing.Point(177, 474);
            this.SplashWelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SplashWelcomeLabel.Name = "SplashWelcomeLabel";
            this.SplashWelcomeLabel.Size = new System.Drawing.Size(445, 32);
            this.SplashWelcomeLabel.TabIndex = 0;
            this.SplashWelcomeLabel.Text = "Welcome to Dollar Computer";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment5.Properties.Resources.laptop_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.SplashWelcomeLabel);
            this.Font = new System.Drawing.Font("Gulim", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SpalshLoadingTimer;
        private System.Windows.Forms.Label SplashWelcomeLabel;
    }
}