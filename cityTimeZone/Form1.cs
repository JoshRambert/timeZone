using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cityTimeZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;        //TO hold the name of the city 

            if (citiesListBox.SelectedIndex != -1)
            {
                //get the selected item
                city = citiesListBox.SelectedItem.ToString();

                //Determine the time zone
                switch (city)
                {
                    case "Boston":
                        displayTimeZoneLabel.Text = "Eastern";
                        break;
                    case "Eugene":
                        displayTimeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        displayTimeZoneLabel.Text = "Mountain";
                        break;
                    case "Minneanapolis":
                        displayTimeZoneLabel.Text = "Central";
                        break;
                    case "Honolulu":
                        displayTimeZoneLabel.Text = "Hawaiin";
                        break;
                }
            }
            else {
                MessageBox.Show("No city was selected");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the form 
            this.Close();
        }
    }
}
