using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11.Account
{
    public partial class Naruci_voznju : System.Web.UI.Page
    {
        public string datum;
        public string naziv;
        public string p_adr;
        public string k_adr;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            datum = Calendar1.SelectedDate.ToString(); Debug.WriteLine(datum);
            naziv = TextBox0.Text; Debug.WriteLine(naziv);
            p_adr = TextBox1.Text; Debug.WriteLine(p_adr);
            k_adr = TextBox2.Text; Debug.WriteLine(k_adr);
            if (datum == null || datum == "" | TextBox0.Text == null || TextBox0.Text == "" || TextBox1.Text == null || TextBox1.Text == "" || TextBox2.Text == null || TextBox2.Text == "")
            {

                ErrorLabel1.Text = "niste uneli podatke u neko od polja!!!";
                ErrorLabel1.ForeColor = System.Drawing.Color.Red;


            }
            else
            {
                string cs = "Data Source=DESKTOP-6V270U1\\ILIJA;Initial Catalog=ilija;Integrated Security=True";

                SqlConnection con = new SqlConnection(cs);
                try
                {
                    con.Open();
                    string upit = "insert into Zahtevi values('" + naziv + "','" + datum + "','" + p_adr + "','" + k_adr + "')";
                    SqlCommand cmd = new SqlCommand(upit, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { ErrorLabel1.Text = ex.Message; }
                finally
                {
                    con.Close();
                    ErrorLabel1.Text = "Uspesno ste poslali zahtev.😁";
                    ErrorLabel1.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}