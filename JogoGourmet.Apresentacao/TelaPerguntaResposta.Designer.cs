namespace JogoGourmet.Apresentacao
{
    partial class frmTelaPerguntaResposta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPerguntaResposta));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPerguntaResposta = new System.Windows.Forms.TextBox();
            this.lblPerguntaResposta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(130, 71);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 71);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPerguntaResposta
            // 
            this.txtPerguntaResposta.Location = new System.Drawing.Point(119, 42);
            this.txtPerguntaResposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerguntaResposta.Name = "txtPerguntaResposta";
            this.txtPerguntaResposta.Size = new System.Drawing.Size(231, 22);
            this.txtPerguntaResposta.TabIndex = 2;
            // 
            // lblPerguntaResposta
            // 
            this.lblPerguntaResposta.AutoSize = true;
            this.lblPerguntaResposta.Location = new System.Drawing.Point(60, 13);
            this.lblPerguntaResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerguntaResposta.Name = "lblPerguntaResposta";
            this.lblPerguntaResposta.Size = new System.Drawing.Size(120, 16);
            this.lblPerguntaResposta.TabIndex = 3;
            this.lblPerguntaResposta.Text = "PerguntaResposta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaPerguntaResposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 112);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPerguntaResposta);
            this.Controls.Add(this.txtPerguntaResposta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTelaPerguntaResposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPerguntaResposta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtPerguntaResposta;
        private System.Windows.Forms.Label lblPerguntaResposta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}