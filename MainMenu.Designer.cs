
using System;

namespace Pizza_Order_AndreasNeocleous
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.placeorderButton = new System.Windows.Forms.Button();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deliverytimeLabel = new System.Windows.Forms.Label();
            this.ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            this.toppingsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ingredientsGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // placeorderButton
            // 
            this.placeorderButton.BackColor = System.Drawing.Color.Red;
            this.placeorderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.placeorderButton.Location = new System.Drawing.Point(325, 579);
            this.placeorderButton.Name = "placeorderButton";
            this.placeorderButton.Size = new System.Drawing.Size(322, 44);
            this.placeorderButton.TabIndex = 23;
            this.placeorderButton.Text = "Place Order";
            this.placeorderButton.UseVisualStyleBackColor = false;
            this.placeorderButton.Click += new System.EventHandler(this.placeorderButton_Click);
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.AutoSize = true;
            this.totalpriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalpriceLabel.Location = new System.Drawing.Point(565, 517);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(92, 17);
            this.totalpriceLabel.TabIndex = 22;
            this.totalpriceLabel.Text = "Total Price:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(325, 514);
            this.timeTextBox.Mask = "00:00";
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(63, 22);
            this.timeTextBox.TabIndex = 21;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // deliverytimeLabel
            // 
            this.deliverytimeLabel.AutoSize = true;
            this.deliverytimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deliverytimeLabel.Location = new System.Drawing.Point(197, 517);
            this.deliverytimeLabel.Name = "deliverytimeLabel";
            this.deliverytimeLabel.Size = new System.Drawing.Size(112, 17);
            this.deliverytimeLabel.TabIndex = 20;
            this.deliverytimeLabel.Text = "Delivery time: ";
            // 
            // ingredientsGroupBox
            // 
            this.ingredientsGroupBox.Controls.Add(this.toppingsFlowLayoutPanel);
            this.ingredientsGroupBox.Controls.Add(this.toppingsLabel);
            this.ingredientsGroupBox.Location = new System.Drawing.Point(358, 192);
            this.ingredientsGroupBox.Name = "ingredientsGroupBox";
            this.ingredientsGroupBox.Size = new System.Drawing.Size(529, 295);
            this.ingredientsGroupBox.TabIndex = 19;
            this.ingredientsGroupBox.TabStop = false;
            this.ingredientsGroupBox.UseCompatibleTextRendering = true;
            // 
            // toppingsFlowLayoutPanel
            // 
            this.toppingsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.toppingsFlowLayoutPanel.Location = new System.Drawing.Point(6, 55);
            this.toppingsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(12);
            this.toppingsFlowLayoutPanel.Name = "toppingsFlowLayoutPanel";
            this.toppingsFlowLayoutPanel.Size = new System.Drawing.Size(508, 225);
            this.toppingsFlowLayoutPanel.TabIndex = 10;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toppingsLabel.Location = new System.Drawing.Point(6, 18);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(102, 25);
            this.toppingsLabel.TabIndex = 3;
            this.toppingsLabel.Text = "Toppings";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.sizeFlowLayoutPanel);
            this.sizeGroupBox.Controls.Add(this.sizeLabel);
            this.sizeGroupBox.Location = new System.Drawing.Point(128, 192);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(196, 295);
            this.sizeGroupBox.TabIndex = 18;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.UseCompatibleTextRendering = true;
            // 
            // sizeFlowLayoutPanel
            // 
            this.sizeFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sizeFlowLayoutPanel.Location = new System.Drawing.Point(11, 55);
            this.sizeFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(12);
            this.sizeFlowLayoutPanel.Name = "sizeFlowLayoutPanel";
            this.sizeFlowLayoutPanel.Size = new System.Drawing.Size(170, 231);
            this.sizeFlowLayoutPanel.TabIndex = 26;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sizeLabel.Location = new System.Drawing.Point(6, 18);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(55, 25);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(171, 88);
            this.label1.MaximumSize = new System.Drawing.Size(330, 60);
            this.label1.MinimumSize = new System.Drawing.Size(330, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome to Pizzathlon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(680, 517);
            this.priceLabel.MinimumSize = new System.Drawing.Size(85, 20);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(85, 20);
            this.priceLabel.TabIndex = 26;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 675);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.placeorderButton);
            this.Controls.Add(this.totalpriceLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.deliverytimeLabel);
            this.Controls.Add(this.ingredientsGroupBox);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ingredientsGroupBox.ResumeLayout(false);
            this.ingredientsGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button placeorderButton;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.MaskedTextBox timeTextBox;
        private System.Windows.Forms.Label deliverytimeLabel;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel toppingsFlowLayoutPanel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sizeFlowLayoutPanel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}