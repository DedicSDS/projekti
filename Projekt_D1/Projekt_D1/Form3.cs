using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt_D1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Uporabnik\Desktop\c#\Projekt_D1\Projekt_D1\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection dataConnection;
        DataSet dsOddelki;
        SqlDataAdapter daOddelki;

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                dataConnection = new SqlConnection(connectionString);
                SqlCommand poizvedba = new SqlCommand();
                poizvedba.CommandText = "SELECT * FROM Oddelki";
                poizvedba.Connection = dataConnection;
                daOddelki = new SqlDataAdapter(poizvedba.CommandText, dataConnection);
                dsOddelki = new DataSet();

                daOddelki.Fill(dsOddelki, "Oddelki");
                toolStripComboBox1.ComboBox.DataSource = dsOddelki.Tables[0];
                toolStripComboBox1.ComboBox.DisplayMember = "Ime_oddelka";
                toolStripComboBox1.ComboBox.ValueMember = "ID_oddelek";
                poizvedba.Connection.Open();
                dataConnection.Close();
            }
            catch
            {
                MessageBox.Show("Neki ne dela...");
                Application.Exit();
            }
            
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter daPacienti;
                dataConnection = new SqlConnection(connectionString);
                SqlCommand poizvedba = new SqlCommand();
                poizvedba.CommandText = "SELECT p.ID_oseba, CONCAT(p.Ime,' ', p.Priimek) AS Oseba FROM Pacienti p INNER JOIN Glavna_tabela gt ON gt.ID_oseba = p.ID_oseba INNER JOIN Oddelki o ON o.ID_oddelek = gt.ID_oddelek WHERE gt.ID_oddelek = '" + toolStripComboBox1.ComboBox.SelectedValue.ToString() + "' AND gt.Cas_odjave IS NULL";
                poizvedba.Connection = dataConnection;
                daPacienti = new SqlDataAdapter(poizvedba.CommandText, dataConnection);
                dsOddelki = new DataSet();
                daPacienti.Fill(dsOddelki, "Oddelki");
                dataGridView1.DataSource = dsOddelki.Tables[0];
                poizvedba.Connection.Open();
                dataConnection.Close();
            }
            catch
            {
                MessageBox.Show("Neki ne dela...");
                Application.Exit();
            }

            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string pacient_string = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int ID_oseba = Int32.Parse(pacient_string);

            this.glavna_tabelaTableAdapter.FillBy(this.database1DataSet1.Glavna_tabela,ID_oseba);

            int ID_oddelek = Int32.Parse(database1DataSet1.Glavna_tabela.Rows[0]["ID_oddelek"].ToString());

            int ID_soba = Int32.Parse(database1DataSet1.Glavna_tabela.Rows[0]["ID_soba"].ToString());
            try
            {
                this.sobeTableAdapter.FillBy(this.database1DataSet1.Sobe, ID_soba);
                this.oddelkiTableAdapter.FillBy(this.database1DataSet1.Oddelki, ID_oddelek);
                this.pacientiTableAdapter.FillBy(this.database1DataSet1.Pacienti, ID_oseba);
            }
            catch
            {
                MessageBox.Show("Neki ne dela...");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 okno2 = new Form2();
            okno2.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter daPacienti;
                dataConnection = new SqlConnection(connectionString);
                SqlCommand poizvedba = new SqlCommand();
                poizvedba.CommandText = "SELECT p.ID_oseba, CONCAT(p.Ime,' ', p.Priimek) AS Oseba FROM Pacienti p INNER JOIN Glavna_tabela gt ON gt.ID_oseba = p.ID_oseba INNER JOIN Oddelki o ON o.ID_oddelek = gt.ID_oddelek WHERE gt.Cas_odjave IS NULL";
                poizvedba.Connection = dataConnection;
                daPacienti = new SqlDataAdapter(poizvedba.CommandText, dataConnection);
                dsOddelki = new DataSet();
                daPacienti.Fill(dsOddelki, "Oddelki");
                dataGridView1.DataSource = dsOddelki.Tables[0];
                poizvedba.Connection.Open();
                dataConnection.Close();
            }
            catch
            {
                MessageBox.Show("Neki ne dela...");
                Application.Exit();
            }
        }
    }
}
