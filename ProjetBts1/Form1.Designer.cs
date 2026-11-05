namespace ProjetBts1
{
    partial class btnenregistrer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            this.btn1enregistrer = new Button();
            lblajtmateriel = new Label();
            textBox1 = new TextBox();
            Materiel = new ListBox();
            btnSupp = new Button();
            Responsable = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            Incidents = new DataGridView();
            numeroincident = new DataGridViewTextBoxColumn();
            Materiels = new DataGridViewTextBoxColumn();
            Gravite = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            incidentsdeclarer = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            Responsable.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Incidents).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(incidentsdeclarer);
            groupBox1.Controls.Add(btnSupp);
            groupBox1.Controls.Add(Materiel);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblajtmateriel);
            groupBox1.Controls.Add(this.btn1enregistrer);
            groupBox1.Location = new Point(15, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Techniciens";
            // 
            // btn1enregistrer
            // 
            this.btn1enregistrer.Location = new Point(109, 70);
            this.btn1enregistrer.Name = "btn1enregistrer";
            this.btn1enregistrer.Size = new Size(75, 23);
            this.btn1enregistrer.TabIndex = 0;
            this.btn1enregistrer.Text = "Enregister";
            this.btn1enregistrer.UseVisualStyleBackColor = true;
            // 
            // lblajtmateriel
            // 
            lblajtmateriel.AutoSize = true;
            lblajtmateriel.Location = new Point(6, 32);
            lblajtmateriel.Name = "lblajtmateriel";
            lblajtmateriel.Size = new Size(161, 15);
            lblajtmateriel.TabIndex = 1;
            lblajtmateriel.Text = "Ajout d'un nouveau materiel:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // Materiel
            // 
            Materiel.FormattingEnabled = true;
            Materiel.Location = new Point(6, 99);
            Materiel.Name = "Materiel";
            Materiel.Size = new Size(120, 94);
            Materiel.TabIndex = 1;
            // 
            // btnSupp
            // 
            btnSupp.Location = new Point(68, 214);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(75, 23);
            btnSupp.TabIndex = 3;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            // 
            // Responsable
            // 
            Responsable.Controls.Add(tabPage1);
            Responsable.Controls.Add(tabPage2);
            Responsable.Controls.Add(tabPage3);
            Responsable.Location = new Point(24, -8);
            Responsable.Name = "Responsable";
            Responsable.SelectedIndex = 0;
            Responsable.Size = new Size(641, 545);
            Responsable.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(633, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Incidents);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(633, 517);
            tabPage2.TabIndex = 1;
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(552, 280);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Incidents
            // 
            Incidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Incidents.Columns.AddRange(new DataGridViewColumn[] { numeroincident, Materiels, Gravite, Description, Statut });
            Incidents.Location = new Point(15, 282);
            Incidents.Name = "Incidents";
            Incidents.Size = new Size(564, 89);
            Incidents.TabIndex = 1;
            Incidents.CellContentClick += Incidents_CellContentClick;
            // 
            // numeroincident
            // 
            numeroincident.HeaderText = "n°Incident";
            numeroincident.Name = "numeroincident";
            // 
            // Materiels
            // 
            Materiels.HeaderText = "Materiels";
            Materiels.Name = "Materiels";
            // 
            // Gravite
            // 
            Gravite.HeaderText = "Gravité";
            Gravite.Name = "Gravite";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Statut
            // 
            Statut.HeaderText = "Statut";
            Statut.Name = "Statut";
            // 
            // incidentsdeclarer
            // 
            incidentsdeclarer.AutoSize = true;
            incidentsdeclarer.Location = new Point(6, 248);
            incidentsdeclarer.Name = "incidentsdeclarer";
            incidentsdeclarer.Size = new Size(189, 15);
            incidentsdeclarer.TabIndex = 2;
            incidentsdeclarer.Text = "Historique des incidents déclarées:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(32, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(347, 463);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnenregistrer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Responsable);
            Name = "btnenregistrer";
            Text = "enregistrer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Responsable.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Incidents).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label lblajtmateriel;
        private TextBox textBox1;
        private ListBox Materiel;
        private Button btnSupp;
        private TabControl Responsable;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView Incidents;
        private DataGridViewTextBoxColumn numeroincident;
        private DataGridViewTextBoxColumn Materiels;
        private DataGridViewTextBoxColumn Gravite;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Statut;
        private Label incidentsdeclarer;
        private GroupBox groupBox2;
        private Label label1;
    }
}
