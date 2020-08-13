namespace TestTask
{
    partial class EditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AssetsFieldsData = new System.Windows.Forms.DataGridView();
            this.NameOfField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueOfField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssetsFieldsData)).BeginInit();
            this.SuspendLayout();
            // 
            // AssetsFieldsData
            // 
            this.AssetsFieldsData.AllowUserToAddRows = false;
            this.AssetsFieldsData.AllowUserToDeleteRows = false;
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
            this.AssetsFieldsData.Location = new System.Drawing.Point(12, 12);
            this.AssetsFieldsData.MultiSelect = false;
            this.AssetsFieldsData.Name = "AssetsFieldsData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssetsFieldsData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AssetsFieldsData.Size = new System.Drawing.Size(710, 378);
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
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(12, 396);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(710, 42);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.Text = "Применить изменения";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.AssetsFieldsData);
            this.Name = "EditForm";
            this.Text = "Редактирование актива";
            ((System.ComponentModel.ISupportInitialize)(this.AssetsFieldsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AssetsFieldsData;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueOfField;
    }
}