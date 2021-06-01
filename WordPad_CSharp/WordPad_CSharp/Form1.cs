using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WordPad_CSharp
{
    public partial class WordPad : Form
    {
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName(); // random 11 char 
            path = path.Replace(".", ""); // Remove period.
            return path;
        }
        public WordPad()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("D:\\C_Sharp_Winform\\EXERCISE\\" + "Demo" + ".txt");
            txt.Write(richTextBox1.Text);
            txt.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Please choose file";
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string file = openFileDialog.FileName;
                StreamReader sr = new StreamReader(file);
                string str = sr.ReadToEnd();
                richTextBox1.Text = str;
                sr.Close();
            }
        }

        private void WordPad_Load(object sender, EventArgs e)
        {
            //string s = "New Word Pad";
            //WordPad.ActiveForm.;

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(richTextBox1.Text);
                txt.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure?", "You are not save", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectAll();
            //richTextBox1.Text.PadLeft(richTextBox1.Text.Length + 5);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void aliceBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.AliceBlue;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Aqua;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void blueVioletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.BlueViolet;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void biggerFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, 2);
           
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void aquaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Aqua;
            
        }

        private void aliceBlueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.AliceBlue;
        }
        
    }
}
