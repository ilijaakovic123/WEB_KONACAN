using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11.Account
{
    public partial class Zahtevi_ADMIN : System.Web.UI.Page
    {
        public string datum;
        public string naziv;
        public string p_adr;
        public string k_adr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                reload();
            }




        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(DropDownList1.SelectedValue) != null)
            {
                GridViewRow row = GridView1.Rows[int.Parse(DropDownList1.SelectedValue)];
                naziv = row.Cells[0].Text; Debug.WriteLine(naziv);
                datum = row.Cells[1].Text; Debug.WriteLine(datum);
                p_adr = row.Cells[2].Text; Debug.WriteLine(p_adr);
                k_adr = row.Cells[3].Text; Debug.WriteLine(k_adr);
                string datum_Odbijanja = System.DateTime.Now.ToString(); Debug.WriteLine(datum_Odbijanja);

                string cs = "Data Source=DESKTOP-6V270U1\\ILIJA;Initial Catalog=ilija;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                try
                {
                    con.Open();
                    string upit = "insert into Odbijeni_zahtevi values('" + naziv + "','" + datum + "','" + p_adr + "','" + k_adr + "','" + datum_Odbijanja + "')";
                    SqlCommand cmd = new SqlCommand(upit, con);
                    cmd.ExecuteNonQuery();
                    string upit1 = "delete from Zahtevi where Naziv_narucioca='" + naziv + "'";
                    SqlCommand cmd1 = new SqlCommand(upit1, con);
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex) { ErrorLabel.Text = ex.Message; }
                finally { con.Close(); ErrorLabel.Text = "Zahtev je uspesno odbijen"; reload(); }
            }
            else { ErrorLabel.Text = "izaberi zahtev"; reload(); izbrisi(); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(DropDownList1.SelectedValue) != null)
            {
                GridViewRow row = GridView1.Rows[int.Parse(DropDownList1.SelectedValue)];
                naziv = row.Cells[0].Text; Debug.WriteLine(naziv);
                datum = row.Cells[1].Text; Debug.WriteLine(datum);
                p_adr = row.Cells[2].Text; Debug.WriteLine(p_adr);
                k_adr = row.Cells[3].Text; Debug.WriteLine(k_adr);
                string datum_Odbijanja = System.DateTime.Now.ToString(); Debug.WriteLine(datum_Odbijanja);

                string cs = "Data Source=DESKTOP-6V270U1\\ILIJA;Initial Catalog=ilija;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                try
                {
                    con.Open();
                    string upit = "insert into Odobrenmi_zahtevi values('" + naziv + "','" + datum + "','" + p_adr + "','" + k_adr + "','" + datum_Odbijanja + "')";
                    SqlCommand cmd = new SqlCommand(upit, con);
                    cmd.ExecuteNonQuery();
                    string upit1 = "delete from Zahtevi where Naziv_narucioca='" + naziv + "'";
                    SqlCommand cmd1 = new SqlCommand(upit1, con);
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex) { ErrorLabel.Text = ex.Message; }
                finally 
                {
                    con.Close(); ErrorLabel.Text = "Zahtev je uspesno prihvacen"; reload();

                }
            }
            else { ErrorLabel.Text = "izaberi zahtev"; reload(); izbrisi(); }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button1.Visible = true; Button2.Visible = true;
        }
        protected void reload()
        {
            Button1.Visible = false;
            Button2.Visible = false;
            string cs = "Data Source=DESKTOP-6V270U1\\ILIJA;Initial Catalog=ilija;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                string upit = "select * from Zahtevi";
                SqlDataAdapter da = new SqlDataAdapter(upit, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();

                int br = GridView1.Rows.Count;
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("");
                for (int i = 0; i < br; i++)
                {
                    DropDownList1.Items.Add((i).ToString());
                }
            }
            catch (Exception ex) { ErrorLabel.Text = ex.Message; ErrorLabel.ForeColor = System.Drawing.Color.Red; }

        }
        protected void izbrisi()
        {
            int br = GridView1.Rows.Count;
            DropDownList1.Items.Clear();
            for (int i = 0; i < br; i++)
            {
                DropDownList1.Items.Add((i).ToString());
            }
        }
    }
}