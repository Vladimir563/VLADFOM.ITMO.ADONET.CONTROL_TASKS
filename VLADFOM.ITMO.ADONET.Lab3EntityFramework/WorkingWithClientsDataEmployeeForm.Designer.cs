
namespace VLADFOM.ITMO.ADONET.Lab3EntityFramework
{
    partial class WorkingWithClientsDataEmployeeForm
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
            this.dataGridViewForEmployees = new System.Windows.Forms.DataGridView();
            this.labelLastUpdateDate = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.textBoxClientLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerClientRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxClientFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForEmployees
            // 
            this.dataGridViewForEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewForEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewForEmployees.Name = "dataGridViewForEmployees";
            this.dataGridViewForEmployees.Size = new System.Drawing.Size(411, 167);
            this.dataGridViewForEmployees.TabIndex = 0;
            // 
            // labelLastUpdateDate
            // 
            this.labelLastUpdateDate.AutoSize = true;
            this.labelLastUpdateDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLastUpdateDate.Location = new System.Drawing.Point(9, 173);
            this.labelLastUpdateDate.Name = "labelLastUpdateDate";
            this.labelLastUpdateDate.Size = new System.Drawing.Size(0, 13);
            this.labelLastUpdateDate.TabIndex = 2;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Location = new System.Drawing.Point(12, 276);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(256, 34);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Location = new System.Drawing.Point(294, 276);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(105, 34);
            this.btnDeleteClient.TabIndex = 5;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // textBoxClientLastName
            // 
            this.textBoxClientLastName.Location = new System.Drawing.Point(74, 224);
            this.textBoxClientLastName.Name = "textBoxClientLastName";
            this.textBoxClientLastName.Size = new System.Drawing.Size(194, 20);
            this.textBoxClientLastName.TabIndex = 2;
            // 
            // dateTimePickerClientRegisterDate
            // 
            this.dateTimePickerClientRegisterDate.Location = new System.Drawing.Point(121, 250);
            this.dateTimePickerClientRegisterDate.Name = "dateTimePickerClientRegisterDate";
            this.dateTimePickerClientRegisterDate.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerClientRegisterDate.TabIndex = 3;
            // 
            // textBoxClientFirstName
            // 
            this.textBoxClientFirstName.Location = new System.Drawing.Point(74, 198);
            this.textBoxClientFirstName.Name = "textBoxClientFirstName";
            this.textBoxClientFirstName.Size = new System.Drawing.Size(194, 20);
            this.textBoxClientFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата регистрации:";
            // 
            // WorkingWithClientsDataEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClientFirstName);
            this.Controls.Add(this.dateTimePickerClientRegisterDate);
            this.Controls.Add(this.textBoxClientLastName);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.labelLastUpdateDate);
            this.Controls.Add(this.dataGridViewForEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WorkingWithClientsDataEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с клиентской базой";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkingWithClientsDataEmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkingWithClientsDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForEmployees;
        private System.Windows.Forms.Label labelLastUpdateDate;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.TextBox textBoxClientLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerClientRegisterDate;
        private System.Windows.Forms.TextBox textBoxClientFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

