using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassAssignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculating Days, Hours and Minutes from seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnFindOut_Click(object sender, EventArgs e)
        {
            int inputSeconds = Convert.ToInt32 (txtSecondsElapsed.Text);
            int answerMinutes = 0;

            //==========================================
            //          Convert to minutes
            //==========================================
            if ((inputSeconds >= 60) & (inputSeconds <= 3600))
            {
                answerMinutes = inputSeconds / 60;
                lblNumberOfDays.Text = "The number of minutes = " + answerMinutes; 
            }

            //==========================================
            //          Convert to hours
            //==========================================
            else if ((inputSeconds >= 3600) & (inputSeconds <86400))
            {
                answerMinutes = inputSeconds / 3600;
                //var timeSpan = TimeSpan.FromSeconds(inputSeconds);
                //lblNumberOfDays.Text = lblNumberOfDays.Text + "\n\r" = timeSpan.ToString("hh");
            }

            else if (inputSeconds >= 86400) 
            {
                //var timeSpan = TimeSpan.FromSeconds(inputSeconds);
                //lblNumberOfDays.Text = lblNumberOfDays.Text + "\n\r" = timeSpan.ToString("dd");
            }
        }

        /// <summary>
        /// A bunch of shapes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedListItem = listShape.Text; 

        }
    }
}
