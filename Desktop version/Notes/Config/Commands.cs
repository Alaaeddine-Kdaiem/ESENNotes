using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Config;
using Notes.Entities;
using MySql.Data.MySqlClient;

namespace Notes.Config
{
    public class Commands
    {
        static MySql_Connection mySqlConn;

        /*Fonctions De Login*/
        #region Login
            public User Exist(Login log)
            {
                User user = null;
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "SELECT COUNT(*) FROM users WHERE email='" + log.email + "' AND password='" + log.password + "'";
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        int count = dataReader.GetInt32(0);
                        if (count == 1)
                            user = GetUserByEmail(log.email);
                    }

                    return user;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            
        #endregion


        /*Fonctions De User*/
        #region User
            public bool FindUserByEmail(string email)
            {
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM users WHERE email='" + email + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
                finally
                {
                    mySqlConn.closeConnection();
                }


            }
            public User GetUserByEmail(string email)
            {
                User user = null;
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM users WHERE email='" + email + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        user = new User();

                        user.id = dataReader.GetInt32(0);
                        user.username = dataReader[1].ToString();
                        user.email = dataReader[2].ToString();
                        user.password = dataReader[3].ToString();
                        user.role = dataReader.GetInt32(4);

                    }
                    return user;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddUser(User user)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO users (username,email,password,user_role_id) VALUES ('" + user.username + "','" + user.email + "','" + user.password + "','" + user.role + "')";
                int count= mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditUser(User user)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE users SET username='" + user.username + "',email='" + user.email + "',password='" + user.password + "' WHERE id_user='" + user.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteUser(User user)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM users WHERE id_user ='" + user.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /*Fonctions D'admin*/
        #region Admin
            public Admin GetAdminById(int id)
            {
                Admin admin = null;
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "SELECT * FROM admins WHERE id_admin ='" + id + "'";
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        admin = new Admin();

                        admin.id = dataReader.GetInt32(0);
                        admin.nom = dataReader[1].ToString();
                        admin.prenom = dataReader[2].ToString();
                        admin.id_user = dataReader.GetInt32(4);

                    }
                    return admin;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddAdmin(Admin admin)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO admins (nom,prenom,id_user) VALUES ('" + admin.nom + "','" + admin.prenom + "','" + admin.id_user + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditAdmin(Admin admin)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE admins SET nom='" + admin.nom + "',prenom='" + admin.prenom + "' WHERE id_admin='" + admin.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteAdmin(Admin admin)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM admins WHERE id_admin ='" + admin.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /*Fonctions D'employe*/
        #region Employe
            public Employe GetEmployeById(int id)
            {
                Employe employe = null;
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "SELECT * FROM employes WHERE Employee_ID ='" + id + "'";
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        employe = new Employe();

                        employe.id = dataReader.GetInt32(0);
                        employe.nom = dataReader[1].ToString();
                        employe.prenom = dataReader[2].ToString();
                        employe.id_user = dataReader.GetInt32(4);

                    }
                    return employe;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddEmploye(Employe employe)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO employes (nom,prenom,id_user) VALUES ('" + employe.nom + "','" + employe.prenom + "','" + employe.id_user + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditEmploye(Employe employe)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE employes SET nom='" + employe.nom + "',prenom='" + employe.prenom + "' WHERE id_employe='" + employe.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteEmploye(Employe employe)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM employes WHERE id_employe ='" + employe.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /*Fonctions D'etudiant*/
        #region Etudiant
        public Etudiant GetEtudiantById(int id)
        {
            Etudiant etudiant = null;
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string sql = "SELECT * FROM etudiants WHERE num ='" + id + "'";
            MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
            try
            {
                if (dataReader.Read())
                {
                    etudiant = new Etudiant();

                    etudiant.id = dataReader.GetInt32(0);
                    etudiant.nom = dataReader[1].ToString();
                    etudiant.prenom = dataReader[2].ToString();
                    etudiant.id_filiere = dataReader.GetInt32(4);
                    etudiant.id_classe = dataReader.GetInt32(5);
                    etudiant.id_user = dataReader.GetInt32(6);

                }
                return etudiant;
            }
            finally
            {
                mySqlConn.closeConnection();
            }
        }
        public bool AddEtudiant(Etudiant etudiant)
        {
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string sql = "INSERT INTO etudiants (nom,prenom,id_filiere,id_classe,id_user) VALUES ('" + etudiant.nom + "','" + etudiant.prenom + "','" + etudiant.id_filiere + "','" + etudiant.id_classe +"','" + etudiant.id_user + "')";
            int count = mySqlConn.executeCommande(sql);
            mySqlConn.closeConnection();
            if (count > 0)
                return true;
            else
                return false;
        }
        public bool EditEtudiant(Etudiant etudiant)
        {
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string sql = "UPDATE etudiants SET nom='" + etudiant.nom + "',prenom='" + etudiant.prenom + "',id_filiere='" +etudiant.id_filiere +"' ,id_classe='" + etudiant.id_classe+"' WHERE num='" + etudiant.id + "'";
            int count = mySqlConn.executeCommande(sql);
            mySqlConn.closeConnection();
            if (count > 0)
                return true;
            else
                return false;
        }
        public bool DeleteEtudiant(Etudiant etudiant)
        {
            mySqlConn = new MySql_Connection();
            mySqlConn.openConnection();
            string sql = "DELETE FROM etudiants WHERE num ='" + etudiant.id + "'";
            int count = mySqlConn.executeCommande(sql);
            mySqlConn.closeConnection();
            if (count > 0)
                return true;
            else
                return false;
        }
        #endregion


        /* fonctions De Classe */
        #region Classe
        public Classe GetClasseByName(string nom)
            {
                Classe classe = null;
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM classes WHERE nom_classe='" + nom + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        classe = new Classe();

                        classe.id = dataReader.GetInt32(0);
                        classe.classe = dataReader[1].ToString();
                    }
                    return classe;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddClasse(Classe classe)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO classes (nom_classe) VALUES('" + classe.classe + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditClasse(Classe classe)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE classes SET nom_classe='" + classe.classe + "' WHERE id_classe='" + classe.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteClasse(Classe classe)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM classes WHERE id_classe ='" + classe.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /* fonctions De Devoir** */
        #region Devoir
            public Devoir GetDevoirByName(string nom)
            {
                Devoir devoir = null;
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM devoirs WHERE type_devoir='" + nom + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        devoir = new Devoir();

                        devoir.id = dataReader.GetInt32(0);
                        devoir.devoir = dataReader[1].ToString();
                    }
                    return devoir;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddDevoir(Devoir devoir) 
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO devoirs (type_devoir) VALUES('" + devoir.devoir +"')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditDevoir(Devoir devoir)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE devoirs SET type_devoir='" + devoir.devoir + "' WHERE id_devoir='" + devoir.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteDevoir(Devoir devoir)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM devoirs WHERE id_devoir='" + devoir.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /* fonctions De Filiere */
        #region Filiere
            public Filiere GetFiliereByName(string nom)
            {
                Filiere filiere = null;
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM filieres WHERE nom_filiere='" + nom + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        filiere = new Filiere();

                        filiere.id = dataReader.GetInt32(0);
                        filiere.filiere = dataReader[1].ToString();
                    }
                    return filiere;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddFiliere(Filiere filiere)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO filieres (nom_filiere) VALUES ('" + filiere.filiere + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditFiliere(Filiere filiere)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE filieres SET nom_filiere='" + filiere.filiere + "' WHERE id_filiere='" + filiere.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteFiliere(Filiere filiere)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM filieres WHERE id_filiere='" + filiere.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /* fonctions De Module */
        #region Module
            public Module GetModuleByName(string nom)
            {
                Module module = null;
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM modules WHERE intitule='" + nom + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        module = new Module();

                        module.id = dataReader.GetInt32(0);
                        module.module = dataReader[1].ToString();
                    }
                    return module;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddModule(Module module)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO modules (intitule) VALUES ('" + module.module + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditModule(Module module)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE modules SET intitule='" + module.module + "' WHERE id='" + module.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteModule(Module module)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM modules WHERE id='" + module.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion


        /* fonctions De Semestre */
        #region Semestre
            public Semestre GetSemestreByName(string nom)
            {
                Semestre semestre = null;
                mySqlConn = new MySql_Connection();
                string sql = "SELECT * FROM semestres WHERE intitule='" + nom + "';";
                mySqlConn.openConnection();
                MySqlDataReader dataReader = mySqlConn.selectCommande(sql);
                try
                {
                    if (dataReader.Read())
                    {
                        semestre = new Semestre();

                        semestre.id = dataReader.GetInt32(0);
                        semestre.semestre = dataReader[1].ToString();
                    }
                    return semestre;
                }
                finally
                {
                    mySqlConn.closeConnection();
                }
            }
            public bool AddSemestre(Semestre semestre)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO semestres (intitule) VALUES ('" + semestre.semestre + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool EditSemestre(Semestre semestre)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "UPDATE semestres SET intitule='" + semestre.semestre + "' WHERE id='" + semestre.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteSemestre(Semestre semestre)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM semestres WHERE id='" + semestre.id + "'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion

        /*fonctions De Note*/
        #region Note
            public bool AddNote(Note note)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "INSERT INTO notes VALUES ('" + note.note + "','" + note.etudiant + "','" + note.semestre + "','" + note.module + "','" + note.filiere + "','" + note.classe + "','" + note.devoir + "')";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            public bool DeleteNote(Note note)
            {
                mySqlConn = new MySql_Connection();
                mySqlConn.openConnection();
                string sql = "DELETE FROM notes WHERE num_etudiant ='" + note.etudiant + "' AND id_semestre= '" + note.semestre + "' AND id_module='" + note.module + "' AND id_filiere ='" + note.filiere + "' AND id_classe ='" + note.classe + "' AND id_devoir='" + note.devoir +"'";
                int count = mySqlConn.executeCommande(sql);
                mySqlConn.closeConnection();
                if (count > 0)
                    return true;
                else
                    return false;
            }
        #endregion
    }

}
