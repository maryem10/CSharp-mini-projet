namespace Gestion_Etudiants
{
    partial class Form3_Etudiant
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4_vider = new System.Windows.Forms.Button();
            this.button3_modifier = new System.Windows.Forms.Button();
            this.button2_supprimer = new System.Windows.Forms.Button();
            this.button1_ajouter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4_vider);
            this.panel1.Controls.Add(this.button3_modifier);
            this.panel1.Controls.Add(this.button2_supprimer);
            this.panel1.Controls.Add(this.button1_ajouter);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 441);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Gestion des Etudiant";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 156);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nom d\'etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Prénom d\'etudiant";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Date de naissance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Numero d\'inscription";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 31;
            // 
            // button4_vider
            // 
            this.button4_vider.Location = new System.Drawing.Point(539, 221);
            this.button4_vider.Name = "button4_vider";
            this.button4_vider.Size = new System.Drawing.Size(95, 23);
            this.button4_vider.TabIndex = 30;
            this.button4_vider.Text = "vider";
            this.button4_vider.UseVisualStyleBackColor = true;
            this.button4_vider.Click += new System.EventHandler(this.button4_quitter_Click);
            // 
            // button3_modifier
            // 
            this.button3_modifier.Location = new System.Drawing.Point(539, 169);
            this.button3_modifier.Name = "button3_modifier";
            this.button3_modifier.Size = new System.Drawing.Size(95, 23);
            this.button3_modifier.TabIndex = 29;
            this.button3_modifier.Text = "Modifier";
            this.button3_modifier.UseVisualStyleBackColor = true;
            this.button3_modifier.Click += new System.EventHandler(this.button3_modifier_Click);
            // 
            // button2_supprimer
            // 
            this.button2_supprimer.Location = new System.Drawing.Point(539, 117);
            this.button2_supprimer.Name = "button2_supprimer";
            this.button2_supprimer.Size = new System.Drawing.Size(95, 23);
            this.button2_supprimer.TabIndex = 28;
            this.button2_supprimer.Text = "Supprimer";
            this.button2_supprimer.UseVisualStyleBackColor = true;
            this.button2_supprimer.Click += new System.EventHandler(this.button2_supprimer_Click);
            // 
            // button1_ajouter
            // 
            this.button1_ajouter.Location = new System.Drawing.Point(539, 67);
            this.button1_ajouter.Name = "button1_ajouter";
            this.button1_ajouter.Size = new System.Drawing.Size(95, 23);
            this.button1_ajouter.TabIndex = 27;
            this.button1_ajouter.Text = "Ajouter";
            this.button1_ajouter.UseVisualStyleBackColor = true;
            this.button1_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
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
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click_1);
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
            // Form3_Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3_Etudiant";
            this.Text = "Form3_Etudaiant";
            this.Load += new System.EventHandler(this.Form3_Etudiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4_vider;
        private System.Windows.Forms.Button button3_modifier;
        private System.Windows.Forms.Button button2_supprimer;
        private System.Windows.Forms.Button button1_ajouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}