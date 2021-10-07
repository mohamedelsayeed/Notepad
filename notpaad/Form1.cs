using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notpaad
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveD.ShowDialog() == DialogResult.OK)
            {
                txtRich.SaveFile(saveD.FileName);
                txtRich.Clear();
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtRich.LoadFile(openFile.FileName);
                path = openFile.FileName;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                txtRich.SaveFile(path);
                txtRich.Clear();
                path = null;
            }
            else
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtRich.LoadFile(openFile.FileName);
                    path = openFile.FileName;
                }

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRich.Clear();
            path = null;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (txtRich.SelectedText != "")
                {
                    txtRich.SelectionFont = fontDialog.Font;
                }
                else
                {
                    txtRich.Font = fontDialog.Font;
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (txtRich.SelectedText != "")
                {
                    txtRich.SelectionColor = colorDialog.Color;
                }
                else
                {
                    txtRich.ForeColor = colorDialog.Color;
                }
            }
        }
    }
}
    
