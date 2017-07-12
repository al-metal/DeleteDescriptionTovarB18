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
            this.lblVsegoRazdelov = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRazdel = new System.Windows.Forms.Label();
            this.lblNamePosition = new System.Windows.Forms.Label();
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
            this.btnActualPrice.Location = new System.Drawing.Point(142, 25);
            this.btnActualPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualPrice.Name = "btnActualPrice";
            this.btnActualPrice.Size = new System.Drawing.Size(126, 45);
            this.btnActualPrice.TabIndex = 17;
            this.btnActualPrice.Text = "Актуализировать сайт";
            this.btnActualPrice.UseVisualStyleBackColor = true;
            this.btnActualPrice.Click += new System.EventHandler(this.btnActualPrice_Click);
            // 
            // lblVsegoRazdelov
            // 
            this.lblVsegoRazdelov.AutoSize = true;
            this.lblVsegoRazdelov.Location = new System.Drawing.Point(240, 72);
            this.lblVsegoRazdelov.Name = "lblVsegoRazdelov";
            this.lblVsegoRazdelov.Size = new System.Drawing.Size(13, 13);
            this.lblVsegoRazdelov.TabIndex = 27;
            this.lblVsegoRazdelov.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "из";
            // 
            // lblRazdel
            // 
            this.lblRazdel.AutoSize = true;
            this.lblRazdel.Location = new System.Drawing.Point(187, 72);
            this.lblRazdel.Name = "lblRazdel";
            this.lblRazdel.Size = new System.Drawing.Size(13, 13);
            this.lblRazdel.TabIndex = 25;
            this.lblRazdel.Text = "0";
            // 
            // lblNamePosition
            // 
            this.lblNamePosition.AutoSize = true;
            this.lblNamePosition.Location = new System.Drawing.Point(143, 72);
            this.lblNamePosition.Name = "lblNamePosition";
            this.lblNamePosition.Size = new System.Drawing.Size(38, 13);
            this.lblNamePosition.TabIndex = 24;
            this.lblNamePosition.Text = "Товар";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 150);
            this.Controls.Add(this.lblVsegoRazdelov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRazdel);
            this.Controls.Add(this.lblNamePosition);
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
        private System.Windows.Forms.Label lblVsegoRazdelov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRazdel;
        private System.Windows.Forms.Label lblNamePosition;
    }
}

