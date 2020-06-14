using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMapsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street=streetTB.Text, city=cityTB.Text, state=stateTB.Text, country = countryTB.Text, zip = zipTB.Text;
            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("https://www.google.com/maps?q=");
                if (street != string.Empty)
                    query.Append(street + "," + "+");
                if (city != string.Empty)
                    query.Append(city + "," + "+");
                if (state != string.Empty)
                    query.Append(state + "," + "+");
                if (country != string.Empty)
                    query.Append(country + "," + "+");
                if(zip != string.Empty )
                    query.Append(zip + "," + "+");
                webBrowser1.Navigate(query.ToString());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
