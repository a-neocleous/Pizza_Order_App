
namespace Pizza_Order_AndreasNeocleous
{
    partial class SettingsForm
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
            this.sizesInSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeDataGridView = new System.Windows.Forms.DataGridView();
            this.sizesResetButton = new System.Windows.Forms.Button();
            this.sizesSaveButton = new System.Windows.Forms.Button();
            this.toppingsInSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.toppingsDataGridView = new System.Windows.Forms.DataGridView();
            this.toppingsResetButton = new System.Windows.Forms.Button();
            this.toppingSaveButton = new System.Windows.Forms.Button();
            this.sizesInSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDataGridView)).BeginInit();
            this.toppingsInSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toppingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sizesInSettingsGroupBox
            // 
            this.sizesInSettingsGroupBox.Controls.Add(this.sizeDataGridView);
            this.sizesInSettingsGroupBox.Controls.Add(this.sizesResetButton);
            this.sizesInSettingsGroupBox.Controls.Add(this.sizesSaveButton);
            this.sizesInSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sizesInSettingsGroupBox.Name = "sizesInSettingsGroupBox";
            this.sizesInSettingsGroupBox.Size = new System.Drawing.Size(350, 504);
            this.sizesInSettingsGroupBox.TabIndex = 0;
            this.sizesInSettingsGroupBox.TabStop = false;
            this.sizesInSettingsGroupBox.Text = "Sizes";
            // 
            // sizeDataGridView
            // 
            this.sizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sizeDataGridView.Location = new System.Drawing.Point(7, 21);
            this.sizeDataGridView.Name = "sizeDataGridView";
            this.sizeDataGridView.RowHeadersWidth = 51;
            this.sizeDataGridView.RowTemplate.Height = 24;
            this.sizeDataGridView.Size = new System.Drawing.Size(337, 432);
            this.sizeDataGridView.TabIndex = 2;
            // 
            // sizesResetButton
            // 
            this.sizesResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sizesResetButton.Location = new System.Drawing.Point(196, 459);
            this.sizesResetButton.Name = "sizesResetButton";
            this.sizesResetButton.Size = new System.Drawing.Size(135, 39);
            this.sizesResetButton.TabIndex = 1;
            this.sizesResetButton.Text = "Reset";
            this.sizesResetButton.UseVisualStyleBackColor = true;
            this.sizesResetButton.Click += new System.EventHandler(this.sizesResetButton_Click);
            // 
            // sizesSaveButton
            // 
            this.sizesSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sizesSaveButton.Location = new System.Drawing.Point(17, 459);
            this.sizesSaveButton.Name = "sizesSaveButton";
            this.sizesSaveButton.Size = new System.Drawing.Size(135, 39);
            this.sizesSaveButton.TabIndex = 0;
            this.sizesSaveButton.Text = "Save";
            this.sizesSaveButton.UseVisualStyleBackColor = true;
            this.sizesSaveButton.Click += new System.EventHandler(this.sizesSaveButton_Click);
            // 
            // toppingsInSettingsGroupBox
            // 
            this.toppingsInSettingsGroupBox.Controls.Add(this.toppingsDataGridView);
            this.toppingsInSettingsGroupBox.Controls.Add(this.toppingsResetButton);
            this.toppingsInSettingsGroupBox.Controls.Add(this.toppingSaveButton);
            this.toppingsInSettingsGroupBox.Location = new System.Drawing.Point(368, 12);
            this.toppingsInSettingsGroupBox.Name = "toppingsInSettingsGroupBox";
            this.toppingsInSettingsGroupBox.Size = new System.Drawing.Size(350, 504);
            this.toppingsInSettingsGroupBox.TabIndex = 1;
            this.toppingsInSettingsGroupBox.TabStop = false;
            this.toppingsInSettingsGroupBox.Text = "Toppings";
            // 
            // toppingsDataGridView
            // 
            this.toppingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toppingsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.toppingsDataGridView.Name = "toppingsDataGridView";
            this.toppingsDataGridView.RowHeadersWidth = 51;
            this.toppingsDataGridView.RowTemplate.Height = 24;
            this.toppingsDataGridView.Size = new System.Drawing.Size(337, 432);
            this.toppingsDataGridView.TabIndex = 4;
            // 
            // toppingsResetButton
            // 
            this.toppingsResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toppingsResetButton.Location = new System.Drawing.Point(197, 459);
            this.toppingsResetButton.Name = "toppingsResetButton";
            this.toppingsResetButton.Size = new System.Drawing.Size(135, 39);
            this.toppingsResetButton.TabIndex = 3;
            this.toppingsResetButton.Text = "Reset";
            this.toppingsResetButton.UseVisualStyleBackColor = true;
            this.toppingsResetButton.Click += new System.EventHandler(this.toppingsResetButton_Click);
            // 
            // toppingSaveButton
            // 
            this.toppingSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toppingSaveButton.Location = new System.Drawing.Point(18, 459);
            this.toppingSaveButton.Name = "toppingSaveButton";
            this.toppingSaveButton.Size = new System.Drawing.Size(135, 39);
            this.toppingSaveButton.TabIndex = 2;
            this.toppingSaveButton.Text = "Save";
            this.toppingSaveButton.UseVisualStyleBackColor = true;
            this.toppingSaveButton.Click += new System.EventHandler(this.toppingSaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 528);
            this.Controls.Add(this.toppingsInSettingsGroupBox);
            this.Controls.Add(this.sizesInSettingsGroupBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.sizesInSettingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sizeDataGridView)).EndInit();
            this.toppingsInSettingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toppingsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sizesInSettingsGroupBox;
        private System.Windows.Forms.GroupBox toppingsInSettingsGroupBox;
        private System.Windows.Forms.DataGridView sizeDataGridView;
        private System.Windows.Forms.Button sizesResetButton;
        private System.Windows.Forms.Button sizesSaveButton;
        private System.Windows.Forms.Button toppingsResetButton;
        private System.Windows.Forms.Button toppingSaveButton;
        private System.Windows.Forms.DataGridView toppingsDataGridView;
    }
}