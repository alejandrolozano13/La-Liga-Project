namespace LaLiga
{
    partial class TelaDeOpcoes
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
            this.btnAdicionarTime = new System.Windows.Forms.Button();
            this.btnAoAdicionarJogador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionarTime
            // 
            this.btnAdicionarTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdicionarTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTime.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarTime.Location = new System.Drawing.Point(308, 142);
            this.btnAdicionarTime.Name = "btnAdicionarTime";
            this.btnAdicionarTime.Size = new System.Drawing.Size(195, 61);
            this.btnAdicionarTime.TabIndex = 0;
            this.btnAdicionarTime.Text = "Adicionar Time";
            this.btnAdicionarTime.UseVisualStyleBackColor = false;
            this.btnAdicionarTime.Click += new System.EventHandler(this.btnAoAdicionarTime);
            // 
            // btnAoAdicionarJogador
            // 
            this.btnAoAdicionarJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAoAdicionarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAoAdicionarJogador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAoAdicionarJogador.Location = new System.Drawing.Point(308, 250);
            this.btnAoAdicionarJogador.Name = "btnAoAdicionarJogador";
            this.btnAoAdicionarJogador.Size = new System.Drawing.Size(195, 61);
            this.btnAoAdicionarJogador.TabIndex = 1;
            this.btnAoAdicionarJogador.Text = "Adicionar Jogador";
            this.btnAoAdicionarJogador.UseVisualStyleBackColor = false;
            this.btnAoAdicionarJogador.Click += new System.EventHandler(this.btnAdicionarJogador);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(326, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú - Opções";
            // 
            // TelaDeOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAoAdicionarJogador);
            this.Controls.Add(this.btnAdicionarTime);
            this.Name = "TelaDeOpcoes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarTime;
        private System.Windows.Forms.Button btnAoAdicionarJogador;
        private System.Windows.Forms.Label label1;
    }
}