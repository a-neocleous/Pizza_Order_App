
namespace Pizza_Order_AndreasNeocleous
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
            this.pizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaPictureBox
            // 
            this.pizzaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pizzaPictureBox.Image")));
            this.pizzaPictureBox.Location = new System.Drawing.Point(241, 139);
            this.pizzaPictureBox.Name = "pizzaPictureBox";
            this.pizzaPictureBox.Size = new System.Drawing.Size(292, 209);
            this.pizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pizzaPictureBox.TabIndex = 15;
            this.pizzaPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 45);
            this.label1.MaximumSize = new System.Drawing.Size(330, 60);
            this.label1.MinimumSize = new System.Drawing.Size(650, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 80);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome to Pizzathlon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 550;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizzaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pizzaPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}