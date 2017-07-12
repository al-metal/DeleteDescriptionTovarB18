namespace DeleteDescriptionTovarB18
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswords = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnActualPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Логин:";
            // 
            // tbPasswords
            // 
            this.tbPasswords.Location = new System.Drawing.Point(12, 64);
            this.tbPasswords.Name = "tbPasswords";
            this.tbPasswords.Size = new System.Drawing.Size(125, 20);
            this.tbPasswords.TabIndex = 21;
            this.tbPasswords.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 25);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(125, 20);
            this.tbLogin.TabIndex = 20;
            // 
            // btnActualPrice
            // 
            this.btnActualPrice.Location = new System.Drawing.Point(166, 25);
            this.btnActualPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualPrice.Name = "btnActualPrice";
            this.btnActualPrice.Size = new System.Drawing.Size(126, 45);
            this.btnActualPrice.TabIndex = 17;
            this.btnActualPrice.Text = "Актуализировать сайт";
            this.btnActualPrice.UseVisualStyleBackColor = true;
            this.btnActualPrice.Click += new System.EventHandler(this.btnActualPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 109);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswords);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnActualPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswords;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnActualPrice;
    }
}

