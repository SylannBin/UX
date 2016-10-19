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

        private void bt_sim_stopStart_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            bt_sim_stopStart.Hide();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            progressBar1.Hide();
            bt_sim_stopStart.Show();
        }

        // Partie commune aux 6 pages


        private void button_main_Sim_Click(object sender, EventArgs e)
        {
            // Retourne à la page d'accueil
            this.Hide();
            Home scr_Hom = new Home();
            scr_Hom.Show();
        }

        private void button_currentMenu_Sim_Click(object sender, EventArgs e)
        {
            // N'est pas un vrai boutton, doit simplement afficher la page en cours
        }

        private void button_showMenu_Sim_Click(object sender, EventArgs e)
        {
            // Affiche l'écran de lecture en cours
            this.Hide();
            Lecture scr_Lec = new Lecture();
            scr_Lec.Show();
        }

        private void bt_sim_addToFav_Click(object sender, EventArgs e)
        {
            // Ajoute à la playlist "favoris"
            label_addToFav.Show();
            bt_sim_addToFav.BackColor = System.Drawing.Color.Salmon;
        }

        private void label_addToFav_Click(object sender, EventArgs e)
        {
            // Faire disparaitre le message d'ajout aux favoris
            label_addToFav.Hide();

        }

        private void bt_sim_addPlaylist_Click(object sender, EventArgs e)
        {
            // Créer une playlist et ajouter la musique à cette playlist
            label_addPlaylist.Show();
        }

        private void label_addPlaylist_Click(object sender, EventArgs e)
        {
            // Cacher le message de création de playlist
            label_addPlaylist.Hide();
        }

        private void bt_sim_openPlaylist_Click(object sender, EventArgs e)
        {
            // Faire apparaître la liste des playlist
            bt_sim_openPlaylist.Enabled = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
