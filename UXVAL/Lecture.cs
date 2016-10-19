using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UX
{
    public partial class Lecture : Form
    {
        public Lecture()
        {
            InitializeComponent();
        }

        private void Lecture_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            label11.Hide();
            button8.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturePanel lecture_panel = new LecturePanel();
            lecture_panel.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Hide();
            button1.Show();
        }
    }
}
