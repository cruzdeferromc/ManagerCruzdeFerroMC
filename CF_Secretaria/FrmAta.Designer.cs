namespace CF_Secretaria
{
    partial class FrmAta
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbList = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grEventos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbControlNew = new System.Windows.Forms.TabControl();
            this.tbPageChamada = new System.Windows.Forms.TabPage();
            this.cklIntegrantes = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFaccao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAvisos = new System.Windows.Forms.TabPage();
            this.btnAvisoExcluir = new System.Windows.Forms.Button();
            this.btnAvisoCancelar = new System.Windows.Forms.Button();
            this.btnAvisoSalvar = new System.Windows.Forms.Button();
            this.btnAvisoEditar = new System.Windows.Forms.Button();
            this.btnAvisoNovo = new System.Windows.Forms.Button();
            this.grAvisos = new System.Windows.Forms.DataGridView();
            this.rtAvisos = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEventos = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFinal = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grEventosPassados = new System.Windows.Forms.DataGridView();
            this.grEventosProximos = new System.Windows.Forms.DataGridView();
            this.btnGerarAta = new System.Windows.Forms.Button();
            this.rtAtaFinal = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtReuniao = new System.Windows.Forms.DateTimePicker();
            this.tbControl.SuspendLayout();
            this.tbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tbControlNew.SuspendLayout();
            this.tbPageChamada.SuspendLayout();
            this.tbAvisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grAvisos)).BeginInit();
            this.tbEventos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEventosPassados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grEventosProximos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbList);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Location = new System.Drawing.Point(12, 61);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(1014, 662);
            this.tbControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbControl.TabIndex = 0;
            // 
            // tbList
            // 
            this.tbList.Controls.Add(this.btnExcluir);
            this.tbList.Controls.Add(this.btnEditar);
            this.tbList.Controls.Add(this.btnNovo);
            this.tbList.Controls.Add(this.grEventos);
            this.tbList.Location = new System.Drawing.Point(4, 22);
            this.tbList.Name = "tbList";
            this.tbList.Padding = new System.Windows.Forms.Padding(3);
            this.tbList.Size = new System.Drawing.Size(1006, 636);
            this.tbList.TabIndex = 0;
            this.tbList.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(810, 371);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(191, 71);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(810, 270);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(191, 71);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(810, 167);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(191, 71);
            this.btnNovo.TabIndex = 16;
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
            this.grEventos.Location = new System.Drawing.Point(5, 5);
            this.grEventos.Margin = new System.Windows.Forms.Padding(2);
            this.grEventos.MultiSelect = false;
            this.grEventos.Name = "grEventos";
            this.grEventos.ReadOnly = true;
            this.grEventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grEventos.Size = new System.Drawing.Size(801, 626);
            this.grEventos.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbControlNew);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbControlNew
            // 
            this.tbControlNew.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbControlNew.Controls.Add(this.tbPageChamada);
            this.tbControlNew.Controls.Add(this.tbAvisos);
            this.tbControlNew.Controls.Add(this.tbEventos);
            this.tbControlNew.Controls.Add(this.tbFinal);
            this.tbControlNew.Location = new System.Drawing.Point(6, 6);
            this.tbControlNew.Name = "tbControlNew";
            this.tbControlNew.SelectedIndex = 0;
            this.tbControlNew.Size = new System.Drawing.Size(994, 624);
            this.tbControlNew.TabIndex = 0;
            // 
            // tbPageChamada
            // 
            this.tbPageChamada.Controls.Add(this.dtReuniao);
            this.tbPageChamada.Controls.Add(this.label6);
            this.tbPageChamada.Controls.Add(this.cklIntegrantes);
            this.tbPageChamada.Controls.Add(this.label3);
            this.tbPageChamada.Controls.Add(this.cbFaccao);
            this.tbPageChamada.Controls.Add(this.label2);
            this.tbPageChamada.Location = new System.Drawing.Point(4, 25);
            this.tbPageChamada.Name = "tbPageChamada";
            this.tbPageChamada.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageChamada.Size = new System.Drawing.Size(986, 595);
            this.tbPageChamada.TabIndex = 0;
            this.tbPageChamada.Text = "ATA - CHAMADA";
            this.tbPageChamada.UseVisualStyleBackColor = true;
            // 
            // cklIntegrantes
            // 
            this.cklIntegrantes.FormattingEnabled = true;
            this.cklIntegrantes.Location = new System.Drawing.Point(23, 81);
            this.cklIntegrantes.Name = "cklIntegrantes";
            this.cklIntegrantes.Size = new System.Drawing.Size(939, 484);
            this.cklIntegrantes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Integrantes";
            // 
            // cbFaccao
            // 
            this.cbFaccao.FormattingEnabled = true;
            this.cbFaccao.Location = new System.Drawing.Point(20, 37);
            this.cbFaccao.Name = "cbFaccao";
            this.cbFaccao.Size = new System.Drawing.Size(721, 21);
            this.cbFaccao.TabIndex = 1;
            this.cbFaccao.SelectedIndexChanged += new System.EventHandler(this.cbFaccao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Facção";
            // 
            // tbAvisos
            // 
            this.tbAvisos.Controls.Add(this.btnAvisoExcluir);
            this.tbAvisos.Controls.Add(this.btnAvisoCancelar);
            this.tbAvisos.Controls.Add(this.btnAvisoSalvar);
            this.tbAvisos.Controls.Add(this.btnAvisoEditar);
            this.tbAvisos.Controls.Add(this.btnAvisoNovo);
            this.tbAvisos.Controls.Add(this.grAvisos);
            this.tbAvisos.Controls.Add(this.rtAvisos);
            this.tbAvisos.Controls.Add(this.label4);
            this.tbAvisos.Location = new System.Drawing.Point(4, 25);
            this.tbAvisos.Name = "tbAvisos";
            this.tbAvisos.Padding = new System.Windows.Forms.Padding(3);
            this.tbAvisos.Size = new System.Drawing.Size(986, 595);
            this.tbAvisos.TabIndex = 1;
            this.tbAvisos.Text = "ATA - AVISOS";
            this.tbAvisos.UseVisualStyleBackColor = true;
            // 
            // btnAvisoExcluir
            // 
            this.btnAvisoExcluir.Location = new System.Drawing.Point(789, 530);
            this.btnAvisoExcluir.Name = "btnAvisoExcluir";
            this.btnAvisoExcluir.Size = new System.Drawing.Size(172, 60);
            this.btnAvisoExcluir.TabIndex = 7;
            this.btnAvisoExcluir.Text = "EXCLUIR";
            this.btnAvisoExcluir.UseVisualStyleBackColor = true;
            this.btnAvisoExcluir.Click += new System.EventHandler(this.btnAvisoExcluir_Click);
            // 
            // btnAvisoCancelar
            // 
            this.btnAvisoCancelar.Enabled = false;
            this.btnAvisoCancelar.Location = new System.Drawing.Point(597, 530);
            this.btnAvisoCancelar.Name = "btnAvisoCancelar";
            this.btnAvisoCancelar.Size = new System.Drawing.Size(172, 60);
            this.btnAvisoCancelar.TabIndex = 6;
            this.btnAvisoCancelar.Text = "CANCELAR";
            this.btnAvisoCancelar.UseVisualStyleBackColor = true;
            this.btnAvisoCancelar.Click += new System.EventHandler(this.btnAvisoCancelar_Click);
            // 
            // btnAvisoSalvar
            // 
            this.btnAvisoSalvar.Enabled = false;
            this.btnAvisoSalvar.Location = new System.Drawing.Point(405, 530);
            this.btnAvisoSalvar.Name = "btnAvisoSalvar";
            this.btnAvisoSalvar.Size = new System.Drawing.Size(172, 60);
            this.btnAvisoSalvar.TabIndex = 5;
            this.btnAvisoSalvar.Text = "SALVAR";
            this.btnAvisoSalvar.UseVisualStyleBackColor = true;
            this.btnAvisoSalvar.Click += new System.EventHandler(this.btnAvisoSalvar_Click);
            // 
            // btnAvisoEditar
            // 
            this.btnAvisoEditar.Location = new System.Drawing.Point(213, 530);
            this.btnAvisoEditar.Name = "btnAvisoEditar";
            this.btnAvisoEditar.Size = new System.Drawing.Size(172, 60);
            this.btnAvisoEditar.TabIndex = 4;
            this.btnAvisoEditar.Text = "EDITAR";
            this.btnAvisoEditar.UseVisualStyleBackColor = true;
            this.btnAvisoEditar.Click += new System.EventHandler(this.btnAvisoEditar_Click);
            // 
            // btnAvisoNovo
            // 
            this.btnAvisoNovo.Location = new System.Drawing.Point(21, 530);
            this.btnAvisoNovo.Name = "btnAvisoNovo";
            this.btnAvisoNovo.Size = new System.Drawing.Size(172, 60);
            this.btnAvisoNovo.TabIndex = 3;
            this.btnAvisoNovo.Text = "NOVO";
            this.btnAvisoNovo.UseVisualStyleBackColor = true;
            this.btnAvisoNovo.Click += new System.EventHandler(this.btnAvisoNovo_Click);
            // 
            // grAvisos
            // 
            this.grAvisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grAvisos.Location = new System.Drawing.Point(21, 162);
            this.grAvisos.Name = "grAvisos";
            this.grAvisos.Size = new System.Drawing.Size(941, 362);
            this.grAvisos.TabIndex = 2;
            // 
            // rtAvisos
            // 
            this.rtAvisos.Location = new System.Drawing.Point(21, 41);
            this.rtAvisos.Name = "rtAvisos";
            this.rtAvisos.ReadOnly = true;
            this.rtAvisos.Size = new System.Drawing.Size(941, 115);
            this.rtAvisos.TabIndex = 1;
            this.rtAvisos.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aviso";
            // 
            // tbEventos
            // 
            this.tbEventos.Controls.Add(this.groupBox2);
            this.tbEventos.Controls.Add(this.groupBox1);
            this.tbEventos.Location = new System.Drawing.Point(4, 25);
            this.tbEventos.Name = "tbEventos";
            this.tbEventos.Padding = new System.Windows.Forms.Padding(3);
            this.tbEventos.Size = new System.Drawing.Size(986, 595);
            this.tbEventos.TabIndex = 2;
            this.tbEventos.Text = "ATA - EVENTOS";
            this.tbEventos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grEventosProximos);
            this.groupBox2.Location = new System.Drawing.Point(17, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eventos - Proximos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grEventosPassados);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos - Passados";
            // 
            // tbFinal
            // 
            this.tbFinal.Controls.Add(this.rtAtaFinal);
            this.tbFinal.Controls.Add(this.btnGerarAta);
            this.tbFinal.Location = new System.Drawing.Point(4, 25);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Padding = new System.Windows.Forms.Padding(3);
            this.tbFinal.Size = new System.Drawing.Size(986, 595);
            this.tbFinal.TabIndex = 3;
            this.tbFinal.Text = "ATA - FINAL";
            this.tbFinal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Modulo de gerenciamento de atas, controle de cadastro, edições e exclusão de atas" +
                "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "GERENCIAMENTO ATA";
            // 
            // grEventosPassados
            // 
            this.grEventosPassados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grEventosPassados.Location = new System.Drawing.Point(6, 19);
            this.grEventosPassados.Name = "grEventosPassados";
            this.grEventosPassados.Size = new System.Drawing.Size(942, 250);
            this.grEventosPassados.TabIndex = 0;
            // 
            // grEventosProximos
            // 
            this.grEventosProximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grEventosProximos.Location = new System.Drawing.Point(6, 19);
            this.grEventosProximos.Name = "grEventosProximos";
            this.grEventosProximos.Size = new System.Drawing.Size(942, 246);
            this.grEventosProximos.TabIndex = 1;
            // 
            // btnGerarAta
            // 
            this.btnGerarAta.Location = new System.Drawing.Point(391, 554);
            this.btnGerarAta.Name = "btnGerarAta";
            this.btnGerarAta.Size = new System.Drawing.Size(200, 35);
            this.btnGerarAta.TabIndex = 0;
            this.btnGerarAta.Text = "GERAR ATA";
            this.btnGerarAta.UseVisualStyleBackColor = true;
            // 
            // rtAtaFinal
            // 
            this.rtAtaFinal.Location = new System.Drawing.Point(6, 6);
            this.rtAtaFinal.Name = "rtAtaFinal";
            this.rtAtaFinal.Size = new System.Drawing.Size(974, 542);
            this.rtAtaFinal.TabIndex = 1;
            this.rtAtaFinal.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(759, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data da Reunião";
            // 
            // dtReuniao
            // 
            this.dtReuniao.Location = new System.Drawing.Point(762, 34);
            this.dtReuniao.Name = "dtReuniao";
            this.dtReuniao.Size = new System.Drawing.Size(200, 20);
            this.dtReuniao.TabIndex = 5;
            // 
            // FrmAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 735);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbControl);
            this.Name = "FrmAta";
            this.Text = "FrmAta";
            this.tbControl.ResumeLayout(false);
            this.tbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grEventos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tbControlNew.ResumeLayout(false);
            this.tbPageChamada.ResumeLayout(false);
            this.tbPageChamada.PerformLayout();
            this.tbAvisos.ResumeLayout(false);
            this.tbAvisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grAvisos)).EndInit();
            this.tbEventos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tbFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grEventosPassados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grEventosProximos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grEventos;
        private System.Windows.Forms.TabControl tbControlNew;
        private System.Windows.Forms.TabPage tbPageChamada;
        private System.Windows.Forms.TabPage tbAvisos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbEventos;
        private System.Windows.Forms.TabPage tbFinal;
        private System.Windows.Forms.CheckedListBox cklIntegrantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFaccao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtAvisos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grAvisos;
        private System.Windows.Forms.Button btnAvisoExcluir;
        private System.Windows.Forms.Button btnAvisoCancelar;
        private System.Windows.Forms.Button btnAvisoSalvar;
        private System.Windows.Forms.Button btnAvisoEditar;
        private System.Windows.Forms.Button btnAvisoNovo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grEventosProximos;
        private System.Windows.Forms.DataGridView grEventosPassados;
        private System.Windows.Forms.RichTextBox rtAtaFinal;
        private System.Windows.Forms.Button btnGerarAta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtReuniao;
    }
}