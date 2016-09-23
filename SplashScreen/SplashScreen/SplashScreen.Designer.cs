namespace SplashScreen
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
            this.splashLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashBackGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // splashLabel
            // 
            this.splashLabel.AutoSize = true;
            this.splashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashLabel.Location = new System.Drawing.Point(29, 149);
            this.splashLabel.Name = "splashLabel";
            this.splashLabel.Size = new System.Drawing.Size(268, 55);
            this.splashLabel.TabIndex = 0;
            this.splashLabel.Text = "Cannonball";
            this.splashLabel.Click += new System.EventHandler(this.splashLabel_Click);
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashBackGround
            // 
            this.SplashBackGround.Image = ((System.Drawing.Image)(resources.GetObject("SplashBackGround.Image")));
            this.SplashBackGround.Location = new System.Drawing.Point(0, 12);
            this.SplashBackGround.Name = "SplashBackGround";
            this.SplashBackGround.Size = new System.Drawing.Size(338, 199);
            this.SplashBackGround.TabIndex = 1;
            this.SplashBackGround.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 213);
            this.Controls.Add(this.splashLabel);
            this.Controls.Add(this.SplashBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "Splash Screen";
            ((System.ComponentModel.ISupportInitialize)(this.SplashBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splashLabel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox SplashBackGround;
    }
}

