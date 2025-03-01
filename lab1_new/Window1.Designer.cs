namespace lab1_new
{
    partial class Window1
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
            this.label2 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.fileChoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифр Виженера с прямым ключом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ";
            // 
            // keyInput
            // 
            this.keyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput.Location = new System.Drawing.Point(69, 34);
            this.keyInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(164, 27);
            this.keyInput.TabIndex = 2;
            // 
            // fileChoice
            // 
            this.fileChoice.Location = new System.Drawing.Point(239, 37);
            this.fileChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileChoice.Name = "fileChoice";
            this.fileChoice.Size = new System.Drawing.Size(170, 23);
            this.fileChoice.TabIndex = 3;
            this.fileChoice.Text = "Прочитать из файла";
            this.fileChoice.UseVisualStyleBackColor = true;
            this.fileChoice.Click += new System.EventHandler(this.fileChoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Исходный текст:";
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(16, 98);
            this.textInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(381, 27);
            this.textInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результирующий текст:";
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(16, 153);
            this.resultText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(381, 27);
            this.resultText.TabIndex = 7;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 208);
            this.encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(135, 23);
            this.encrypt.TabIndex = 8;
            this.encrypt.Text = "Шифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(153, 208);
            this.decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(135, 23);
            this.decrypt.TabIndex = 9;
            this.decrypt.Text = "Дешифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(294, 208);
            this.clean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(135, 23);
            this.clean.TabIndex = 10;
            this.clean.Text = "Очистить";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(413, 153);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 259);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileChoice);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Window1";
            this.Text = "Виженер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Button fileChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button Save;
    }
}