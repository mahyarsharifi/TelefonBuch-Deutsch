
namespace TelefonBuch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewContact = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.dgKontakt = new System.Windows.Forms.DataGridView();
            this.KontaktID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandyNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anschrift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKontakt)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewContact,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewContact
            // 
            this.btnNewContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewContact.Image = ((System.Drawing.Image)(resources.GetObject("btnNewContact.Image")));
            this.btnNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(90, 22);
            this.btnNewContact.Text = "Neuer Kontakt ";
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 22);
            this.btnSearch.Text = "Aktualisierung";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSuche);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suche";
            // 
            // txtSuche
            // 
            this.txtSuche.Location = new System.Drawing.Point(98, 29);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(251, 20);
            this.txtSuche.TabIndex = 1;
            this.txtSuche.TextChanged += new System.EventHandler(this.txtSuche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suche :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLöschen);
            this.groupBox2.Controls.Add(this.btnBearbeiten);
            this.groupBox2.Controls.Add(this.dgKontakt);
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste";
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(88, 321);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(75, 23);
            this.btnLöschen.TabIndex = 2;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(7, 321);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(75, 23);
            this.btnBearbeiten.TabIndex = 1;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // dgKontakt
            // 
            this.dgKontakt.AllowUserToAddRows = false;
            this.dgKontakt.AllowUserToDeleteRows = false;
            this.dgKontakt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKontakt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKontakt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KontaktID,
            this.MName,
            this.Familie,
            this.HandyNummer,
            this.Email,
            this.Alter,
            this.Anschrift});
            this.dgKontakt.Location = new System.Drawing.Point(7, 20);
            this.dgKontakt.Name = "dgKontakt";
            this.dgKontakt.ReadOnly = true;
            this.dgKontakt.Size = new System.Drawing.Size(645, 295);
            this.dgKontakt.TabIndex = 0;
            // 
            // KontaktID
            // 
            this.KontaktID.DataPropertyName = "KontaktID";
            this.KontaktID.HeaderText = "KontaktID";
            this.KontaktID.Name = "KontaktID";
            this.KontaktID.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "Name";
            this.MName.HeaderText = "Name";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // Familie
            // 
            this.Familie.DataPropertyName = "Familie";
            this.Familie.HeaderText = "Familie";
            this.Familie.Name = "Familie";
            this.Familie.ReadOnly = true;
            // 
            // HandyNummer
            // 
            this.HandyNummer.DataPropertyName = "HandyNummer";
            this.HandyNummer.HeaderText = "HandyNummer";
            this.HandyNummer.Name = "HandyNummer";
            this.HandyNummer.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Alter
            // 
            this.Alter.DataPropertyName = "Age";
            this.Alter.HeaderText = "Alter";
            this.Alter.Name = "Alter";
            this.Alter.ReadOnly = true;
            // 
            // Anschrift
            // 
            this.Anschrift.DataPropertyName = "Anschrift";
            this.Anschrift.HeaderText = "Anschrift";
            this.Anschrift.Name = "Anschrift";
            this.Anschrift.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelefonBuch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKontakt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgKontakt;
        private System.Windows.Forms.ToolStripButton btnNewContact;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familie;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandyNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anschrift;
    }
}

