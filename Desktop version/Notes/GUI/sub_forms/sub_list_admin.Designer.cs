namespace Notes.GUI.sub_forms
{
    partial class sub_list_admin
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
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_employes = new System.Windows.Forms.Button();
            this.btn_admins = new System.Windows.Forms.Button();
            this.btn_modules = new System.Windows.Forms.Button();
            this.btn_semestres = new System.Windows.Forms.Button();
            this.btn_devoirs = new System.Windows.Forms.Button();
            this.btn_filieres = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.panelOptions.Controls.Add(this.btn_Exit);
            this.panelOptions.Controls.Add(this.btn_employes);
            this.panelOptions.Controls.Add(this.btn_admins);
            this.panelOptions.Controls.Add(this.btn_modules);
            this.panelOptions.Controls.Add(this.btn_semestres);
            this.panelOptions.Controls.Add(this.btn_devoirs);
            this.panelOptions.Controls.Add(this.btn_filieres);
            this.panelOptions.Controls.Add(this.btn_classes);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(694, 51);
            this.panelOptions.TabIndex = 0;
            this.panelOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btn_Exit.Size = new System.Drawing.Size(51, 51);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_employes
            // 
            this.btn_employes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_employes.FlatAppearance.BorderSize = 0;
            this.btn_employes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employes.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employes.Location = new System.Drawing.Point(50, 0);
            this.btn_employes.Name = "btn_employes";
            this.btn_employes.Size = new System.Drawing.Size(92, 51);
            this.btn_employes.TabIndex = 6;
            this.btn_employes.Text = "Employés";
            this.btn_employes.UseVisualStyleBackColor = false;
            this.btn_employes.Click += new System.EventHandler(this.btn_employe_Click);
            // 
            // btn_admins
            // 
            this.btn_admins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_admins.FlatAppearance.BorderSize = 0;
            this.btn_admins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admins.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admins.Location = new System.Drawing.Point(142, 0);
            this.btn_admins.Name = "btn_admins";
            this.btn_admins.Size = new System.Drawing.Size(92, 51);
            this.btn_admins.TabIndex = 5;
            this.btn_admins.Text = "Admins";
            this.btn_admins.UseVisualStyleBackColor = false;
            this.btn_admins.Click += new System.EventHandler(this.btn_admin_Click);
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
            this.btn_modules.TabIndex = 4;
            this.btn_modules.Text = "Modules";
            this.btn_modules.UseVisualStyleBackColor = false;
            this.btn_modules.Click += new System.EventHandler(this.button5_Click);
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
            this.btn_semestres.TabIndex = 3;
            this.btn_semestres.Text = "Semestres";
            this.btn_semestres.UseVisualStyleBackColor = false;
            this.btn_semestres.Click += new System.EventHandler(this.button4_Click);
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
            this.btn_devoirs.TabIndex = 2;
            this.btn_devoirs.Text = "Devoirs";
            this.btn_devoirs.UseVisualStyleBackColor = false;
            this.btn_devoirs.Click += new System.EventHandler(this.button3_Click);
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
            this.btn_filieres.TabIndex = 1;
            this.btn_filieres.Text = "Filieres";
            this.btn_filieres.UseVisualStyleBackColor = false;
            this.btn_filieres.Click += new System.EventHandler(this.button2_Click);
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
            this.btn_classes.TabIndex = 0;
            this.btn_classes.Text = "Classes";
            this.btn_classes.UseVisualStyleBackColor = false;
            this.btn_classes.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(53)))));
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 51);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(694, 14);
            this.panelBar.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(694, 451);
            this.dataGridView.TabIndex = 0;
            // 
            // sub_list_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelOptions);
            this.Name = "sub_list_admin";
            this.Text = "sub_liste";
            this.Load += new System.EventHandler(this.sub_liste_admin_Load);
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button btn_classes;
        private System.Windows.Forms.Button btn_employes;
        private System.Windows.Forms.Button btn_admins;
        private System.Windows.Forms.Button btn_modules;
        private System.Windows.Forms.Button btn_semestres;
        private System.Windows.Forms.Button btn_devoirs;
        private System.Windows.Forms.Button btn_filieres;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}