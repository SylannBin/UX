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
    public partial class Simplified : Form
    {
        public Simplified()
        {
            InitializeComponent();
        }

        private void Simplified_Load(object sender, EventArgs e)
        {

        }

        private void button_tapScreen_Click(object sender, EventArgs e)
        {
            button_tapScreen.Hide();
            progressBar1.Hide();
            button_stopStart.Show();
            button_stopPrevious.Show();
            button_stopNext.Show();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecture lecture = new Lecture();
            lecture.Show();
        }
    }
}
