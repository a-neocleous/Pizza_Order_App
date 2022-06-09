
namespace Pizza_Order_AndreasNeocleous
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaPictureBox
            // 
            this.pizzaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pizzaPictureBox.Image")));
            this.pizzaPictureBox.Location = new System.Drawing.Point(568, 133);
            this.pizzaPictureBox.Name = "pizzaPictureBox";
            this.pizzaPictureBox.Size = new System.Drawing.Size(180, 126);
            this.pizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pizzaPictureBox.TabIndex = 16;
            this.pizzaPictureBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.Location = new System.Drawing.Point(102, 93);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(117, 24);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Username :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.Location = new System.Drawing.Point(102, 225);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(112, 24);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password :";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(129, 123);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(187, 22);
            this.usernameTextBox.TabIndex = 19;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(129, 252);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(187, 22);
            this.passwordTextBox.TabIndex = 20;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Red;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginButton.Location = new System.Drawing.Point(154, 338);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(141, 34);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pizzaPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pizzaPictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
    }
}