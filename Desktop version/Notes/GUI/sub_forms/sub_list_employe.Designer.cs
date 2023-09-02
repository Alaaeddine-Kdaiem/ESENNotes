namespace Notes.GUI.sub_forms
{
    partial class sub_list_employe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_notes = new System.Windows.Forms.Button();
            this.btn_etudiants = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_modules = new System.Windows.Forms.Button();
            this.btn_semestres = new System.Windows.Forms.Button();
            this.btn_devoirs = new System.Windows.Forms.Button();
            this.btn_filieres = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btn_modules);
            this.panel1.Controls.Add(this.btn_semestres);
            this.panel1.Controls.Add(this.btn_devoirs);
            this.panel1.Controls.Add(this.btn_filieres);
            this.panel1.Controls.Add(this.btn_classes);
            this.panel1.Controls.Add(this.btn_notes);
            this.panel1.Controls.Add(this.btn_etudiants);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 51);
            this.panel1.TabIndex = 1;
            // 
            // btn_notes
            // 
            this.btn_notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_notes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_notes.FlatAppearance.BorderSize = 0;
            this.btn_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notes.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notes.Location = new System.Drawing.Point(142, 0);
            this.btn_notes.Name = "btn_notes";
            this.btn_notes.Size = new System.Drawing.Size(92, 51);
            this.btn_notes.TabIndex = 10;
            this.btn_notes.Text = "Notes";
            this.btn_notes.UseVisualStyleBackColor = false;
            this.btn_notes.Click += new System.EventHandler(this.btn_notes_Click);
            // 
            // btn_etudiants
            // 
            this.btn_etudiants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_etudiants.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_etudiants.FlatAppearance.BorderSize = 0;
            this.btn_etudiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_etudiants.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_etudiants.Location = new System.Drawing.Point(50, 0);
            this.btn_etudiants.Name = "btn_etudiants";
            this.btn_etudiants.Size = new System.Drawing.Size(92, 51);
            this.btn_etudiants.TabIndex = 9;
            this.btn_etudiants.Text = "Etudiants";
            this.btn_etudiants.UseVisualStyleBackColor = false;
            this.btn_etudiants.Click += new System.EventHandler(this.btn_etudiants_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(0, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(50, 51);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 51);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(694, 14);
            this.panelBar.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(694, 451);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btn_modules
            // 
            this.btn_modules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_modules.FlatAppearance.BorderSize = 0;
            this.btn_modules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modules.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modules.Location = new System.Drawing.Point(234, 0);
            this.btn_modules.Name = "btn_modules";
            this.btn_modules.Size = new System.Drawing.Size(92, 51);
            this.btn_modules.TabIndex = 15;
            this.btn_modules.Text = "Modules";
            this.btn_modules.UseVisualStyleBackColor = false;
            this.btn_modules.Click += new System.EventHandler(this.btn_modules_Click);
            // 
            // btn_semestres
            // 
            this.btn_semestres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_semestres.FlatAppearance.BorderSize = 0;
            this.btn_semestres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_semestres.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semestres.Location = new System.Drawing.Point(326, 0);
            this.btn_semestres.Name = "btn_semestres";
            this.btn_semestres.Size = new System.Drawing.Size(92, 51);
            this.btn_semestres.TabIndex = 14;
            this.btn_semestres.Text = "Semestres";
            this.btn_semestres.UseVisualStyleBackColor = false;
            this.btn_semestres.Click += new System.EventHandler(this.btn_semestres_Click);
            // 
            // btn_devoirs
            // 
            this.btn_devoirs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_devoirs.FlatAppearance.BorderSize = 0;
            this.btn_devoirs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devoirs.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devoirs.Location = new System.Drawing.Point(418, 0);
            this.btn_devoirs.Name = "btn_devoirs";
            this.btn_devoirs.Size = new System.Drawing.Size(92, 51);
            this.btn_devoirs.TabIndex = 13;
            this.btn_devoirs.Text = "Devoirs";
            this.btn_devoirs.UseVisualStyleBackColor = false;
            this.btn_devoirs.Click += new System.EventHandler(this.btn_devoirs_Click);
            // 
            // btn_filieres
            // 
            this.btn_filieres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_filieres.FlatAppearance.BorderSize = 0;
            this.btn_filieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filieres.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filieres.Location = new System.Drawing.Point(510, 0);
            this.btn_filieres.Name = "btn_filieres";
            this.btn_filieres.Size = new System.Drawing.Size(92, 51);
            this.btn_filieres.TabIndex = 12;
            this.btn_filieres.Text = "Filieres";
            this.btn_filieres.UseVisualStyleBackColor = false;
            this.btn_filieres.Click += new System.EventHandler(this.btn_filieres_Click);
            // 
            // btn_classes
            // 
            this.btn_classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_classes.FlatAppearance.BorderSize = 0;
            this.btn_classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_classes.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_classes.Location = new System.Drawing.Point(602, 0);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(92, 51);
            this.btn_classes.TabIndex = 11;
            this.btn_classes.Text = "Classes";
            this.btn_classes.UseVisualStyleBackColor = false;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // sub_list_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panel1);
            this.Name = "sub_list_employe";
            this.Text = "sub_list_employe";
            this.Load += new System.EventHandler(this.sub_list_employe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_etudiants;
        private System.Windows.Forms.Button btn_notes;
        private System.Windows.Forms.Button btn_modules;
        private System.Windows.Forms.Button btn_semestres;
        private System.Windows.Forms.Button btn_devoirs;
        private System.Windows.Forms.Button btn_filieres;
        private System.Windows.Forms.Button btn_classes;
    }
}