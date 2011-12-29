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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.abaList = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grEventos = new System.Windows.Forms.DataGridView();
            this.abaForm = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotoclube = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.abaList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).BeginInit();
            this.abaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "GERENCIAMENTO EVENTOS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.abaList);
            this.tabControl1.Controls.Add(this.abaForm);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 470);
            this.tabControl1.TabIndex = 2;
            // 
            // abaList
            // 
            this.abaList.Controls.Add(this.btnExcluir);
            this.abaList.Controls.Add(this.btnEditar);
            this.abaList.Controls.Add(this.btnNovo);
            this.abaList.Controls.Add(this.grEventos);
            this.abaList.Location = new System.Drawing.Point(4, 22);
            this.abaList.Name = "abaList";
            this.abaList.Padding = new System.Windows.Forms.Padding(3);
            this.abaList.Size = new System.Drawing.Size(681, 444);
            this.abaList.TabIndex = 0;
            this.abaList.Text = "Eventos";
            this.abaList.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(532, 264);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(532, 207);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(532, 143);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grEventos
            // 
            this.grEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grEventos.Location = new System.Drawing.Point(16, 52);
            this.grEventos.Name = "grEventos";
            this.grEventos.Size = new System.Drawing.Size(449, 351);
            this.grEventos.TabIndex = 9;
            // 
            // abaForm
            // 
            this.abaForm.Controls.Add(this.btnCancelar);
            this.abaForm.Controls.Add(this.btnSalvar);
            this.abaForm.Controls.Add(this.dtFinal);
            this.abaForm.Controls.Add(this.label4);
            this.abaForm.Controls.Add(this.dtInicio);
            this.abaForm.Controls.Add(this.label3);
            this.abaForm.Controls.Add(this.txtMotoclube);
            this.abaForm.Controls.Add(this.label2);
            this.abaForm.Location = new System.Drawing.Point(4, 22);
            this.abaForm.Name = "abaForm";
            this.abaForm.Padding = new System.Windows.Forms.Padding(3);
            this.abaForm.Size = new System.Drawing.Size(681, 444);
            this.abaForm.TabIndex = 1;
            this.abaForm.Text = "Form";
            this.abaForm.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(356, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 39);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(157, 364);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(139, 39);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Location = new System.Drawing.Point(27, 183);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(200, 21);
            this.dtFinal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data Final";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(24, 127);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 21);
            this.dtInicio.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Inicio";
            // 
            // txtMotoclube
            // 
            this.txtMotoclube.Location = new System.Drawing.Point(21, 64);
            this.txtMotoclube.Name = "txtMotoclube";
            this.txtMotoclube.Size = new System.Drawing.Size(353, 21);
            this.txtMotoclube.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MotoClube";
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 539);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmEvento";
            this.Text = "Gerenciador de Eventos";
            this.tabControl1.ResumeLayout(false);
            this.abaList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).EndInit();
            this.abaForm.ResumeLayout(false);
            this.abaForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage abaList;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grEventos;
        private System.Windows.Forms.TabPage abaForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotoclube;
        private System.Windows.Forms.Label label2;


    }
}