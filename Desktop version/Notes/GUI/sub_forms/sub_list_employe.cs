using MySql.Data.MySqlClient;
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
    public partial class sub_list_employe : Form
    {
        const string server = "localhost";
        const string dataBase = "esennotes";
        const string user = "root";
        const string connexionString = "Data Source=" + server + ";Initial Catalog=" + dataBase + ";User Id=" + user + ";";

        public sub_list_employe()
        {
            InitializeComponent();
        }

        private void btn_etudiants_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT e.num as ID,e.nom as NOM,e.prenom as PRENOM,f.nom_filiere as FILIERE,u.email as EMAIL,c.nom_classe as CLASSE FROM etudiants e,filieres f,users u,classes c WHERE e.id_filiere=f.id_filiere AND e.id_user=u.id_user AND c.id_classe=e.id_classe ORDER BY(num)";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }

        private void sub_list_employe_Load(object sender, EventArgs e)
        {

        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT f.nom_filiere as FILIERE,s.intitule as SEMESTRE,m.intitule as MODULE,c.nom_classe as CLASSE,d.type_devoir as DEVOIR,e.nom as NOM,e.prenom as PRENOM,n.note as NOTE FROM notes n,etudiants e, semestres s,modules m, filieres f,classes c, devoirs d WHERE n.num_etudiant = e.num AND n.id_semestre = s.id AND n.id_module = m.id AND n.id_filiere = f.id_filiere AND n.id_classe = c.id_classe AND n.id_devoir = d.id_devoir ORDER BY s.intitule,m.intitule,e.nom,e.prenom;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modules_Click(object sender, EventArgs e)
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

        private void btn_semestres_Click(object sender, EventArgs e)
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

        private void btn_devoirs_Click(object sender, EventArgs e)
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

        private void btn_filieres_Click(object sender, EventArgs e)
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

        private void btn_classes_Click(object sender, EventArgs e)
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
