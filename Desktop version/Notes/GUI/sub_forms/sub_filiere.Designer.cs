namespace Notes.GUI.sub_forms
{
    partial class sub_filiere
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.labelExp = new System.Windows.Forms.Label();
            this.label_show_hide_ID = new System.Windows.Forms.Label();
            this.txt_filiere = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label_filiere = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(395, 393);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(133, 45);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(10)))));
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(230, 393);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 45);
            this.btn_edit.TabIndex = 33;
            this.btn_edit.Text = "Modifier";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(68, 393);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 45);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // labelExp
            // 
            this.labelExp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.labelExp.Location = new System.Drawing.Point(63, 307);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(87, 27);
            this.labelExp.TabIndex = 31;
            this.labelExp.Text = "*Support";
            this.labelExp.Click += new System.EventHandler(this.labelExp_Click);
            // 
            // label_show_hide_ID
            // 
            this.label_show_hide_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_show_hide_ID.AutoSize = true;
            this.label_show_hide_ID.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show_hide_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.label_show_hide_ID.Location = new System.Drawing.Point(551, 85);
            this.label_show_hide_ID.Name = "label_show_hide_ID";
            this.label_show_hide_ID.Size = new System.Drawing.Size(100, 25);
            this.label_show_hide_ID.TabIndex = 30;
            this.label_show_hide_ID.Text = "Afficher ID";
            this.label_show_hide_ID.Click += new System.EventHandler(this.label_show_hide_ID_Click);
            // 
            // txt_filiere
            // 
            this.txt_filiere.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_filiere.Location = new System.Drawing.Point(193, 129);
            this.txt_filiere.Name = "txt_filiere";
            this.txt_filiere.Size = new System.Drawing.Size(335, 20);
            this.txt_filiere.TabIndex = 29;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ID.Location = new System.Drawing.Point(193, 85);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(335, 20);
            this.txt_ID.TabIndex = 28;
            // 
            // label_filiere
            // 
            this.label_filiere.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_filiere.AutoSize = true;
            this.label_filiere.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filiere.Location = new System.Drawing.Point(63, 125);
            this.label_filiere.Name = "label_filiere";
            this.label_filiere.Size = new System.Drawing.Size(74, 25);
            this.label_filiere.TabIndex = 27;
            this.label_filiere.Text = "Filiere :";
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(63, 81);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(48, 25);
            this.label_ID.TabIndex = 26;
            this.label_ID.Text = "ID :*";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(0, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(51, 51);
            this.btn_Exit.TabIndex = 25;
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
            this.panelBar.TabIndex = 36;
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.panelOptions.Controls.Add(this.btn_Exit);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(694, 51);
            this.panelOptions.TabIndex = 35;
            // 
            // sub_filiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(694, 516);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.label_show_hide_ID);
            this.Controls.Add(this.txt_filiere);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label_filiere);
            this.Controls.Add(this.label_ID);
            this.Name = "sub_filiere";
            this.Text = "sub_filiere";
            this.Load += new System.EventHandler(this.sub_filiere_Load);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label label_show_hide_ID;
        private System.Windows.Forms.TextBox txt_filiere;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label_filiere;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelOptions;
    }
}