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

namespace SimpleTextEditor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadToEditor(openFileDialog.FileName);
            }
        }

        //pole
        private String currentFileName = null;
        private void LoadToEditor(string fileName)
        {
            try
            {
                String s = File.ReadAllText(fileName);
                rTextBox.Text = s;
                rTextBox.Enabled = true;
                mnuSave.Enabled = true;
                mnuSaveAs.Enabled = true;
                tsFileName.Text = fileName;
                currentFileName = fileName;
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SaveToFile(string fileName)
        {
            try
            {
                File.WriteAllText(fileName, rTextBox.Text);
                MessageBox.Show("Zapisano do pliku: " + fileName, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException exc)
            {
                MessageBox.Show(exc.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveToFile(currentFileName);
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                //zapisz jako
                SaveToFile(saveFileDialog.FileName);
                currentFileName = saveFileDialog.FileName;
                tsFileName.Text = saveFileDialog.FileName;
            }
        }
    }
}
