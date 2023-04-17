using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace filmi
{
    public partial class Okno : Form
    {
        private const string povNiz = @"Data Source=filmi.sqlite; Verison=3;";
        public Okno()
        {
            InitializeComponent();
        }

        private void OknoNalozi(object sender, EventArgs e)
        {
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand("SELECT id, naslov, leto, reziser FROM filmi", povezava);
            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read()) 
            { 
                DataGridViewRow vrstica = new DataGridViewRow();
                vrstica.CreateCells(dataGridView);
                vrstica.Cells[0].Value = rez["id"].ToString();
                vrstica.Cells[1].Value = rez["naslov"].ToString();
                vrstica.Cells[2].Value = rez["leto"].ToString();
                vrstica.Cells[3].Value = rez["reziser"].ToString();
                dataGridView.Rows.Add(vrstica);
            }
        }

        private void Poisci(object sender, MouseEventArgs e)
        {
            string vnosLeto = letoTextBox.Text;
            int leto;
            SQLiteCommand ukaz;
            SQLiteConnection povezava = new SQLiteConnection(povNiz);
            povezava.Open();
            if (int.TryParse(vnosLeto, out leto))
            {
                dataGridView.Rows.Clear();
                ukaz = new SQLiteCommand("SELECT id, naslov, leto, reziser FROM filmi WHERE leto = '" + leto + "'" , povezava);
            }
            else
            {
                ukaz = new SQLiteCommand("SELECT id, naslov, leto, reziser FROM filmi", povezava);
                letoTextBox.Text = "";
            }
            
            SQLiteDataReader rez = ukaz.ExecuteReader();
            while (rez.Read())
            {
                DataGridViewRow vrstica = new DataGridViewRow();
                vrstica.CreateCells(dataGridView);
                vrstica.Cells[0].Value = rez["id"].ToString();
                vrstica.Cells[1].Value = rez["naslov"].ToString();
                vrstica.Cells[2].Value = rez["leto"].ToString();
                vrstica.Cells[3].Value = rez["reziser"].ToString();
                dataGridView.Rows.Add(vrstica);
            }

        }
    }
}
