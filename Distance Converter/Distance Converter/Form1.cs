using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDistanceEntered_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //===========================================
            //             Close the form
            //===========================================
            this.Close();
        }

        /// <summary>
        /// Calculating distance from the following; inches, feet & yards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                int inputMeasurement = Convert.ToInt32(txtDistanceEntered.Text);
                lblError.Text = "";
                //===========================================
                //            Inches Converter
                //===========================================
                if (listBoxFrom.SelectedIndex == 0)
                {
                    if (listBoxTo.SelectedIndex == 0)
                    {
                        txtDistanceConverted.Text = inputMeasurement.ToString();
                    }
                    if (listBoxTo.SelectedIndex == 1)
                    {
                        txtDistanceConverted.Text = (inputMeasurement / 12).ToString();
                    }
                    if (listBoxTo.SelectedIndex == 2)
                    {
                        txtDistanceConverted.Text = (inputMeasurement / 36).ToString();
                    }
                }

                //===========================================
                //             Feet Convertor
                //===========================================
                else if (listBoxFrom.SelectedIndex == 1)
                {
                    if (listBoxTo.SelectedIndex == 0)
                    {
                        txtDistanceConverted.Text = (inputMeasurement * 12).ToString();
                    }
                    if (listBoxTo.SelectedIndex == 1)
                    {
                        txtDistanceConverted.Text = inputMeasurement.ToString();
                    }
                    if (listBoxTo.SelectedIndex == 2)
                    {
                        txtDistanceConverted.Text = (inputMeasurement / 3).ToString();
                    }
                }

                //===========================================
                //             Yard Convertor
                //===========================================
                else if (listBoxFrom.SelectedIndex == 2)
                {
                    if (listBoxTo.SelectedIndex == 0)
                    {
                        txtDistanceConverted.Text = (inputMeasurement * 36).ToString();
                    }
                    if (listBoxTo.SelectedIndex == 1)
                    {
                        txtDistanceConverted.Text = (inputMeasurement * 3).ToString();
                    }
                    if (listBoxTo.SelectedIndex == 2)
                    {
                        txtDistanceConverted.Text = inputMeasurement.ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                lblError.Text = "Error occured: Use valid number";
            }

            finally
            {
                
            }

        }
    }
}
