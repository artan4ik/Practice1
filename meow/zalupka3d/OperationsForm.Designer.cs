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
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.Location = new System.Drawing.Point(483, 119);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOperation.TabIndex = 0;
            this.buttonAddOperation.Text = "Добавить";
            this.buttonAddOperation.UseVisualStyleBackColor = true;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // buttonEditOperation
            // 
            this.buttonEditOperation.Location = new System.Drawing.Point(564, 119);
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
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(492, 93);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(121, 20);
            this.textBoxStatus.TabIndex = 11;
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
            // OperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStatus);
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
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button button1;
    }
}