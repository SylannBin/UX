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
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
        }

        private void Playlist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaylistPanel playlist_panel = new PlaylistPanel();
            playlist_panel.Show();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Lecture lecture = new Lecture();
            lecture.Show();
        }
    }
}
