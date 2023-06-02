using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B9
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Uputstvo.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        private void AddCellWithStringToRow(TableRow row, string str)
        {
            TableCell c1 = new TableCell();
            c1.Text = str;
            row.Cells.Add(c1);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Server.MapPath("katalog.txt"));
            Katalog cd = new Katalog();

            Table1.Rows.Clear();
            bool found;

            TableRow tr = new TableRow();
    
            AddCellWithStringToRow(tr, "Izvođač");
            AddCellWithStringToRow(tr, "Naziv albuma");
            AddCellWithStringToRow(tr, "Žanr");
            AddCellWithStringToRow(tr, "Godina izdavanja");
            AddCellWithStringToRow(tr, "Izdavačka kuća");
            AddCellWithStringToRow(tr, "Slika omota");

            Table1.Rows.Add(tr);

            while (!sr.EndOfStream)
            {
                found = false;

                cd.Load(sr.ReadLine());
                
                if(TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text == "" && DropDownList1.Text == "Izaberi..." && DropDownList2.Text == "Izaberi...")
                {
                    found = true;
                }
                else
                {
                    if (TextBox1.Text != "")
                    {
                        if(cd.Izvodjac.IndexOf(TextBox1.Text) >= 0)
                        {
                            found = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
    
                    if (TextBox2.Text != "")
                    {
                        if (cd.Naziv_albuma.IndexOf(TextBox2.Text) >= 0)
                        {
                            found = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
    
                    if (TextBox3.Text != "")
                    {
                        if (cd.Izdavacka_kuca.IndexOf(TextBox3.Text) >= 0)
                        {
                            found = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
    
                    if (DropDownList1.Text != "Izaberi...")
                    {
                        if (DropDownList1.Text == cd.Zanr)
                        {
                            found = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
    
                    if (DropDownList2.Text != "Izaberi...")
                    {
                        if (DropDownList2.Text == cd.Godina_izdanja)
                        {
                            found = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if(found)
                {
                    CreateRow(cd);
                }
            }
        }

        private void CreateRow(Katalog cd)
        {
            TableRow tr = new TableRow();

            TableCell izvodjac = new TableCell();
            izvodjac.Text = cd.Izvodjac;
            tr.Cells.Add(izvodjac);

            TableCell naziv_albuma = new TableCell();
            naziv_albuma.Text = cd.Naziv_albuma;
            tr.Cells.Add(naziv_albuma);

            TableCell zanr = new TableCell();
            zanr.Text = cd.Zanr;
            tr.Cells.Add(zanr);

            TableCell godina_izdanja = new TableCell();
            godina_izdanja.Text = cd.Godina_izdanja;
            tr.Cells.Add(godina_izdanja);

            TableCell izdavacka_kuca = new TableCell();
            izdavacka_kuca.Text = cd.Izdavacka_kuca;
            tr.Cells.Add(izdavacka_kuca);

            TableCell slika_omota = new TableCell();
            slika_omota.Text = "<img src=\"" + cd.Slika_omota + "\" width=200 height=150 />";
            tr.Cells.Add(slika_omota);

            Table1.Rows.Add(tr);
        }
    }
}