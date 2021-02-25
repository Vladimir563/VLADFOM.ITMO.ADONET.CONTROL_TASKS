
namespace VLADFOM.ITMO.ADONET.Lab3EntityFramework
{
    partial class WorkingWithClientsDataClientsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewForEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Для клиентов";
            // 
            // dataGridViewForEmployees
            // 
            this.dataGridViewForEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForEmployees.Location = new System.Drawing.Point(13, 32);
            this.dataGridViewForEmployees.Name = "dataGridViewForEmployees";
            this.dataGridViewForEmployees.Size = new System.Drawing.Size(383, 150);
            this.dataGridViewForEmployees.TabIndex = 3;
            // 
            // WorkingWithClientsDataClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewForEmployees);
            this.Name = "WorkingWithClientsDataClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр данных о клиентах";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkingWithClientsDataClientsForm_FormClosed);
            this.Load += new System.EventHandler(this.WorkingWithClientsDataClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewForEmployees;
    }
}