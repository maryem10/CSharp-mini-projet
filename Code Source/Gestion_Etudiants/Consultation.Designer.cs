namespace Gestion_Etudiants
{
    partial class Consultation
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
            this.combomodule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textmoy = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combomodule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(775, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            
            // 
            // combomodule
            // 
            this.combomodule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combomodule.FormattingEnabled = true;
            this.combomodule.Location = new System.Drawing.Point(349, 27);
            this.combomodule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combomodule.Name = "combomodule";
            this.combomodule.Size = new System.Drawing.Size(167, 24);
            this.combomodule.TabIndex = 1;
            this.combomodule.SelectedIndexChanged += new System.EventHandler(this.combomodule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODULE";
            // 
            // liste
            // 
            this.liste.AllowUserToAddRows = false;
            this.liste.AllowUserToDeleteRows = false;
            this.liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Location = new System.Drawing.Point(38, 142);
            this.liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.Size = new System.Drawing.Size(775, 379);
            this.liste.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOYENNE DE CLASSE";
            // 
            // textmoy
            // 
            this.textmoy.Enabled = false;
            this.textmoy.Location = new System.Drawing.Point(698, 558);
            this.textmoy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textmoy.Name = "textmoy";
            this.textmoy.Size = new System.Drawing.Size(116, 22);
            this.textmoy.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.etudiantToolStripMenuItem.Text = "Etudiants";
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click);
            // 
            // moduleToolStripMenuItem
            // 
            this.moduleToolStripMenuItem.Name = "moduleToolStripMenuItem";
            this.moduleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moduleToolStripMenuItem.Text = "Modules";
            this.moduleToolStripMenuItem.Click += new System.EventHandler(this.moduleToolStripMenuItem_Click_1);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noteToolStripMenuItem.Text = "notes";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click_1);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click_1);
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 588);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textmoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combomodule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textmoy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
    
}