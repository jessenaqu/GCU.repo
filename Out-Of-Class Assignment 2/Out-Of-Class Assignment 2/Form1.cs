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
                btnAnime1.Text = "Your Lie in April";
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

        }

        private void btnDisplayAnime_Click(object sender, EventArgs e)
        {
            //===========================================
            //             Select an Anime
            //===========================================
            if ((listBoxGenre.SelectedIndex == 0) & (btnAnime1.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Tokyo Ghoul";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "12 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 0) & (btnAnime2.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Soul Eater";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "51 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 1) & (btnAnime1.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Your Lie in April";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "22 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 1) & (btnAnime2.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Kakegurui";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "24 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 2) & (btnAnime1.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Another";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "12 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 2) & (btnAnime2.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Higurashi";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "55 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 3) & (btnAnime1.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Toradora";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "25 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 3) & (btnAnime2.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Love is War";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "12 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 4) & (btnAnime1.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "K-On!";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "13 Episodes";
                }
            }
            if ((listBoxGenre.SelectedIndex == 4) & (btnAnime2.Checked))
            {
                if (ckBoxName.Checked)
                {
                    lblAnimeName.Text = "Nichijou";
                }
                if (ckBoxEpisodes.Checked)
                {
                    lblEpisodes.Text = "26 Episodes";
                }
            }
        }
    }
}
