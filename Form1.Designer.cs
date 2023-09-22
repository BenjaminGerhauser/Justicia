
namespace Justicia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstProfugos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profugos";
            // 
            // lstProfugos
            // 
            this.lstProfugos.FormattingEnabled = true;
            this.lstProfugos.Location = new System.Drawing.Point(23, 59);
            this.lstProfugos.Name = "lstProfugos";
            this.lstProfugos.Size = new System.Drawing.Size(238, 342);
            this.lstProfugos.TabIndex = 1;
            this.lstProfugos.SelectedIndexChanged += new System.EventHandler(this.lstProfugos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foto";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(300, 59);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(188, 173);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 3;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alias";
            // 
            // lblAlias
            // 
            this.lblAlias.BackColor = System.Drawing.Color.Black;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlias.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlias.Location = new System.Drawing.Point(297, 289);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(193, 28);
            this.lblAlias.TabIndex = 5;
            this.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profugo desde";
            // 
            // lblDesde
            // 
            this.lblDesde.BackColor = System.Drawing.Color.Black;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.Yellow;
            this.lblDesde.Location = new System.Drawing.Point(297, 374);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(193, 27);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstProfugos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Profugos de la justicia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProfugos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDesde;
    }
}

