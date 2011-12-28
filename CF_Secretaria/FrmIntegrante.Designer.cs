namespace CF_Secretaria
{
    partial class FrmIntegrante
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnEventosList = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grEventos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnFormEventos = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnEventosList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).BeginInit();
            this.pnFormEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciamento Eventos";
            // 
            // pnEventosList
            // 
            this.pnEventosList.Controls.Add(this.btnExcluir);
            this.pnEventosList.Controls.Add(this.btnEditar);
            this.pnEventosList.Controls.Add(this.btnNovo);
            this.pnEventosList.Controls.Add(this.grEventos);
            this.pnEventosList.Location = new System.Drawing.Point(14, 69);
            this.pnEventosList.Name = "pnEventosList";
            this.pnEventosList.Size = new System.Drawing.Size(1186, 413);
            this.pnEventosList.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1083, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1083, 195);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(1083, 131);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(87, 23);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grEventos
            // 
            this.grEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grEventos.Location = new System.Drawing.Point(16, 27);
            this.grEventos.Name = "grEventos";
            this.grEventos.Size = new System.Drawing.Size(1035, 358);
            this.grEventos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 21);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(457, 354);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(162, 39);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(626, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pnFormEventos
            // 
            this.pnFormEventos.Controls.Add(this.textBox5);
            this.pnFormEventos.Controls.Add(this.label7);
            this.pnFormEventos.Controls.Add(this.textBox4);
            this.pnFormEventos.Controls.Add(this.label6);
            this.pnFormEventos.Controls.Add(this.textBox3);
            this.pnFormEventos.Controls.Add(this.label5);
            this.pnFormEventos.Controls.Add(this.textBox2);
            this.pnFormEventos.Controls.Add(this.label4);
            this.pnFormEventos.Controls.Add(this.textBox1);
            this.pnFormEventos.Controls.Add(this.btnCancelar);
            this.pnFormEventos.Controls.Add(this.btnSalvar);
            this.pnFormEventos.Controls.Add(this.label3);
            this.pnFormEventos.Controls.Add(this.txtNome);
            this.pnFormEventos.Controls.Add(this.label2);
            this.pnFormEventos.Location = new System.Drawing.Point(14, 68);
            this.pnFormEventos.Name = "pnFormEventos";
            this.pnFormEventos.Size = new System.Drawing.Size(1186, 410);
            this.pnFormEventos.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 21);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 21);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 21);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 21);
            this.textBox4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefone";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(30, 269);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(201, 21);
            this.textBox5.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone";
            // 
            // FrmIntegrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnFormEventos);
            this.Controls.Add(this.pnEventosList);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmIntegrante";
            this.Text = "FrmIntegrante";
            this.pnEventosList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).EndInit();
            this.pnFormEventos.ResumeLayout(false);
            this.pnFormEventos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnEventosList;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grEventos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnFormEventos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;

    }
}