
namespace Dictionar2
{
    partial class Retrieve
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
            this.lbCuvDB = new System.Windows.Forms.Label();
            this.lbTradDB = new System.Windows.Forms.Label();
            this.lbDefinitieDB = new System.Windows.Forms.Label();
            this.tbCuvantDB = new System.Windows.Forms.TextBox();
            this.tbTradDB = new System.Windows.Forms.TextBox();
            this.tbDefinitieDB = new System.Windows.Forms.TextBox();
            this.btnCautaDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCuvDB
            // 
            this.lbCuvDB.AutoSize = true;
            this.lbCuvDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuvDB.Location = new System.Drawing.Point(41, 82);
            this.lbCuvDB.Name = "lbCuvDB";
            this.lbCuvDB.Size = new System.Drawing.Size(61, 20);
            this.lbCuvDB.TabIndex = 0;
            this.lbCuvDB.Text = "Cuvant";
            // 
            // lbTradDB
            // 
            this.lbTradDB.AutoSize = true;
            this.lbTradDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTradDB.Location = new System.Drawing.Point(41, 126);
            this.lbTradDB.Name = "lbTradDB";
            this.lbTradDB.Size = new System.Drawing.Size(85, 20);
            this.lbTradDB.TabIndex = 1;
            this.lbTradDB.Text = "Traducere";
            // 
            // lbDefinitieDB
            // 
            this.lbDefinitieDB.AutoSize = true;
            this.lbDefinitieDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefinitieDB.Location = new System.Drawing.Point(41, 172);
            this.lbDefinitieDB.Name = "lbDefinitieDB";
            this.lbDefinitieDB.Size = new System.Drawing.Size(71, 20);
            this.lbDefinitieDB.TabIndex = 2;
            this.lbDefinitieDB.Text = "Definitie";
            // 
            // tbCuvantDB
            // 
            this.tbCuvantDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuvantDB.Location = new System.Drawing.Point(147, 75);
            this.tbCuvantDB.Name = "tbCuvantDB";
            this.tbCuvantDB.Size = new System.Drawing.Size(263, 27);
            this.tbCuvantDB.TabIndex = 3;
            // 
            // tbTradDB
            // 
            this.tbTradDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTradDB.Location = new System.Drawing.Point(147, 123);
            this.tbTradDB.Name = "tbTradDB";
            this.tbTradDB.Size = new System.Drawing.Size(263, 27);
            this.tbTradDB.TabIndex = 4;
            // 
            // tbDefinitieDB
            // 
            this.tbDefinitieDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefinitieDB.Location = new System.Drawing.Point(147, 169);
            this.tbDefinitieDB.Multiline = true;
            this.tbDefinitieDB.Name = "tbDefinitieDB";
            this.tbDefinitieDB.Size = new System.Drawing.Size(263, 124);
            this.tbDefinitieDB.TabIndex = 5;
            // 
            // btnCautaDB
            // 
            this.btnCautaDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautaDB.Location = new System.Drawing.Point(220, 334);
            this.btnCautaDB.Name = "btnCautaDB";
            this.btnCautaDB.Size = new System.Drawing.Size(93, 37);
            this.btnCautaDB.TabIndex = 6;
            this.btnCautaDB.Text = "Cauta";
            this.btnCautaDB.UseVisualStyleBackColor = true;
            this.btnCautaDB.Click += new System.EventHandler(this.btnCautaDB_Click);
            // 
            // Retrieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 430);
            this.Controls.Add(this.btnCautaDB);
            this.Controls.Add(this.tbDefinitieDB);
            this.Controls.Add(this.tbTradDB);
            this.Controls.Add(this.tbCuvantDB);
            this.Controls.Add(this.lbDefinitieDB);
            this.Controls.Add(this.lbTradDB);
            this.Controls.Add(this.lbCuvDB);
            this.Name = "Retrieve";
            this.Text = "DataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCuvDB;
        private System.Windows.Forms.Label lbTradDB;
        private System.Windows.Forms.Label lbDefinitieDB;
        private System.Windows.Forms.TextBox tbCuvantDB;
        private System.Windows.Forms.TextBox tbTradDB;
        private System.Windows.Forms.TextBox tbDefinitieDB;
        private System.Windows.Forms.Button btnCautaDB;
    }
}