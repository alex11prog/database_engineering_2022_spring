namespace kr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofoperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesoperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pdbDataSet = new kr.pdbDataSet();
            this.expenses_operationTableAdapter = new kr.pdbDataSetTableAdapters.expenses_operationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button_calc = new System.Windows.Forms.Button();
            this.label_calc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_load_hibernate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesoperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHB)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.summDataGridViewTextBoxColumn,
            this.dateofoperationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expensesoperationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(465, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            this.summDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofoperationDataGridViewTextBoxColumn
            // 
            this.dateofoperationDataGridViewTextBoxColumn.DataPropertyName = "date_of_operation";
            this.dateofoperationDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateofoperationDataGridViewTextBoxColumn.Name = "dateofoperationDataGridViewTextBoxColumn";
            this.dateofoperationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expensesoperationBindingSource
            // 
            this.expensesoperationBindingSource.DataMember = "expenses_operation";
            this.expensesoperationBindingSource.DataSource = this.pdbDataSet;
            // 
            // pdbDataSet
            // 
            this.pdbDataSet.DataSetName = "pdbDataSet";
            this.pdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenses_operationTableAdapter
            // 
            this.expenses_operationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(375, 629);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(102, 23);
            this.button_calc.TabIndex = 2;
            this.button_calc.Text = "Посчитать";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // label_calc
            // 
            this.label_calc.AutoSize = true;
            this.label_calc.Location = new System.Drawing.Point(12, 629);
            this.label_calc.Name = "label_calc";
            this.label_calc.Size = new System.Drawing.Size(166, 17);
            this.label_calc.TabIndex = 3;
            this.label_calc.Text = "Общая сумма расходов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Таблица расходов с подключением источника данных в DataGridView";
            // 
            // dataGridViewHB
            // 
            this.dataGridViewHB.AllowUserToAddRows = false;
            this.dataGridViewHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHB.Location = new System.Drawing.Point(580, 37);
            this.dataGridViewHB.Name = "dataGridViewHB";
            this.dataGridViewHB.RowTemplate.Height = 24;
            this.dataGridViewHB.Size = new System.Drawing.Size(457, 564);
            this.dataGridViewHB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Таблица категорий(маппинг  hibernate)";
            // 
            // button_load_hibernate
            // 
            this.button_load_hibernate.Location = new System.Drawing.Point(940, 629);
            this.button_load_hibernate.Name = "button_load_hibernate";
            this.button_load_hibernate.Size = new System.Drawing.Size(97, 23);
            this.button_load_hibernate.TabIndex = 8;
            this.button_load_hibernate.Text = "Загрузить";
            this.button_load_hibernate.UseVisualStyleBackColor = true;
            this.button_load_hibernate.Click += new System.EventHandler(this.button_load_hibernate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 667);
            this.Controls.Add(this.button_load_hibernate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewHB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_calc);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesoperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private pdbDataSet pdbDataSet;
        private System.Windows.Forms.BindingSource expensesoperationBindingSource;
        private pdbDataSetTableAdapters.expenses_operationTableAdapter expenses_operationTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Label label_calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofoperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewHB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_load_hibernate;
    }
}

