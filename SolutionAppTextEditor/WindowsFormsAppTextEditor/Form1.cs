using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added
using System.IO;

namespace WindowsFormsAppTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stb_new_Click(object sender, EventArgs e)
        {
            rtb_main.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Por favor, abra un archivo.";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                rtb_main.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    rtb_main.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "¿Dónde desea guardar su archivo?";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtOutput = new StreamWriter(saveFile.FileName);
                txtOutput.Write(rtb_main.Text);
                txtOutput.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtb_main.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtb_main.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtb_main.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtb_main.Undo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rtb_main.Redo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            rtb_main.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stb_new.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stb_open.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stb_save.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();  
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton2.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3.PerformClick();
        }

        private void rtb_main_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripButton2.Image.RotateFlip((RotateFlipType.Rotate180FlipY));
            redoToolStripMenuItem.Image.RotateFlip((RotateFlipType.Rotate180FlipY));
        }
    }
}
