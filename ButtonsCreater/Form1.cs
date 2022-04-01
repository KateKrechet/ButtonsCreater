using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonsCreater
{
    public partial class Form1 : Form
    {
        Button[] buttons;
        PictureBox[] pictures;
        public Form1()
        {
            InitializeComponent();
        }
        void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // btn.BackColor = Color.Red;
            MessageBox.Show("Я кнопка" + btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            if (buttons != null)//очистка ранее отрисованных кнопок
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    panel1.Controls.Remove(buttons[i]);
                }
            }
            buttons = new Button[n];
            for (int i = 0; i < n; i++)
            {
                buttons[i] = new Button();
                buttons[i].Width = 50;
                buttons[i].Height = 50;
                buttons[i].Text = i.ToString();
                buttons[i].Top = 50;//отступ сверху
                buttons[i].Click += button_Click;//что происходит, если нажимае на кнопку,прописали двойное нажатиеbuttons[i].Left = 52 * i + 5;//отступ от левого края
                buttons[i].Left = 52 * i + 5;//отступ от левого края
                buttons[i].BackColor = Color.LightGray;
                panel1.Controls.Add(buttons[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            if (pictures != null)//очистка ранее отрисованных кнопок
            {
                for (int i = 0; i < pictures.Length; i++)
                {
                    panel1.Controls.Remove(pictures[i]);
                }
            }
            pictures = new PictureBox[n];
            for (int i = 0; i < n; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].Width = 80;
                pictures[i].Height = 100;
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                string path = "d:\\cards\\image_part_03" + i + ".jpg";
                pictures[i].Image = Image.FromFile(path);
                pictures[i].Top = 100;
                pictures[i].Left = 82 * i + 10;
                panel1.Controls.Add(pictures[i]);
            }
        }
    }
}
