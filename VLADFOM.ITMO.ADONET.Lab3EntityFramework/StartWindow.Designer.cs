
namespace VLADFOM.ITMO.ADONET.Lab3EntityFramework
{
    partial class StartWindow
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
            this.btnAcceptEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcceptEnter
            // 
            this.btnAcceptEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptEnter.Location = new System.Drawing.Point(123, 97);
            this.btnAcceptEnter.Name = "btnAcceptEnter";
            this.btnAcceptEnter.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptEnter.TabIndex = 0;
            this.btnAcceptEnter.Text = "Войти";
            this.btnAcceptEnter.UseVisualStyleBackColor = true;
            this.btnAcceptEnter.Click += new System.EventHandler(this.btnAcceptEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUserName.Location = new System.Drawing.Point(81, 43);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(167, 20);
            this.textBoxUserName.TabIndex = 3;
            // 
            // textBoxUserPwd
            // 
            this.textBoxUserPwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxUserPwd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUserPwd.Location = new System.Drawing.Point(81, 71);
            this.textBoxUserPwd.Name = "textBoxUserPwd";
            this.textBoxUserPwd.Size = new System.Drawing.Size(167, 20);
            this.textBoxUserPwd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(4, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "* Для доступа к системе введите свои учётные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Добро пожаловать!";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 156);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUserPwd);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptEnter);
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные Клиентов";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}