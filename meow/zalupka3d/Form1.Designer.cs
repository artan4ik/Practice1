namespace meow11
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
            this.buttonOperations = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOperations
            // 
            this.buttonOperations.Location = new System.Drawing.Point(310, 186);
            this.buttonOperations.Name = "buttonOperations";
            this.buttonOperations.Size = new System.Drawing.Size(160, 44);
            this.buttonOperations.TabIndex = 0;
            this.buttonOperations.Text = "Операции";
            this.buttonOperations.UseVisualStyleBackColor = true;
            this.buttonOperations.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(12, 12);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(160, 44);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(12, 73);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(160, 44);
            this.buttonEmployees.TabIndex = 2;
            this.buttonEmployees.Text = "Работники";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(628, 394);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(160, 44);
            this.buttonStatistics.TabIndex = 3;
            this.buttonStatistics.Text = "Стаистика";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(12, 394);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(160, 44);
            this.buttonItems.TabIndex = 4;
            this.buttonItems.Text = "Вещи";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выйти из приложения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOperations;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button button1;
    }
}

