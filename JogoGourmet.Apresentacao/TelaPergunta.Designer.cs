namespace JogoGourmet.Apresentacao
{
    partial class frmTelaPergunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPergunta));
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.lblPerguntaPronta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(141, 69);
            this.btnSim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(67, 31);
            this.btnSim.TabIndex = 0;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(216, 69);
            this.btnNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(67, 31);
            this.btnNao.TabIndex = 1;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // lblPerguntaPronta
            // 
            this.lblPerguntaPronta.AutoSize = true;
            this.lblPerguntaPronta.Location = new System.Drawing.Point(88, 34);
            this.lblPerguntaPronta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerguntaPronta.Name = "lblPerguntaPronta";
            this.lblPerguntaPronta.Size = new System.Drawing.Size(100, 16);
            this.lblPerguntaPronta.TabIndex = 2;
            this.lblPerguntaPronta.Text = "PerguntaPronta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 112);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPerguntaPronta);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTelaPergunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPergunta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Label lblPerguntaPronta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}