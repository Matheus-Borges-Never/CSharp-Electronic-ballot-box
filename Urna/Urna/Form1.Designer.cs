namespace Urna
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptbCandidatos = new System.Windows.Forms.PictureBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnNulo = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCandidato = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCandidatos
            // 
            this.ptbCandidatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbCandidatos.BackgroundImage")));
            this.ptbCandidatos.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ptbCandidatos.Location = new System.Drawing.Point(53, 86);
            this.ptbCandidatos.Name = "ptbCandidatos";
            this.ptbCandidatos.Size = new System.Drawing.Size(224, 211);
            this.ptbCandidatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCandidatos.TabIndex = 0;
            this.ptbCandidatos.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(325, 86);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(217, 40);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress_1);
            // 
            // btnNulo
            // 
            this.btnNulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNulo.Location = new System.Drawing.Point(325, 262);
            this.btnNulo.Name = "btnNulo";
            this.btnNulo.Size = new System.Drawing.Size(82, 35);
            this.btnNulo.TabIndex = 2;
            this.btnNulo.Text = "Nulo";
            this.btnNulo.UseVisualStyleBackColor = false;
            this.btnNulo.Click += new System.EventHandler(this.btnNulo_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBranco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBranco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(460, 262);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(82, 35);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Branco";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 10;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(325, 212);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(217, 44);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // lblCandidato
            // 
            this.lblCandidato.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidato.Location = new System.Drawing.Point(49, 330);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(228, 32);
            this.lblCandidato.TabIndex = 5;
            this.lblCandidato.Text = "Vote";
            this.lblCandidato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblStatus.Location = new System.Drawing.Point(321, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(221, 32);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 478);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCandidato);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNulo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.ptbCandidatos);
            this.Name = "Form1";
            this.Text = "Urna TI 41";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCandidatos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnNulo;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.Label lblStatus;
    }
}

