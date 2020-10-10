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
            //  Display picture, anime name & episodes 
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
                picBoxTokyoGhoul.Visible = true; 
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
                picBoxSoulEater.Visible = true;
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
                picBoxYLiA.Visible = true;
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
                picBoxKakegurui.Visible = true;
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
                picBoxAnother.Visible = true;
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
                picBoxWhenTheyCry.Visible = true; 
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
                picBoxToradora.Visible = true;
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
                picBoxLoveisWar.Visible = true;
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
                picBoxKOn.Visible = true; 
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
                picBoxNichijou.Visible = true; 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //===========================================
            //          Clear the selection
            //===========================================
            lblAnimeName.Text = "";
            lblEpisodes.Text = "";
            picBoxTokyoGhoul.Visible = false;
            picBoxSoulEater.Visible = false;
            picBoxYLiA.Visible = false;
            picBoxKakegurui.Visible = false;
            picBoxAnother.Visible = false;
            picBoxWhenTheyCry.Visible = false;
            picBoxToradora.Visible = false;
            picBoxLoveisWar.Visible = false;
            picBoxKOn.Visible = false;
            picBoxNichijou.Visible = false; 
        }

        private void ckBoxName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
