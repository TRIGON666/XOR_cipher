namespace XOR_cipher
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinaryInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBinaryKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrypto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBinaryDec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(42, 66);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(267, 105);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Бинарный исходный текст:";
            // 
            // txtBinaryInput
            // 
            this.txtBinaryInput.Location = new System.Drawing.Point(42, 188);
            this.txtBinaryInput.Multiline = true;
            this.txtBinaryInput.Name = "txtBinaryInput";
            this.txtBinaryInput.ReadOnly = true;
            this.txtBinaryInput.Size = new System.Drawing.Size(267, 105);
            this.txtBinaryInput.TabIndex = 2;
            this.txtBinaryInput.TextChanged += new System.EventHandler(this.txtBinaryInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ключ:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(315, 66);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(95, 103);
            this.txtKey.TabIndex = 4;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Бинарный ключ:";
            // 
            // txtBinaryKey
            // 
            this.txtBinaryKey.Location = new System.Drawing.Point(315, 188);
            this.txtBinaryKey.Multiline = true;
            this.txtBinaryKey.Name = "txtBinaryKey";
            this.txtBinaryKey.ReadOnly = true;
            this.txtBinaryKey.Size = new System.Drawing.Size(95, 105);
            this.txtBinaryKey.TabIndex = 6;
            this.txtBinaryKey.TextChanged += new System.EventHandler(this.txtBinaryKey_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Бинарный зашифрованный текст:";
            // 
            // txtCrypto
            // 
            this.txtCrypto.Location = new System.Drawing.Point(42, 313);
            this.txtCrypto.Multiline = true;
            this.txtCrypto.Name = "txtCrypto";
            this.txtCrypto.ReadOnly = true;
            this.txtCrypto.Size = new System.Drawing.Size(267, 105);
            this.txtCrypto.TabIndex = 8;
            this.txtCrypto.TextChanged += new System.EventHandler(this.txtCrypto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Бинарный расшифрованный текст:";
            // 
            // txtBinaryDec
            // 
            this.txtBinaryDec.Location = new System.Drawing.Point(315, 313);
            this.txtBinaryDec.Multiline = true;
            this.txtBinaryDec.Name = "txtBinaryDec";
            this.txtBinaryDec.ReadOnly = true;
            this.txtBinaryDec.Size = new System.Drawing.Size(267, 105);
            this.txtBinaryDec.TabIndex = 10;
            this.txtBinaryDec.TextChanged += new System.EventHandler(this.txtBinaryDec_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Расшифрованный текст:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(588, 313);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(267, 105);
            this.txtOutput.TabIndex = 12;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(42, 440);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(267, 29);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(315, 440);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(267, 29);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBox1.Location = new System.Drawing.Point(416, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Язык:";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(416, 93);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(121, 29);
            this.btnGenerateKey.TabIndex = 18;
            this.btnGenerateKey.Text = "Генерировать ключ";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 538);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBinaryDec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCrypto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBinaryKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBinaryInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBinaryInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBinaryKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCrypto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBinaryDec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGenerateKey;
    }
}

