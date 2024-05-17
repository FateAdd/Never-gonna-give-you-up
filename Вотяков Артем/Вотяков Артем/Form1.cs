using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вотяков_Артем
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://cdn.mtdv.me/video/rick.mp4");
        }


        private void мемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://tenor.com/ru/view/tarkov-usev-usec-eft-shroud-gif-20273951");
        }

        private void какРаботаетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("БЕРЕШЬ И РАБОТАЕШЬ!", "ТРЕВОГА ЛЕНТЯЙ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void неОткрыватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://media1.tenor.com/m/m34YGdjj-jkAAAAC/discord-mod-discord.gif");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Process.Start("https://media1.tenor.com/m/m34YGdjj-jkAAAAC/discord-mod-discord.gif");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void неХочуРаботатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://media.tenor.com/WD7wdtZ74CAAAAAd/hoshimachi-suisei-suisei.gif");
        }

        private void badAppleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://i.pinimg.com/originals/11/3c/37/113c37e46e35619ae54f555f1d7cc92e.gif");
        }

        private void фаилToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void растянутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
            this.Hide();
        }
    }
}
