namespace lab1_new
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
            this.vigener = new System.Windows.Forms.Button();
            this.playfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vigener
            // 
            this.vigener.Location = new System.Drawing.Point(139, 182);
            this.vigener.Name = "vigener";
            this.vigener.Size = new System.Drawing.Size(240, 78);
            this.vigener.TabIndex = 0;
            this.vigener.Text = "Виженер, прямой ключ";
            this.vigener.UseVisualStyleBackColor = true;
            this.vigener.Click += new System.EventHandler(this.vigener_Click);
            // 
            // playfer
            // 
            this.playfer.Location = new System.Drawing.Point(140, 77);
            this.playfer.Name = "playfer";
            this.playfer.Size = new System.Drawing.Size(240, 78);
            this.playfer.TabIndex = 1;
            this.playfer.Text = "Плейфейр с 4мя шифрующими таблицами";
            this.playfer.UseVisualStyleBackColor = true;
            this.playfer.Click += new System.EventHandler(this.playfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите способ шифрования:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playfer);
            this.Controls.Add(this.vigener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button vigener;
        private System.Windows.Forms.Button playfer;
        private System.Windows.Forms.Label label1;
        #endregion
    }
}

