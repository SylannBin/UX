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
    public partial class Folding : Form
    {
        public Folding()
        {
            InitializeComponent();
        }

        private void Folding_Load(object sender, EventArgs e)
        {
            label17.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel12.Hide();
            label17.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecture lecture = new UX.Lecture();
            lecture.Show();
        }
        
        // Partie commune aux 6 pages


        private void button_main_Click(object sender, EventArgs e)
        {
            // Retourne à la page d'accueil
            this.Hide();
            Home scr_Hom = new Home();
            scr_Hom.Show();
        }

        private void button_currentMenu_Click(object sender, EventArgs e)
        {
            // N'est pas un vrai boutton, doit simplement afficher la page en cours
        }

        private void button_showMenu_Click(object sender, EventArgs e)
        {
            // Affiche le menu
            button_showMenu.Hide();
            button_hideMenu.Show();
            button_openLecture.Show();
            button_openFolding.Show();
            button_openPlaylist.Show();
            button_openOptions.Show();
            button_openSimplified.Show();
        }

        private void button_hideMenu_Click(object sender, EventArgs e)
        {
            // Cache le menu
            button_showMenu.Show();
            button_hideMenu.Hide();
            button_openLecture.Hide();
            button_openFolding.Hide();
            button_openPlaylist.Hide();
            button_openOptions.Hide();
            button_openSimplified.Hide();
        }

        private void button_openLecture_Click(object sender, EventArgs e)
        {
            // Affiche l'écran de lecture en cours
            this.Hide();
            Lecture scr_Lec = new Lecture();
            scr_Lec.Show();
        }
        private void button_openFolding_Click(object sender, EventArgs e)
        {
            // Affiche l'écran de parcourt des fichiers
            this.Hide();
            Folding scr_Fol = new Folding();
            scr_Fol.Show();
        }

        private void button_openPlaylist_Click(object sender, EventArgs e)
        {
            // Affiche l'écran de liste et de génération des playlist
            this.Hide();
            Playlist scr_Pla = new Playlist();
            scr_Pla.Show();
        }

        private void button_openOptions_Click(object sender, EventArgs e)
        {
            // Affiche l'écran des paramètres
            this.Hide();
            Options scr_Pref = new Options();
            scr_Pref.Show();
        }

        private void button_openSimplified_Click(object sender, EventArgs e)
        {
            // Bascule l'application en mode simplifié
            this.Hide();
            Simplified scr_Sim = new Simplified();
            scr_Sim.Show();
        }
    }
}
