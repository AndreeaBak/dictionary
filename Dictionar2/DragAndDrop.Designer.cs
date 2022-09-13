
namespace Dictionar2
{
    partial class DragAndDrop
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
            this.tbCuvForm3 = new System.Windows.Forms.TextBox();
            this.btnAdaugaForm3 = new System.Windows.Forms.Button();
            this.Cuvant = new System.Windows.Forms.ListBox();
            this.Traducere = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCuvForm3
            // 
            this.tbCuvForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuvForm3.Location = new System.Drawing.Point(78, 36);
            this.tbCuvForm3.Name = "tbCuvForm3";
            this.tbCuvForm3.Size = new System.Drawing.Size(159, 27);
            this.tbCuvForm3.TabIndex = 0;
            // 
            // btnAdaugaForm3
            // 
            this.btnAdaugaForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaForm3.Location = new System.Drawing.Point(78, 77);
            this.btnAdaugaForm3.Name = "btnAdaugaForm3";
            this.btnAdaugaForm3.Size = new System.Drawing.Size(159, 36);
            this.btnAdaugaForm3.TabIndex = 1;
            this.btnAdaugaForm3.Text = "Adauga";
            this.btnAdaugaForm3.UseVisualStyleBackColor = true;
            this.btnAdaugaForm3.Click += new System.EventHandler(this.btnAdaugaForm3_Click);
            // 
            // Cuvant
            // 
            this.Cuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuvant.FormattingEnabled = true;
            this.Cuvant.ItemHeight = 20;
            this.Cuvant.Location = new System.Drawing.Point(78, 181);
            this.Cuvant.Name = "Cuvant";
            this.Cuvant.Size = new System.Drawing.Size(237, 204);
            this.Cuvant.TabIndex = 2;
            this.Cuvant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cuvant_MouseDown);
            // 
            // Traducere
            // 
            this.Traducere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traducere.FormattingEnabled = true;
            this.Traducere.ItemHeight = 20;
            this.Traducere.Location = new System.Drawing.Point(368, 181);
            this.Traducere.Name = "Traducere";
            this.Traducere.Size = new System.Drawing.Size(237, 204);
            this.Traducere.TabIndex = 3;
            this.Traducere.DragDrop += new System.Windows.Forms.DragEventHandler(this.Traducere_DragDrop);
            this.Traducere.DragEnter += new System.Windows.Forms.DragEventHandler(this.Traducere_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuvant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Traducere";
            // 
            // DragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Traducere);
            this.Controls.Add(this.Cuvant);
            this.Controls.Add(this.btnAdaugaForm3);
            this.Controls.Add(this.tbCuvForm3);
            this.Name = "DragAndDrop";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCuvForm3;
        private System.Windows.Forms.Button btnAdaugaForm3;
        private System.Windows.Forms.ListBox Cuvant;
        private System.Windows.Forms.ListBox Traducere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}