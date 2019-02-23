namespace StockManagementSystem
{
    partial class CategorySetupUi
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
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AllowUserToAddRows = false;
            this.displayDataGridView.AllowUserToDeleteRows = false;
            this.displayDataGridView.AllowUserToResizeColumns = false;
            this.displayDataGridView.AllowUserToResizeRows = false;
            this.displayDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.displayDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Location = new System.Drawing.Point(63, 126);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.displayDataGridView.RowHeadersVisible = false;
            this.displayDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayDataGridView.Size = new System.Drawing.Size(301, 150);
            this.displayDataGridView.TabIndex = 2;
            this.displayDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDataGridView_CellContentDoubleClick);        
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(256, 85);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(73, 24);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(169, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(91, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // CategorySetupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(454, 300);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.displayDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CategorySetupUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category Setup";
            this.Load += new System.EventHandler(this.CategorySetupUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}