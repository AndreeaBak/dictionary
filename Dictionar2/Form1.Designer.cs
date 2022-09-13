
namespace Dictionar2
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
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAdaugaCuvant = new System.Windows.Forms.Button();
            this.tbDefinitie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCuvant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuvinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficCuvinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCuvant = new System.Windows.Forms.Label();
            this.tbTrad = new System.Windows.Forms.TextBox();
            this.lblTraducere = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnRomEng = new System.Windows.Forms.RadioButton();
            this.radioBtnEngRom = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tbmess = new System.Windows.Forms.TextBox();
            this.CuvNec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CuvTrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Definitie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTrad = new System.Windows.Forms.ListView();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragAndDropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(277, 87);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(132, 32);
            this.btnCauta.TabIndex = 0;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAdaugaCuvant
            // 
            this.btnAdaugaCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaCuvant.Location = new System.Drawing.Point(420, 87);
            this.btnAdaugaCuvant.Name = "btnAdaugaCuvant";
            this.btnAdaugaCuvant.Size = new System.Drawing.Size(132, 32);
            this.btnAdaugaCuvant.TabIndex = 1;
            this.btnAdaugaCuvant.Text = "Adauga";
            this.btnAdaugaCuvant.UseVisualStyleBackColor = true;
            this.btnAdaugaCuvant.Click += new System.EventHandler(this.btnAdaugaCuvant_Click);
            // 
            // tbDefinitie
            // 
            this.tbDefinitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefinitie.Location = new System.Drawing.Point(12, 231);
            this.tbDefinitie.Multiline = true;
            this.tbDefinitie.Name = "tbDefinitie";
            this.tbDefinitie.ReadOnly = true;
            this.tbDefinitie.Size = new System.Drawing.Size(540, 111);
            this.tbDefinitie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipul traducerii:";
            // 
            // tbCuvant
            // 
            this.tbCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuvant.Location = new System.Drawing.Point(12, 92);
            this.tbCuvant.Name = "tbCuvant";
            this.tbCuvant.Size = new System.Drawing.Size(242, 27);
            this.tbCuvant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ATENTIE: Scrieti cu litere mici si fara diacritice";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareToolStripMenuItem,
            this.cuvinteToolStripMenuItem,
            this.graficCuvinteToolStripMenuItem,
            this.dragAndDropToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.rapoarteToolStripMenuItem.Text = "View";
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afisareToolStripMenuItem.Text = "List View";
            this.afisareToolStripMenuItem.Click += new System.EventHandler(this.afisareToolStripMenuItem_Click);
            // 
            // cuvinteToolStripMenuItem
            // 
            this.cuvinteToolStripMenuItem.Name = "cuvinteToolStripMenuItem";
            this.cuvinteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cuvinteToolStripMenuItem.Text = "Print Document";
            this.cuvinteToolStripMenuItem.Click += new System.EventHandler(this.cuvinteToolStripMenuItem_Click);
            // 
            // graficCuvinteToolStripMenuItem
            // 
            this.graficCuvinteToolStripMenuItem.Name = "graficCuvinteToolStripMenuItem";
            this.graficCuvinteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.graficCuvinteToolStripMenuItem.Text = "Graph";
            this.graficCuvinteToolStripMenuItem.Click += new System.EventHandler(this.graficCuvinteToolStripMenuItem_Click);
            // 
            // lblCuvant
            // 
            this.lblCuvant.AutoSize = true;
            this.lblCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuvant.Location = new System.Drawing.Point(12, 70);
            this.lblCuvant.Name = "lblCuvant";
            this.lblCuvant.Size = new System.Drawing.Size(56, 17);
            this.lblCuvant.TabIndex = 9;
            this.lblCuvant.Text = "Cuvant:";
            // 
            // tbTrad
            // 
            this.tbTrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrad.Location = new System.Drawing.Point(12, 171);
            this.tbTrad.Name = "tbTrad";
            this.tbTrad.ReadOnly = true;
            this.tbTrad.Size = new System.Drawing.Size(242, 27);
            this.tbTrad.TabIndex = 10;
            // 
            // lblTraducere
            // 
            this.lblTraducere.AutoSize = true;
            this.lblTraducere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraducere.Location = new System.Drawing.Point(9, 151);
            this.lblTraducere.Name = "lblTraducere";
            this.lblTraducere.Size = new System.Drawing.Size(78, 17);
            this.lblTraducere.TabIndex = 11;
            this.lblTraducere.Text = "Traducere:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Definitie:";
            // 
            // radioBtnRomEng
            // 
            this.radioBtnRomEng.AutoSize = true;
            this.radioBtnRomEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRomEng.Location = new System.Drawing.Point(181, 31);
            this.radioBtnRomEng.Name = "radioBtnRomEng";
            this.radioBtnRomEng.Size = new System.Drawing.Size(120, 24);
            this.radioBtnRomEng.TabIndex = 13;
            this.radioBtnRomEng.TabStop = true;
            this.radioBtnRomEng.Text = "Rom -> Eng";
            this.radioBtnRomEng.UseVisualStyleBackColor = true;
            // 
            // radioBtnEngRom
            // 
            this.radioBtnEngRom.AutoSize = true;
            this.radioBtnEngRom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEngRom.Location = new System.Drawing.Point(364, 29);
            this.radioBtnEngRom.Name = "radioBtnEngRom";
            this.radioBtnEngRom.Size = new System.Drawing.Size(120, 24);
            this.radioBtnEngRom.TabIndex = 14;
            this.radioBtnEngRom.TabStop = true;
            this.radioBtnEngRom.Text = "Eng -> Rom";
            this.radioBtnEngRom.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // tbmess
            // 
            this.tbmess.BackColor = System.Drawing.SystemColors.Control;
            this.tbmess.Location = new System.Drawing.Point(12, 492);
            this.tbmess.Multiline = true;
            this.tbmess.Name = "tbmess";
            this.tbmess.Size = new System.Drawing.Size(537, 150);
            this.tbmess.TabIndex = 16;
            // 
            // CuvNec
            // 
            this.CuvNec.Text = "Cuvant Necunoscut";
            // 
            // CuvTrad
            // 
            this.CuvTrad.Text = "Cuvant Tradus";
            // 
            // Definitie
            // 
            this.Definitie.Text = "Definitie";
            // 
            // lvTrad
            // 
            this.lvTrad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvTrad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CuvNec,
            this.CuvTrad,
            this.Definitie});
            this.lvTrad.HideSelection = false;
            this.lvTrad.Location = new System.Drawing.Point(12, 370);
            this.lvTrad.Name = "lvTrad";
            this.lvTrad.Size = new System.Drawing.Size(540, 116);
            this.lvTrad.TabIndex = 15;
            this.lvTrad.UseCompatibleStateImageBehavior = false;
            this.lvTrad.View = System.Windows.Forms.View.Details;
            this.lvTrad.SelectedIndexChanged += new System.EventHandler(this.lvTrad_SelectedIndexChanged);
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrieveToolStripMenuItem,
            this.storeToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.dataBaseToolStripMenuItem.Text = "Data Base";
            // 
            // retrieveToolStripMenuItem
            // 
            this.retrieveToolStripMenuItem.Name = "retrieveToolStripMenuItem";
            this.retrieveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.retrieveToolStripMenuItem.Text = "Retrieve";
            this.retrieveToolStripMenuItem.Click += new System.EventHandler(this.retrieveToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.storeToolStripMenuItem.Text = "Store";
            this.storeToolStripMenuItem.Click += new System.EventHandler(this.storeToolStripMenuItem_Click);
            // 
            // dragAndDropToolStripMenuItem
            // 
            this.dragAndDropToolStripMenuItem.Name = "dragAndDropToolStripMenuItem";
            this.dragAndDropToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dragAndDropToolStripMenuItem.Text = "Drag and Drop";
            this.dragAndDropToolStripMenuItem.Click += new System.EventHandler(this.dragAndDropToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(585, 654);
            this.Controls.Add(this.tbmess);
            this.Controls.Add(this.lvTrad);
            this.Controls.Add(this.radioBtnEngRom);
            this.Controls.Add(this.radioBtnRomEng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTraducere);
            this.Controls.Add(this.tbTrad);
            this.Controls.Add(this.lblCuvant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCuvant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDefinitie);
            this.Controls.Add(this.btnAdaugaCuvant);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAdaugaCuvant;
        private System.Windows.Forms.TextBox tbDefinitie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCuvant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblCuvant;
        private System.Windows.Forms.TextBox tbTrad;
        private System.Windows.Forms.Label lblTraducere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtnRomEng;
        private System.Windows.Forms.RadioButton radioBtnEngRom;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficCuvinteToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem cuvinteToolStripMenuItem;
        private System.Windows.Forms.TextBox tbmess;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader CuvNec;
        private System.Windows.Forms.ColumnHeader CuvTrad;
        private System.Windows.Forms.ColumnHeader Definitie;
        private System.Windows.Forms.ListView lvTrad;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dragAndDropToolStripMenuItem;
    }
}

