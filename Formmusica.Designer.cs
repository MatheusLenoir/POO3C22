namespace POO3C22
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
            this.txt_gravadora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_musica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NomeMusica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.GridMusicas = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridMusicas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gravadora
            // 
            this.txt_gravadora.Location = new System.Drawing.Point(59, 122);
            this.txt_gravadora.Name = "txt_gravadora";
            this.txt_gravadora.Size = new System.Drawing.Size(157, 20);
            this.txt_gravadora.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gravadora :";
            // 
            // txt_CD
            // 
            this.txt_CD.Location = new System.Drawing.Point(59, 189);
            this.txt_CD.Name = "txt_CD";
            this.txt_CD.Size = new System.Drawing.Size(157, 20);
            this.txt_CD.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CD :";
            // 
            // txt_musica
            // 
            this.txt_musica.Location = new System.Drawing.Point(59, 269);
            this.txt_musica.Name = "txt_musica";
            this.txt_musica.Size = new System.Drawing.Size(157, 20);
            this.txt_musica.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Musica :";
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(264, 156);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(157, 20);
            this.txt_Autor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autor :";
            // 
            // txt_NomeMusica
            // 
            this.txt_NomeMusica.Location = new System.Drawing.Point(264, 230);
            this.txt_NomeMusica.Name = "txt_NomeMusica";
            this.txt_NomeMusica.Size = new System.Drawing.Size(157, 20);
            this.txt_NomeMusica.TabIndex = 12;
            this.txt_NomeMusica.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome da Musica :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = " GRAVADORA ";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(107, 346);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(267, 39);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Cadastrar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // GridMusicas
            // 
            this.GridMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMusicas.Location = new System.Drawing.Point(481, 34);
            this.GridMusicas.Name = "GridMusicas";
            this.GridMusicas.Size = new System.Drawing.Size(302, 283);
            this.GridMusicas.TabIndex = 15;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(558, 346);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(155, 36);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(829, 421);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.GridMusicas);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_NomeMusica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_musica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gravadora);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMusicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_gravadora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_musica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NomeMusica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView GridMusicas;
        private System.Windows.Forms.Button btnDeletar;
    }
}

