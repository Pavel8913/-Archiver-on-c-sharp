using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace Архиватор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FolderBrowserDialog dialog = new FolderBrowserDialog();
        FolderBrowserDialog dialog2 = new FolderBrowserDialog();

        private void button1_Click(object sender, EventArgs e)
        {
           if(dialog.ShowDialog()==DialogResult.OK)
            {
                label1.Text = dialog.SelectedPath;

            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Zip files (*.zip)|*.zip";            
            if (label1.Text!=""&&saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                ZipFile file = new ZipFile(saveFileDialog.FileName, Encoding.UTF8);
                file.AddDirectory(dialog.SelectedPath);
                file.Save();
                MessageBox.Show("Архивация выполнена!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dialog2.ShowDialog() == DialogResult.OK)
            {                
                label1.Text = dialog2.SelectedPath;

            }
        }
        string filename2;
        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "";
            //if (label1.Text != "" && saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    ZipFile file = new ZipFile(saveFileDialog.FileName, Encoding.UTF8);
            //    file.AddDirectory(dialog.SelectedPath);
            //    file.Save();
            //    MessageBox.Show("Архивация выполнена!");
            //}
            //using (ZipFile zip = ZipFile.Read(filename2))
            //{
            //    foreach (ZipEntry x in zip)
            //    {
            //        x.Extract(filename2, ExtractExistingFileAction.OverwriteSilently); // перезаписывать существующие
            //    }
            //}
           

        }
    }
}
