using System.Drawing;
using System;
using System.Windows.Forms;

namespace lab1_new
{
    partial class Window2
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
            this.clean = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileChoice = new System.Windows.Forms.Button();
            this.keyInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyInput2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.keyInput3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.keyInput4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m1 = new System.Windows.Forms.DataGridView();
            this.m2 = new System.Windows.Forms.DataGridView();
            this.m3 = new System.Windows.Forms.DataGridView();
            this.m4 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m4)).BeginInit();
            this.SuspendLayout();
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(284, 309);
            this.clean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(135, 23);
            this.clean.TabIndex = 21;
            this.clean.Text = "Очистить";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(143, 309);
            this.decrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(135, 23);
            this.decrypt.TabIndex = 20;
            this.decrypt.Text = "Дешифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(2, 309);
            this.encrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(135, 23);
            this.encrypt.TabIndex = 19;
            this.encrypt.Text = "Шифровать";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(12, 223);
            this.resultText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(413, 27);
            this.resultText.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Результирующий текст:";
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textInput.Location = new System.Drawing.Point(12, 169);
            this.textInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(413, 27);
            this.textInput.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Исходный текст:";
            // 
            // fileChoice
            // 
            this.fileChoice.Location = new System.Drawing.Point(265, 33);
            this.fileChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileChoice.Name = "fileChoice";
            this.fileChoice.Size = new System.Drawing.Size(170, 23);
            this.fileChoice.TabIndex = 14;
            this.fileChoice.Text = "Прочитать из файла";
            this.fileChoice.UseVisualStyleBackColor = true;
            this.fileChoice.Click += new System.EventHandler(this.fileChoice_Click);
            // 
            // keyInput1
            // 
            this.keyInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput1.Location = new System.Drawing.Point(85, 34);
            this.keyInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyInput1.Name = "keyInput1";
            this.keyInput1.Size = new System.Drawing.Size(158, 27);
            this.keyInput1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ключ 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Шифр Плейфейра с 4мя шифрующими таблицами";
            // 
            // keyInput2
            // 
            this.keyInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput2.Location = new System.Drawing.Point(85, 61);
            this.keyInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyInput2.Name = "keyInput2";
            this.keyInput2.Size = new System.Drawing.Size(158, 27);
            this.keyInput2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ключ 2";
            // 
            // keyInput3
            // 
            this.keyInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput3.Location = new System.Drawing.Point(85, 87);
            this.keyInput3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyInput3.Name = "keyInput3";
            this.keyInput3.Size = new System.Drawing.Size(158, 27);
            this.keyInput3.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ключ 3";
            // 
            // keyInput4
            // 
            this.keyInput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyInput4.Location = new System.Drawing.Point(85, 114);
            this.keyInput4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keyInput4.Name = "keyInput4";
            this.keyInput4.Size = new System.Drawing.Size(158, 27);
            this.keyInput4.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ключ 4";
            // 
            // m1
            // 
            this.m1.AllowUserToDeleteRows = false;
            this.m1.AllowUserToResizeColumns = false;
            this.m1.AllowUserToResizeRows = false;
            this.m1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m1.ColumnHeadersHeight = 29;
            this.m1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.m1.ColumnHeadersVisible = false;
            this.m1.EnableHeadersVisualStyles = false;
            this.m1.Location = new System.Drawing.Point(483, 7);
            this.m1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m1.Name = "m1";
            this.m1.ReadOnly = true;
            this.m1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m1.RowHeadersVisible = false;
            this.m1.RowHeadersWidth = 51;
            this.m1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.m1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m1.Size = new System.Drawing.Size(201, 196);
            this.m1.TabIndex = 28;
            // 
            // m2
            // 
            this.m2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m2.ColumnHeadersVisible = false;
            this.m2.EnableHeadersVisualStyles = false;
            this.m2.Location = new System.Drawing.Point(704, 7);
            this.m2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m2.Name = "m2";
            this.m2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m2.RowHeadersVisible = false;
            this.m2.RowHeadersWidth = 51;
            this.m2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m2.Size = new System.Drawing.Size(199, 196);
            this.m2.TabIndex = 29;
            // 
            // m3
            // 
            this.m3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m3.ColumnHeadersVisible = false;
            this.m3.EnableHeadersVisualStyles = false;
            this.m3.Location = new System.Drawing.Point(483, 229);
            this.m3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m3.Name = "m3";
            this.m3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m3.RowHeadersVisible = false;
            this.m3.RowHeadersWidth = 51;
            this.m3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m3.Size = new System.Drawing.Size(201, 190);
            this.m3.TabIndex = 30;
            // 
            // m4
            // 
            this.m4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m4.ColumnHeadersVisible = false;
            this.m4.EnableHeadersVisualStyles = false;
            this.m4.Location = new System.Drawing.Point(704, 229);
            this.m4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m4.Name = "m4";
            this.m4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.m4.RowHeadersVisible = false;
            this.m4.RowHeadersWidth = 51;
            this.m4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.m4.Size = new System.Drawing.Size(199, 190);
            this.m4.TabIndex = 31;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 264);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 23);
            this.Save.TabIndex = 32;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Window2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 440);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.m4);
            this.Controls.Add(this.m3);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.keyInput4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.keyInput3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.keyInput2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileChoice);
            this.Controls.Add(this.keyInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Window2";
            this.Text = "Плейфейр с 4мя таблицами";
            this.Load += new System.EventHandler(this.Window2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Button clean;
        private Button decrypt;
        private Button encrypt;
        private TextBox resultText;
        private Label label4;
        private TextBox textInput;
        private Label label3;
        private Button fileChoice;
        private TextBox keyInput1;
        private Label label2;
        private Label label1;
        private TextBox keyInput2;
        private Label label5;
        private TextBox keyInput3;
        private Label label6;
        private TextBox keyInput4;
        private Label label7;
        private DataGridView m1;
        private DataGridView m2;
        private DataGridView m3;
        private DataGridView m4;
        private Button Save;
        #endregion
    }
}