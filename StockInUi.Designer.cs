namespace StockManagementSystem
{
    partial class StockInUi
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
            this.companyLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.stockInQuantityLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companySBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDbDataSet3 = new StockManagementSystem.StockManagementSystemDbDataSet3();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockManagementSystemDbDataSet4 = new StockManagementSystem.StockManagementSystemDbDataSet4();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.companySTableAdapter = new StockManagementSystem.StockManagementSystemDbDataSet3TableAdapters.CompanySTableAdapter();
            this.itemsTableAdapter = new StockManagementSystem.StockManagementSystemDbDataSet4TableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companySBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDbDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(49, 39);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(51, 13);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(49, 85);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Item";
            // 
            // reorderLevelLabel
            // 
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Location = new System.Drawing.Point(49, 132);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(74, 13);
            this.reorderLevelLabel.TabIndex = 2;
            this.reorderLevelLabel.Text = "Reorder Level";
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Location = new System.Drawing.Point(49, 180);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(92, 13);
            this.availableQuantityLabel.TabIndex = 3;
            this.availableQuantityLabel.Text = "Available Quantity";
            // 
            // stockInQuantityLabel
            // 
            this.stockInQuantityLabel.AutoSize = true;
            this.stockInQuantityLabel.Location = new System.Drawing.Point(49, 226);
            this.stockInQuantityLabel.Name = "stockInQuantityLabel";
            this.stockInQuantityLabel.Size = new System.Drawing.Size(89, 13);
            this.stockInQuantityLabel.TabIndex = 4;
            this.stockInQuantityLabel.Text = "Stock In Quantity";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(262, 272);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companySBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(163, 36);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(121, 21);
            this.companyComboBox.TabIndex = 6;
            this.companyComboBox.ValueMember = "ID";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companySBindingSource
            // 
            this.companySBindingSource.DataMember = "CompanyS";
            this.companySBindingSource.DataSource = this.stockManagementSystemDbDataSet3;
            // 
            // stockManagementSystemDbDataSet3
            // 
            this.stockManagementSystemDbDataSet3.DataSetName = "StockManagementSystemDbDataSet3";
            this.stockManagementSystemDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemsBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(163, 77);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 21);
            this.itemComboBox.TabIndex = 7;
            this.itemComboBox.ValueMember = "ID";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.stockManagementSystemDbDataSet4;
            // 
            // stockManagementSystemDbDataSet4
            // 
            this.stockManagementSystemDbDataSet4.DataSetName = "StockManagementSystemDbDataSet4";
            this.stockManagementSystemDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(163, 129);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(121, 20);
            this.reorderLevelTextBox.TabIndex = 8;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(163, 180);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.availableQuantityTextBox.TabIndex = 9;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(163, 219);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.stockInQuantityTextBox.TabIndex = 10;
            // 
            // companySTableAdapter
            // 
            this.companySTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // StockInUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 319);
            this.Controls.Add(this.stockInQuantityTextBox);
            this.Controls.Add(this.availableQuantityTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.stockInQuantityLabel);
            this.Controls.Add(this.availableQuantityLabel);
            this.Controls.Add(this.reorderLevelLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.companyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockInUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockInUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companySBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDbDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label reorderLevelLabel;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label stockInQuantityLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private StockManagementSystemDbDataSet3 stockManagementSystemDbDataSet3;
        private System.Windows.Forms.BindingSource companySBindingSource;
        private StockManagementSystemDbDataSet3TableAdapters.CompanySTableAdapter companySTableAdapter;
        private StockManagementSystemDbDataSet4 stockManagementSystemDbDataSet4;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private StockManagementSystemDbDataSet4TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ComboBox companyComboBox;
    }
}