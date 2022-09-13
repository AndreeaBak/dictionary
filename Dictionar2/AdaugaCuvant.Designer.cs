
namespace Dictionar2
{
    partial class AdaugaCuvant
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
            this.tbAdaugaDefinitie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdaugaCuvant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdaugaCuvant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAdaugaDefinitie
            // 
            this.tbAdaugaDefinitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdaugaDefinitie.Location = new System.Drawing.Point(103, 60);
            this.tbAdaugaDefinitie.Name = "tbAdaugaDefinitie";
            this.tbAdaugaDefinitie.Size = new System.Drawing.Size(254, 27);
            this.tbAdaugaDefinitie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Definitie:";
            // 
            // btnAdaugaCuvant
            // 
            this.btnAdaugaCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaCuvant.Location = new System.Drawing.Point(374, 54);
            this.btnAdaugaCuvant.Name = "btnAdaugaCuvant";
            this.btnAdaugaCuvant.Size = new System.Drawing.Size(99, 33);
            this.btnAdaugaCuvant.TabIndex = 2;
            this.btnAdaugaCuvant.Text = "Adauga";
            this.btnAdaugaCuvant.UseVisualStyleBackColor = true;
            this.btnAdaugaCuvant.Click += new System.EventHandler(this.btnAdaugaCuvant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Traducere:";
            // 
            // tbAdaugaCuvant
            // 
            this.tbAdaugaCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdaugaCuvant.Location = new System.Drawing.Point(103, 23);
            this.tbAdaugaCuvant.Name = "tbAdaugaCuvant";
            this.tbAdaugaCuvant.Size = new System.Drawing.Size(254, 27);
            this.tbAdaugaCuvant.TabIndex = 4;
            // 
            // AdaugaCuvant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 120);
            this.Controls.Add(this.tbAdaugaCuvant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdaugaCuvant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdaugaDefinitie);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdaugaCuvant";
            this.ShowIcon = false;
            this.Text = "AdaugaCuvant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdaugaDefinitie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdaugaCuvant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdaugaCuvant;
    }
}