namespace MD5HashCreater
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonComputeHash = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxMD5Hash = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(190, 12);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(90, 23);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Выбрать файл";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonComputeHash
            // 
            this.buttonComputeHash.Location = new System.Drawing.Point(85, 41);
            this.buttonComputeHash.Name = "buttonComputeHash";
            this.buttonComputeHash.Size = new System.Drawing.Size(125, 23);
            this.buttonComputeHash.TabIndex = 1;
            this.buttonComputeHash.Text = "Вычислить md5 hash";
            this.buttonComputeHash.UseVisualStyleBackColor = true;
            this.buttonComputeHash.Click += new System.EventHandler(this.buttonComputeHash_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(13, 13);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(171, 20);
            this.textBoxFilePath.TabIndex = 2;
            this.textBoxFilePath.TextChanged += new System.EventHandler(this.textBoxFilePath_TextChanged);
            // 
            // textBoxMD5Hash
            // 
            this.textBoxMD5Hash.Location = new System.Drawing.Point(12, 70);
            this.textBoxMD5Hash.Name = "textBoxMD5Hash";
            this.textBoxMD5Hash.ReadOnly = true;
            this.textBoxMD5Hash.Size = new System.Drawing.Size(267, 20);
            this.textBoxMD5Hash.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 102);
            this.Controls.Add(this.textBoxMD5Hash);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonComputeHash);
            this.Controls.Add(this.buttonSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD5 Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonComputeHash;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxMD5Hash;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}

