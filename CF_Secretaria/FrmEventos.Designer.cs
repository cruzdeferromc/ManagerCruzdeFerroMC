namespace CF_Secretaria
{
    partial class FrmEvento
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
            this.pnEventosList = new System.Windows.Forms.Panel();
            this.pnFormEventos = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotoclube = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grEventos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnEventosList.SuspendLayout();
            this.pnFormEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEventosList
            // 
            this.pnEventosList.Controls.Add(this.btnExcluir);
            this.pnEventosList.Controls.Add(this.btnEditar);
            this.pnEventosList.Controls.Add(this.btnNovo);
            this.pnEventosList.Controls.Add(this.grEventos);
            this.pnEventosList.Controls.Add(this.pnFormEventos);
            this.pnEventosList.Location = new System.Drawing.Point(12, 76);
            this.pnEventosList.Name = "pnEventosList";
            this.pnEventosList.Size = new System.Drawing.Size(1017, 413);
            this.pnEventosList.TabIndex = 0;
            // 
            // pnFormEventos
            // 
            this.pnFormEventos.Controls.Add(this.btnCancelar);
            this.pnFormEventos.Controls.Add(this.btnSalvar);
            this.pnFormEventos.Controls.Add(this.dtFinal);
            this.pnFormEventos.Controls.Add(this.label4);
            this.pnFormEventos.Controls.Add(this.dtInicio);
            this.pnFormEventos.Controls.Add(this.label3);
            this.pnFormEventos.Controls.Add(this.txtMotoclube);
            this.pnFormEventos.Controls.Add(this.label2);
            this.pnFormEventos.Location = new System.Drawing.Point(3, 3);
            this.pnFormEventos.Name = "pnFormEventos";
            this.pnFormEventos.Size = new System.Drawing.Size(1017, 410);
            this.pnFormEventos.TabIndex = 2;
            this.pnFormEventos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFormEventos_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(537, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(392, 354);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(139, 39);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Location = new System.Drawing.Point(32, 173);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(200, 21);
            this.dtFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Final";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(29, 117);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 21);
            this.dtInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Inicio";
            // 
            // txtMotoclube
            // 
            this.txtMotoclube.Location = new System.Drawing.Point(26, 54);
            this.txtMotoclube.Name = "txtMotoclube";
            this.txtMotoclube.Size = new System.Drawing.Size(353, 21);
            this.txtMotoclube.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MotoClube";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(928, 252);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(928, 195);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(928, 131);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grEventos
            // 
            this.grEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grEventos.Location = new System.Drawing.Point(14, 27);
            this.grEventos.Name = "grEventos";
            this.grEventos.Size = new System.Drawing.Size(887, 358);
            this.grEventos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciamento Eventos";
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnEventosList);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmEvento";
            this.Text = "Gerenciador de Eventos";
            this.pnEventosList.ResumeLayout(false);
            this.pnFormEventos.ResumeLayout(false);
            this.pnFormEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnEventosList;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnFormEventos;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotoclube;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;


    }
}