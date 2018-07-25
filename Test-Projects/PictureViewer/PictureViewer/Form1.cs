using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Schließe die Form
            this.Close();
        }

        private void backgroundcolorButton_Click(object sender, EventArgs e)
        {
            // Wenn eine Farbe im ColorDialog ausgewählt wurde, (OK gedrückt wird), fülle den Bildhintergrund mit der ausgewählten Farbe
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Inhalt der Picturebox auf Null setzen, dh. leeren
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Wenn Dialogfenster geöffnet wurde und Datei ausgewählt, Lade diese Datei in die Picturebox
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Wenn die Checkbox1 abgehackt ist, stretche das Bild in Picturebox1
            // Wenn der Hacken rausgenommen wird, wird das Bild normal angezeigt.
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
