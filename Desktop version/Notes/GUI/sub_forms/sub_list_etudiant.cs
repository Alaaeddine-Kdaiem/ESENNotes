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
    public partial class sub_list_etudiant : Form
    {
        const string server = "localhost";
        const string dataBase = "esennotes";
        const string user = "root";
        const string connexionString = "Data Source=" + server + ";Initial Catalog=" + dataBase + ";User Id=" + user + ";";

        public sub_list_etudiant()
        {
            InitializeComponent();
        }
        public sub_list_etudiant(string username,int id)
        {
            InitializeComponent();
            labelUsername.Text= char.ToUpper(username.First()) + username.Substring(1);
            MySqlConnection mysql = new MySqlConnection(connexionString);
            mysql.Open();
            string sql = "SELECT s.intitule as SEMESTRE,m.intitule as MODULE,d.type_devoir as DEVOIR,n.note as NOTE FROM notes n,etudiants e,semestres s,modules m,filieres f,classes c,devoirs d,users u WHERE n.num_etudiant = e.num AND n.id_semestre = s.id AND n.id_module=m.id AND n.id_filiere=f.id_filiere AND n.id_classe=c.id_classe AND n.id_devoir=d.id_devoir AND e.id_user=u.id_user AND u.id_user="+id+";";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysql);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            dataGridView.DataSource = DS.Tables[0];
            mysql.Close();
        }
        private void sub_list_etudiant_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
