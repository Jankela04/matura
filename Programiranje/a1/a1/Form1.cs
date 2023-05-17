using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace a1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataTable citaoci = new DataTable();

        DataTable cb = new DataTable();

        DataTable dgw = new DataTable();


        DataTable citalac = new DataTable();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox4.Text != "")
                {
                    command.CommandText = "INSERT INTO citalac VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    if (!con.Ping())
                    {
                        con.Open();

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Uspeh. Sifra novog Citaoca je " + textBox1.Text);
                            command.CommandText = "SELECT * FROM citalac";
                            citaoci.Clear();
                            adapter.Fill(citaoci);

                            listView1.Items.Clear();




                            for (int i = 0; i < citaoci.Rows.Count; i++)
                            {
                                ListViewItem lvi = new ListViewItem(citaoci.Rows[i][0].ToString());
                                for (int j = 1; j < citaoci.Columns.Count; j++)
                                {
                                    lvi.SubItems.Add(citaoci.Rows[i][j].ToString());
                                }
                                listView1.Items.Add(lvi);
                            }

                        }

                        con.Close();
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Greska \n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 192.168.10.21
                // 46.40.3.35
                con.ConnectionString = "Server=46.40.3.35; UserName=22jovanovic; Password=123; DataBase=22jovanovic_pita1";
                command.Connection = con;
                adapter.SelectCommand = command;

                con.Open();

                command.CommandText = "SELECT * FROM citalac";
                adapter.Fill(citaoci);






                for (int i = 0; i < citaoci.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(citaoci.Rows[i][0].ToString());
                    for (int j = 1; j < citaoci.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(citaoci.Rows[i][j].ToString());
                    }
                    listView1.Items.Add(lvi);
                }

                command.CommandText = "SELECT CONCAT(citalacID,'-',Ime,' ',Prezime) as fullime, citalacID from citalac";
                adapter.Fill(cb);

                comboBox1.DataSource = cb;
                comboBox1.DisplayMember = "fullime";
                comboBox1.ValueMember = "citalacID";

                dataGridView1.DataSource = dgw;

                numericUpDown2.Value = DateTime.Now.Year;
                numericUpDown1.Value = DateTime.Now.Year - 10;
                

                con.Close();

            }
            catch {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    if (!con.Ping())
                        con.Open();
                    command.CommandText = "SELECT * FROM citalac WHERE citalacID = " + textBox1.Text;

                    citalac.Clear();
                    adapter.Fill(citalac);

                    if (citalac.Rows.Count > 0)
                    {
                        textBox2.Text = citalac.Rows[0][1].ToString();
                        textBox3.Text = citalac.Rows[0][2].ToString();
                        textBox4.Text = citalac.Rows[0][3].ToString();
                        textBox5.Text = citalac.Rows[0][4].ToString();

                        button1.Enabled = false;
                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";

                        button1.Enabled = true;
                    }



                    con.Close();
                }
            }
            catch {
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                con.Open();
                
                command.CommandText = "SELECT CONCAT(Ime, ' ', prezime) AS Citalac" + ",YEAR(DatumUzimanja) AS " + "godina" +
                ",COUNT(knjigaID) AS " + "'broj iznajmljivanja'" + ",(SELECT COUNT(knjigaID)" + " FROM na_citanju WHERE " +
                "DatumVracanja IS NULL AND na_citanju.CitalacID = "+ comboBox1.SelectedValue +" AND YEAR(DatumUzimanja) = godina" + ") AS " + "'nije vracen'" +
                " FROM citalac, na_citanju WHERE " + "citalac.CitalacId = na_citanju.CitalacID AND na_citanju.CitalacID =  " + comboBox1.SelectedValue + " AND YEAR(DatumUzimanja) BETWEEN "+numericUpDown1.Value  +" and " + numericUpDown2.Value +
                " GROUP BY godina ORDER By Godina;";

                dgw.Clear();
                adapter.Fill(dgw);

                chart1.DataSource = dgw;


                chart1.Series[0].XValueMember = "godina";
                chart1.Series[0].YValueMembers = "broj iznajmljivanja";

                chart1.Series[1].XValueMember = "godina";
                chart1.Series[1].YValueMembers = "nije vracen";

                chart1.DataBind();

                con.Close();

            }
            catch { MessageBox.Show("ERROR!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
