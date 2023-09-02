using MySql.Data.MySqlClient;
using Notes.Config;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes.GUI.sub_forms
{
    public partial class sub_list_admin : Form
    {
        
        const string server = "localhost";
        const string dataBase = "esennotes";
        const string user = "root";
        const string connexionString = "Data Source=" + server + ";Initial Catalog=" + dataBase + ";User Id=" + user + ";";
        public sub_list_admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT id_classe as ID,nom_classe as CLASSE from classes ORDER BY (id_classe)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }

        private void sub_liste_admin_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_employe_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT e.id_employe as ID,e.nom as NOM,e.prenom as PRENOM,u.email as EMAIL FROM employes e,users u WHERE e.id_user = u.id_user ORDER BY(id_employe)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT a.id_admin as ID,a.nom as NOM,a.prenom as PRENOM,u.email as EMAIL FROM admins a,users u WHERE a.id_user=u.id_user ORDER BY(id_admin)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT id as ID,intitule as MODULE  from modules ORDER BY 1 ASC";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT id as ID,intitule as SEMESTRE  from semestres ORDER BY 1 ASC";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT id_devoir as ID,type_devoir as DEVOIR from devoirs ORDER BY (id_devoir)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT id_filiere as ID,nom_filiere as FILIERE from filieres ORDER BY (id_filiere)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }
    }
}
