namespace CF_Secretaria
{
    partial class FrmFaccao
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.grEventos = new System.Windows.Forms.DataGridView();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.abaList = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.abaForm = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckPossuiSede = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).BeginInit();
            this.tabControl.SuspendLayout();
            this.abaList.SuspendLayout();
            this.abaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(451, 131);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(122, 38);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grEventos
            // 
            this.grEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.grEventos.BackgroundColor = System.Drawing.Color.White;
            this.grEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grEventos.GridColor = System.Drawing.Color.White;
            this.grEventos.Location = new System.Drawing.Point(-5, -1);
            this.grEventos.Margin = new System.Windows.Forms.Padding(2);
            this.grEventos.MultiSelect = false;
            this.grEventos.Name = "grEventos";
            this.grEventos.ReadOnly = true;
            this.grEventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grEventos.Size = new System.Drawing.Size(451, 405);
            this.grEventos.TabIndex = 9;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(13, 126);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(260, 20);
            this.txtEstado.TabIndex = 25;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(451, 220);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 38);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.abaList);
            this.tabControl.Controls.Add(this.abaForm);
            this.tabControl.Location = new System.Drawing.Point(10, 54);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(590, 434);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 8;
            // 
            // abaList
            // 
            this.abaList.Controls.Add(this.btnExcluir);
            this.abaList.Controls.Add(this.btnEditar);
            this.abaList.Controls.Add(this.btnNovo);
            this.abaList.Controls.Add(this.grEventos);
            this.abaList.Location = new System.Drawing.Point(4, 22);
            this.abaList.Margin = new System.Windows.Forms.Padding(2);
            this.abaList.Name = "abaList";
            this.abaList.Padding = new System.Windows.Forms.Padding(2);
            this.abaList.Size = new System.Drawing.Size(582, 408);
            this.abaList.TabIndex = 0;
            this.abaList.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(451, 175);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // abaForm
            // 
            this.abaForm.Controls.Add(this.ckPossuiSede);
            this.abaForm.Controls.Add(this.label3);
            this.abaForm.Controls.Add(this.txtEstado);
            this.abaForm.Controls.Add(this.label10);
            this.abaForm.Controls.Add(this.txtCep);
            this.abaForm.Controls.Add(this.label9);
            this.abaForm.Controls.Add(this.txtLogradouro);
            this.abaForm.Controls.Add(this.label8);
            this.abaForm.Controls.Add(this.txtCidade);
            this.abaForm.Controls.Add(this.label7);
            this.abaForm.Controls.Add(this.btnCancelar);
            this.abaForm.Controls.Add(this.btnSalvar);
            this.abaForm.Controls.Add(this.txtEmail);
            this.abaForm.Controls.Add(this.label2);
            this.abaForm.Location = new System.Drawing.Point(4, 22);
            this.abaForm.Margin = new System.Windows.Forms.Padding(2);
            this.abaForm.Name = "abaForm";
            this.abaForm.Padding = new System.Windows.Forms.Padding(2);
            this.abaForm.Size = new System.Drawing.Size(582, 408);
            this.abaForm.TabIndex = 1;
            this.abaForm.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(297, 126);
            this.txtCep.Margin = new System.Windows.Forms.Padding(2);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(260, 20);
            this.txtCep.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "CEP";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(296, 89);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(260, 20);
            this.txtLogradouro.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Logradouro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(296, 52);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(260, 20);
            this.txtCidade.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(317, 335);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 36);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(129, 335);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 36);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 52);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modulo de gerenciamento de facções, controle de cadastro, edições e exclusão de f" +
                "acções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "GERENCIAMENTO FACÇÕES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Possui Sede?";
            // 
            // ckPossuiSede
            // 
            this.ckPossuiSede.AutoSize = true;
            this.ckPossuiSede.Location = new System.Drawing.Point(16, 91);
            this.ckPossuiSede.Name = "ckPossuiSede";
            this.ckPossuiSede.Size = new System.Drawing.Size(43, 17);
            this.ckPossuiSede.TabIndex = 27;
            this.ckPossuiSede.Text = "Sim";
            this.ckPossuiSede.UseVisualStyleBackColor = true;
            // 
            // FrmFaccao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 490);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FrmFaccao";
            this.Text = "FrmFaccao";
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.abaList.ResumeLayout(false);
            this.abaForm.ResumeLayout(false);
            this.abaForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grEventos;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage abaList;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TabPage abaForm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckPossuiSede;

    }
}