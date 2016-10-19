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
    public partial class PlaylistPanel : Form
    {
        public PlaylistPanel()
        {
            InitializeComponent();
        }

        private void PlaylistPanel_Load(object sender, EventArgs e)
        {
            label11.Hide();
            button2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playlist playlist = new Playlist();
            playlist.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Show();
        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Hide();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playlist playlist = new Playlist();
            playlist.Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Lime;
        }
    }
}
