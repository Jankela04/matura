using System;
using System.Web.UI.WebControls;
using System.IO;


namespace Telefonski_Imenik
{
    public partial class TelImenik : System.Web.UI.Page
    {
        bool found;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void AddCellWithStringToRow(TableRow row, string str)
        {
            TableCell c1 = new TableCell();
            c1.Text = str;
            row.Cells.Add(c1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                StreamReader sr = new StreamReader(Server.MapPath("imenik.txt"));
                TelImenik im = new TelImenik();

                Table1.Rows.Clear();

                TableRow tr = new TableRow();

                AddCellWithStringToRow(tr, "ID");
                AddCellWithStringToRow(tr, "Ime");
                AddCellWithStringToRow(tr, "Prezime");
                AddCellWithStringToRow(tr, "Adresa");
                AddCellWithStringToRow(tr, "Mesto");
                AddCellWithStringToRow(tr, "Broj");
                AddCellWithStringToRow(tr, "Email");

                Table1.Rows.Add(tr);

                while (!sr.EndOfStream)
                {
                    found = false;

                    im.metoda(sr.ReadLine());

                    if (TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text == "" && TextBox4.Text == "" && TextBox5.Text == "" && DropDownList1.Text == "Izaberite...")
                    {
                        found = true;
                    }
                    else
                    {
                        if (TextBox1.Text != "")
                        {
                            if (im.Ime.IndexOf(TextBox1.Text) >= 0)
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
                            if (im.Prezime.IndexOf(TextBox2.Text) >= 0)
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
                            if (im.Adresa.IndexOf(TextBox3.Text) >= 0)
                            {
                                found = true;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (TextBox4.Text != "")
                        {
                            if (im.Broj.IndexOf(TextBox4.Text) >= 0)
                            {
                                found = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (TextBox5.Text != "")
                        {
                            if (im.Email.IndexOf(TextBox5.Text) >= 0)
                            {
                                found = true;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (DropDownList1.Text != "Izaberite...")
                        {
                            if (DropDownList1.Text == im.Mesto)
                            {
                                found = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                    if (found)
                    {
                        CreateRow(im);
                    }
                    
                }
            }
        }  
        
        private void CreateRow(TelImenik im)
        {
            TableRow tr = new TableRow();

            TableCell ID = new TableCell();
            ID.Text = im.ID;
            tr.Cells.Add(ID);

            TableCell Ime = new TableCell();
            Ime.Text = im.Ime;
            tr.Cells.Add(Ime);

            TableCell Prezime = new TableCell();
            Prezime.Text = im.Prezime;
            tr.Cells.Add(Prezime);

            TableCell Adresa = new TableCell();
            Adresa.Text = im.Adresa;
            tr.Cells.Add(Adresa);

            TableCell Mesto = new TableCell();
            Mesto.Text = im.Mesto;
            tr.Cells.Add(Mesto);

            TableCell Broj = new TableCell();
            Broj.Text = im.Broj;
            tr.Cells.Add(Broj);

            TableCell Email = new TableCell();
            Email.Text = im.Email;
            tr.Cells.Add(Email);

            Table1.Rows.Add(tr);
        }
    }
}