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
    public partial class LecturePanel : Form
    {
        public LecturePanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecture lecture = new Lecture();
            lecture.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Lecture lecture = new Lecture();
            lecture.Show();
        }
    }
}
