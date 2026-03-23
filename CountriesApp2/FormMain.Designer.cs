namespace CountriesApp2
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            labelFilter = new Label();
            labelSort = new Label();
            labelCountries = new Label();
            labelTowns = new Label();
            textBoxFilter = new TextBox();
            comboBoxSort = new ComboBox();
            dataGridViewCountries = new DataGridView();
            countryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryBindingSource = new BindingSource(components);
            dataGridViewTowns = new DataGridView();
            townIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TownName = new DataGridViewTextBoxColumn();
            townBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTowns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)townBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(19, 26);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(120, 15);
            labelFilter.TabIndex = 0;
            labelFilter.Text = "Филтриране по име:";
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.Location = new Point(19, 64);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(87, 15);
            labelSort.TabIndex = 1;
            labelSort.Text = "Сортиране по:";
            // 
            // labelCountries
            // 
            labelCountries.AutoSize = true;
            labelCountries.Location = new Point(19, 109);
            labelCountries.Name = "labelCountries";
            labelCountries.Size = new Size(60, 15);
            labelCountries.TabIndex = 2;
            labelCountries.Text = "Държави:";
            // 
            // labelTowns
            // 
            labelTowns.AutoSize = true;
            labelTowns.Location = new Point(373, 109);
            labelTowns.Name = "labelTowns";
            labelTowns.Size = new Size(54, 15);
            labelTowns.TabIndex = 3;
            labelTowns.Text = "Градове:";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(145, 23);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(200, 23);
            textBoxFilter.TabIndex = 4;
            textBoxFilter.TextChanged += OnTextChanged;
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Име (възходящо)", "Име (низходящо)", "Id (възходящо)", "Id (низходящо)" });
            comboBoxSort.Location = new Point(145, 61);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(200, 23);
            comboBoxSort.TabIndex = 5;
            comboBoxSort.SelectedIndexChanged += OnSelectionIndexChanged;
            // 
            // dataGridViewCountries
            // 
            dataGridViewCountries.AutoGenerateColumns = false;
            dataGridViewCountries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountries.Columns.AddRange(new DataGridViewColumn[] { countryIdDataGridViewTextBoxColumn, countryNameDataGridViewTextBoxColumn });
            dataGridViewCountries.DataSource = countryBindingSource;
            dataGridViewCountries.Location = new Point(19, 127);
            dataGridViewCountries.Name = "dataGridViewCountries";
            dataGridViewCountries.Size = new Size(326, 342);
            dataGridViewCountries.TabIndex = 6;
            dataGridViewCountries.SelectionChanged += OnCountrySelectionChanged;
            // 
            // countryIdDataGridViewTextBoxColumn
            // 
            countryIdDataGridViewTextBoxColumn.DataPropertyName = "CountryId";
            countryIdDataGridViewTextBoxColumn.HeaderText = "Id";
            countryIdDataGridViewTextBoxColumn.Name = "countryIdDataGridViewTextBoxColumn";
            countryIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            countryNameDataGridViewTextBoxColumn.HeaderText = "Държава";
            countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            countryNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(Data.Models.Country);
            // 
            // dataGridViewTowns
            // 
            dataGridViewTowns.AutoGenerateColumns = false;
            dataGridViewTowns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTowns.Columns.AddRange(new DataGridViewColumn[] { townIdDataGridViewTextBoxColumn, TownName });
            dataGridViewTowns.DataSource = townBindingSource;
            dataGridViewTowns.Location = new Point(373, 127);
            dataGridViewTowns.Name = "dataGridViewTowns";
            dataGridViewTowns.Size = new Size(326, 342);
            dataGridViewTowns.TabIndex = 7;
            // 
            // townIdDataGridViewTextBoxColumn
            // 
            townIdDataGridViewTextBoxColumn.DataPropertyName = "TownId";
            townIdDataGridViewTextBoxColumn.HeaderText = "Id";
            townIdDataGridViewTextBoxColumn.Name = "townIdDataGridViewTextBoxColumn";
            townIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // TownName
            // 
            TownName.DataPropertyName = "TownName";
            TownName.HeaderText = "Град";
            TownName.Name = "TownName";
            TownName.Width = 200;
            // 
            // townBindingSource
            // 
            townBindingSource.DataSource = typeof(Data.Models.Town);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 492);
            Controls.Add(dataGridViewTowns);
            Controls.Add(dataGridViewCountries);
            Controls.Add(comboBoxSort);
            Controls.Add(textBoxFilter);
            Controls.Add(labelTowns);
            Controls.Add(labelCountries);
            Controls.Add(labelSort);
            Controls.Add(labelFilter);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Държави и градове";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountries).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTowns).EndInit();
            ((System.ComponentModel.ISupportInitialize)townBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFilter;
        private Label labelSort;
        private Label labelCountries;
        private Label labelTowns;
        private TextBox textBoxFilter;
        private ComboBox comboBoxSort;
        private DataGridView dataGridViewCountries;
        private DataGridView dataGridViewTowns;
        private BindingSource countryBindingSource;
        private BindingSource townBindingSource;
        private DataGridViewTextBoxColumn countryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn townIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TownName;
    }
}
