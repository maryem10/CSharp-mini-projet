namespace Gestion_Etudiants
{
    partial class Gestion_notes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textnote = new System.Windows.Forms.TextBox();
            this.combomodule = new System.Windows.Forms.ComboBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.comboins = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_apercu = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textnote);
            this.groupBox1.Controls.Add(this.combomodule);
            this.groupBox1.Controls.Add(this.textnom);
            this.groupBox1.Controls.Add(this.comboins);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(519, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textnote
            // 
            this.textnote.Location = new System.Drawing.Point(257, 205);
            this.textnote.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textnote.Name = "textnote";
            this.textnote.Size = new System.Drawing.Size(167, 22);
            this.textnote.TabIndex = 4;
            this.textnote.TextChanged += new System.EventHandler(this.textnote_TextChanged);
            // 
            // combomodule
            // 
            this.combomodule.FormattingEnabled = true;
            this.combomodule.Location = new System.Drawing.Point(257, 145);
            this.combomodule.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combomodule.Name = "combomodule";
            this.combomodule.Size = new System.Drawing.Size(167, 24);
            this.combomodule.TabIndex = 3;
            this.combomodule.SelectedIndexChanged += new System.EventHandler(this.combomodule_SelectedIndexChanged);
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(257, 83);
            this.textnom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(167, 22);
            this.textnom.TabIndex = 2;
            this.textnom.TextChanged += new System.EventHandler(this.textnom_TextChanged);
            // 
            // comboins
            // 
            this.comboins.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboins.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboins.FormattingEnabled = true;
            this.comboins.Location = new System.Drawing.Point(257, 37);
            this.comboins.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboins.Name = "comboins";
            this.comboins.Size = new System.Drawing.Size(167, 24);
            this.comboins.TabIndex = 1;
            this.comboins.SelectedIndexChanged += new System.EventHandler(this.comboins_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "MODULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOM ET PRENOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO D\'INSCRIPTION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_quitter);
            this.groupBox2.Controls.Add(this.button_apercu);
            this.groupBox2.Controls.Add(this.button_modifier);
            this.groupBox2.Controls.Add(this.button_enregistrer);
            this.groupBox2.Location = new System.Drawing.Point(582, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(203, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(21, 183);
            this.button_quitter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(113, 29);
            this.button_quitter.TabIndex = 0;
            this.button_quitter.Text = "vider";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_apercu
            // 
            this.button_apercu.Location = new System.Drawing.Point(21, 136);
            this.button_apercu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_apercu.Name = "button_apercu";
            this.button_apercu.Size = new System.Drawing.Size(113, 29);
            this.button_apercu.TabIndex = 0;
            this.button_apercu.Text = "APERCU";
            this.button_apercu.UseVisualStyleBackColor = true;
            this.button_apercu.Click += new System.EventHandler(this.button_apercu_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(21, 89);
            this.button_modifier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(113, 29);
            this.button_modifier.TabIndex = 0;
            this.button_modifier.Text = "MODIFIER note";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(21, 33);
            this.button_enregistrer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(113, 29);
            this.button_enregistrer.TabIndex = 0;
            this.button_enregistrer.Text = "Ajouter Note";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // liste
            // 
            this.liste.AllowUserToAddRows = false;
            this.liste.AllowUserToDeleteRows = false;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Location = new System.Drawing.Point(84, 329);
            this.liste.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(583, 202);
            this.liste.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem,
            this.moduleToolStripMenuItem,
            this.noteToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.etudiantToolStripMenuItem.Text = "Etudiants";
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click);
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.moduleToolStripMenuItem.Text = "Modules";
            this.moduleToolStripMenuItem.Click += new System.EventHandler(this.moduleToolStripMenuItem_Click);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.noteToolStripMenuItem.Text = "notes";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // Gestion_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 541);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Gestion_notes";
            this.Text = "GESTION DES noteS";
            this.Load += new System.EventHandler(this.Gestion_notes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.TextBox textnote;
        private System.Windows.Forms.ComboBox combomodule;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.ComboBox comboins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_apercu;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}

        