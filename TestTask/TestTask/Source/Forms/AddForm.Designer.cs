namespace TestTask
{
    partial class AddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AssetsFieldsData = new System.Windows.Forms.DataGridView();
            this.NameOfField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueOfField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetsTypeMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsFieldsData)).BeginInit();
            this.SuspendLayout();
            // 
            // AssetsFieldsData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssetsFieldsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AssetsFieldsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssetsFieldsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfField,
            this.ValueOfField});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AssetsFieldsData.DefaultCellStyle = dataGridViewCellStyle2;
            this.AssetsFieldsData.Location = new System.Drawing.Point(12, 48);
            this.AssetsFieldsData.Name = "AssetsFieldsData";
            this.AssetsFieldsData.Size = new System.Drawing.Size(618, 348);
            this.AssetsFieldsData.TabIndex = 0;
            this.AssetsFieldsData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AssetsFieldsData_DataError);
            this.AssetsFieldsData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.AssetsFieldsData_RowsAdded);
            // 
            // NameOfField
            // 
            this.NameOfField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameOfField.HeaderText = "Название";
            this.NameOfField.Name = "NameOfField";
            this.NameOfField.ReadOnly = true;
            this.NameOfField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameOfField.Width = 89;
            // 
            // ValueOfField
            // 
            this.ValueOfField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueOfField.HeaderText = "Значение";
            this.ValueOfField.Name = "ValueOfField";
            this.ValueOfField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AssetsTypeMenu
            // 
            this.AssetsTypeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AssetsTypeMenu.FormattingEnabled = true;
            this.AssetsTypeMenu.Location = new System.Drawing.Point(138, 10);
            this.AssetsTypeMenu.Name = "AssetsTypeMenu";
            this.AssetsTypeMenu.Size = new System.Drawing.Size(220, 28);
            this.AssetsTypeMenu.TabIndex = 1;
            this.AssetsTypeMenu.Text = "Выберите тип актива";
            this.AssetsTypeMenu.SelectedValueChanged += new System.EventHandler(this.AssetsTypeMenu_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип актива";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 402);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(618, 41);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssetsTypeMenu);
            this.Controls.Add(this.AssetsFieldsData);
            this.Name = "AddForm";
            this.Text = "Добавить актив";
            ((System.ComponentModel.ISupportInitialize)(this.AssetsFieldsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AssetsFieldsData;
        private System.Windows.Forms.ComboBox AssetsTypeMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueOfField;
    }
}