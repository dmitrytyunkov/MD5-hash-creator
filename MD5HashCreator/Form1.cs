using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MD5HashCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            FileDialog fDialog = openFileDialog;
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            fDialog.FileOk += fDialog_FileOk;
            fDialog.ShowDialog();
        }

        private void fDialog_FileOk(object sender, EventArgs e)
        {
            FileDialog fileDialog = sender as FileDialog;
            textBoxFilePath.Text = fileDialog.FileName;
        }

        private void buttonComputeHash_Click(object sender, EventArgs e)
        {
            FileStream streem = null;
            int flag = 0;
            try
            {
                streem = new FileStream(textBoxFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Не удается открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Не удается открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 1;
            }
            if (flag == 0)
            {
                textBoxMD5Hash.Text = MD5Hash.Compute(streem);
            }
        }

        private void textBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            textBoxMD5Hash.Text = "";
        }
    }
}
