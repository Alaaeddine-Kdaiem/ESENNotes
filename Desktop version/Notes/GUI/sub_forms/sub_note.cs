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
    public partial class sub_note : Form
    {
        public sub_note()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text!="" && txt_semestre.Text!="" && txt_module.Text!="" && txt_devoir.Text!="" && txt_note.Text!="")
            {
                Commands cmd = new Commands();
                
                try
                {
                    int val = Int32.Parse(txt_ID.Text);
                    
                    if (val > 0)
                    {
                        try
                        {
                            double Vnote =double.Parse(txt_note.Text);

                            if(Vnote >= 0 && Vnote <=20)
                            {
                                Etudiant etudiant = cmd.GetEtudiantById(val);
                                if (etudiant != null)
                                {
                                    Semestre semestre = cmd.GetSemestreByName(txt_semestre.Text);
                                    if (semestre != null)
                                    {
                                        Module module = cmd.GetModuleByName(txt_module.Text);
                                        if (module != null)
                                        {
                                            Devoir devoir = cmd.GetDevoirByName(txt_devoir.Text);
                                            if (devoir != null)
                                            {
                                                Note note = new Note(Vnote,etudiant.id,semestre.id,module.id,etudiant.id_filiere,etudiant.id_classe,devoir.id);
                                                if(cmd.AddNote(note))
                                                {
                                                    MessageBox.Show("Note ajouté avec succes.", "SUCCES",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Note n'est pas ajouté!", "ATTENTION",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Devoir introuvable, veuillez saisir un autre devoir !", "ATTENTION",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Module introuvable, veuillez saisir un autre module !", "ATTENTION",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Semestre introuvable, veuillez saisir une autre semestre !", "ATTENTION",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ID introuvable, veuillez remplir le champ ID avec un autre nombre !", "ATTENTION",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erreur de note, veuillez remplir le champ note avec un nombre entre 0 et 20 !", "ATTENTION",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Erreur de note, veuillez remplir le champ note avec un nombre entre 0 et 20 !", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir le champ ID avec un nombre positive", "ATTENTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID introuvable, veuillez remplir le champ ID avec un autre nombre !", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir tous les champs !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text != "" && txt_semestre.Text != "" && txt_module.Text != "" && txt_devoir.Text != "" )
            {
                if(txt_note.Text != "")
                {
                    MessageBox.Show("l n'est pas nécessaire de remplir le champ Note .", "SUPPORT",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Commands cmd = new Commands();

                try
                {
                    int val = Int32.Parse(txt_ID.Text);

                    if (val > 0)
                    {

                       Etudiant etudiant = cmd.GetEtudiantById(val);
                           if (etudiant != null)
                                {
                                    Semestre semestre = cmd.GetSemestreByName(txt_semestre.Text);
                                    if (semestre != null)
                                    {
                                        Module module = cmd.GetModuleByName(txt_module.Text);
                                        if (module != null)
                                        {
                                            Devoir devoir = cmd.GetDevoirByName(txt_devoir.Text);
                                            if (devoir != null)
                                            {
                                                Note note = new Note(etudiant.id,semestre.id,module.id,etudiant.id_filiere,etudiant.id_classe,devoir.id);
                                                if(cmd.DeleteNote(note))
                                                {
                                                    MessageBox.Show("Note supprimer avec succes.", "SUCCES",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Note n'existe pas!", "ATTENTION",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Devoir introuvable, veuillez saisir un autre devoir !", "ATTENTION",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Module introuvable, veuillez saisir un autre module !", "ATTENTION",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Semestre introuvable, veuillez saisir une autre semestre !", "ATTENTION",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                           }
                           else
                             {
                                MessageBox.Show("ID introuvable, veuillez remplir le champ ID avec un autre nombre !", "ATTENTION",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir le champ ID avec un nombre positive", "ATTENTION",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("ID introuvable, veuillez remplir le champ ID avec un autre nombre !", "ATTENTION",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir tous les champs sauf le champ Note !", "ATTENTION",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sub_note_Load(object sender, EventArgs e)
        {

        }
    }
}
