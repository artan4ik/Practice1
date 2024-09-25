namespace meow11
{
    partial class OperationsForm
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
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.buttonEditOperation = new System.Windows.Forms.Button();
            this.buttonDeleteOperation = new System.Windows.Forms.Button();
            this.dataGridViewOperations = new System.Windows.Forms.DataGridView();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearchEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchItem = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchStatus = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.Location = new System.Drawing.Point(483, 131);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOperation.TabIndex = 0;
            this.buttonAddOperation.Text = "Добавить";
            this.buttonAddOperation.UseVisualStyleBackColor = true;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // buttonEditOperation
            // 
            this.buttonEditOperation.Location = new System.Drawing.Point(578, 131);
            this.buttonEditOperation.Name = "buttonEditOperation";
            this.buttonEditOperation.Size = new System.Drawing.Size(75, 23);
            this.buttonEditOperation.TabIndex = 1;
            this.buttonEditOperation.Text = "Изменить";
            this.buttonEditOperation.UseVisualStyleBackColor = true;
            this.buttonEditOperation.Click += new System.EventHandler(this.buttonEditOperation_Click);
            // 
            // buttonDeleteOperation
            // 
            this.buttonDeleteOperation.Location = new System.Drawing.Point(648, 388);
            this.buttonDeleteOperation.Name = "buttonDeleteOperation";
            this.buttonDeleteOperation.Size = new System.Drawing.Size(140, 40);
            this.buttonDeleteOperation.TabIndex = 2;
            this.buttonDeleteOperation.Text = "Удалить";
            this.buttonDeleteOperation.UseVisualStyleBackColor = true;
            this.buttonDeleteOperation.Click += new System.EventHandler(this.buttonDeleteOperation_Click);
            // 
            // dataGridViewOperations
            // 
            this.dataGridViewOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperations.Location = new System.Drawing.Point(2, 3);
            this.dataGridViewOperations.Name = "dataGridViewOperations";
            this.dataGridViewOperations.Size = new System.Drawing.Size(475, 447);
            this.dataGridViewOperations.TabIndex = 3;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(492, 12);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployee.TabIndex = 8;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(492, 39);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItem.TabIndex = 9;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(492, 66);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(713, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Работник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Вещь";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Клиент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Статус готовности";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(492, 92);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // comboBoxSearchClient
            // 
            this.comboBoxSearchClient.FormattingEnabled = true;
            this.comboBoxSearchClient.Location = new System.Drawing.Point(492, 204);
            this.comboBoxSearchClient.Name = "comboBoxSearchClient";
            this.comboBoxSearchClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchClient.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(574, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Поиск";
            // 
            // comboBoxSearchEmployee
            // 
            this.comboBoxSearchEmployee.FormattingEnabled = true;
            this.comboBoxSearchEmployee.Location = new System.Drawing.Point(492, 243);
            this.comboBoxSearchEmployee.Name = "comboBoxSearchEmployee";
            this.comboBoxSearchEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchEmployee.TabIndex = 22;
            // 
            // comboBoxSearchItem
            // 
            this.comboBoxSearchItem.FormattingEnabled = true;
            this.comboBoxSearchItem.Location = new System.Drawing.Point(634, 204);
            this.comboBoxSearchItem.Name = "comboBoxSearchItem";
            this.comboBoxSearchItem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchItem.TabIndex = 23;
            // 
            // comboBoxSearchStatus
            // 
            this.comboBoxSearchStatus.FormattingEnabled = true;
            this.comboBoxSearchStatus.Location = new System.Drawing.Point(634, 243);
            this.comboBoxSearchStatus.Name = "comboBoxSearchStatus";
            this.comboBoxSearchStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchStatus.TabIndex = 24;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(558, 293);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 23);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearchStatus);
            this.Controls.Add(this.comboBoxSearchItem);
            this.Controls.Add(this.comboBoxSearchEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSearchClient);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.dataGridViewOperations);
            this.Controls.Add(this.buttonDeleteOperation);
            this.Controls.Add(this.buttonEditOperation);
            this.Controls.Add(this.buttonAddOperation);
            this.Name = "OperationsForm";
            this.Text = "OperationsForm";
            this.Load += new System.EventHandler(this.OperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.Button buttonEditOperation;
        private System.Windows.Forms.Button buttonDeleteOperation;
        private System.Windows.Forms.DataGridView dataGridViewOperations;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxSearchClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearchEmployee;
        private System.Windows.Forms.ComboBox comboBoxSearchItem;
        private System.Windows.Forms.ComboBox comboBoxSearchStatus;
        private System.Windows.Forms.Button buttonSearch;
    }
}