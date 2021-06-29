using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncodeFile_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnRestoreFile_Click(object sender, EventArgs e)
        {

           

        }
        public static string GetFolderPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = @"C:\";

            using (dialog)
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                    return dialog.SelectedPath + @"\";
                else
                    return "";
            }
        }
        public static Tuple<string, string> GetFilePath()
        {
            try
            {
                var filePath = string.Empty;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "All files (*.*)|*.*";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        if (filePath.Length == 0 || openFileDialog.SafeFileName.Length == 0)
                            return new Tuple<string, string>("", "");

                        return new Tuple<string, string>(filePath, openFileDialog.SafeFileName);
                    }
                }

                return new Tuple<string, string>("", "");
            }
            catch (Exception)
            {
                return new Tuple<string, string>("", "");
            }


        }

        public static string GetBase64FromFilePath(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var fileBase64 = Convert.ToBase64String(bytes);

            return fileBase64;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = GetFilePath().Item1;
            TxtPath.Text = path;
            var base64File = GetBase64FromFilePath(path);
            TxtEncodedFile.Text = base64File;

            MessageBox.Show("Done.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtEncodedFile.Text))
            {
                MessageBox.Show("TxtEncodedFile is requiered.");
                return;
            }
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Name is requiered.");
                return;
            }
            var path = GetFolderPath();
            TxtPath.Text = path;

            var fullFileName = $"{path}{TxtName.Text.Trim()}";
            //var base64File = GetBase64FromFilePath(path);
            File.WriteAllBytes(fullFileName, Convert.FromBase64String(TxtEncodedFile.Text));

            MessageBox.Show("Done.");
        }
    }
}
