using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Out_Of_Class_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //===========================================
            //            Choose a Genre
            //===========================================
            if (listBoxGenre.SelectedIndex == 0)
            {
                btnAnime1.Text = "Tokyo Ghoul"; 
                btnAnime2.Text = "Soul Eater";
            }
            
            else if (listBoxGenre.SelectedIndex == 1)
            {
                btnAnime1.Text = "Your lie in April";
                btnAnime2.Text = "Kakegurui";
            }
            
            else if (listBoxGenre.SelectedIndex == 2)
            {
                btnAnime1.Text = "Another";
                btnAnime2.Text = "Higurashi";
            }

            else if (listBoxGenre.SelectedIndex == 3)
            {
                btnAnime1.Text = "Toradora!";
                btnAnime2.Text = "Love is War";
            }

            else
            {
                btnAnime1.Text = "K-On!";
                btnAnime2.Text = "Nichijou";
            }

            //===========================================
            //             Select an Anime
            //===========================================
            if ((listBoxGenre.SelectedIndex == 0) & (btnAnime1.Checked))
            {

            }
        }

        private void btnDisplayAnime_Click(object sender, EventArgs e)
        {

        }
    }
}
