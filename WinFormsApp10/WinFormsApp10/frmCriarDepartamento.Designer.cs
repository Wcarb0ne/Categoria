namespace WinFormsApp10
{
    partial class frmCriarDepartamento
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
            groupBox1 = new GroupBox();
            mtbDataCadastro = new MaskedTextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btoPesquisar = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            cboStatus = new ComboBox();
            txtObs = new TextBox();
            txtDescricao = new TextBox();
            txtNomeDepartamento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btoCadastrar = new Button();
            btoSair = new Button();
            btoLimpar = new Button();
            btoExcluir = new Button();
            btoAlterar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtbDataCadastro);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btoPesquisar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // mtbDataCadastro
            // 
            mtbDataCadastro.Location = new Point(520, 48);
            mtbDataCadastro.Mask = "00/00/0000 90:00";
            mtbDataCadastro.Name = "mtbDataCadastro";
            mtbDataCadastro.Size = new Size(147, 29);
            mtbDataCadastro.TabIndex = 4;
            mtbDataCadastro.ValidatingType = typeof(DateTime);
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(11, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 29);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 24);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 2;
            label4.Text = "Data de Cadastro";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // btoPesquisar
            // 
            btoPesquisar.Location = new Point(117, 48);
            btoPesquisar.Name = "btoPesquisar";
            btoPesquisar.Size = new Size(87, 31);
            btoPesquisar.TabIndex = 0;
            btoPesquisar.Text = "&Pesquisar";
            btoPesquisar.UseVisualStyleBackColor = true;
            btoPesquisar.Click += btoPesquisar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboStatus);
            groupBox2.Controls.Add(txtObs);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(txtNomeDepartamento);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 152);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 7;
            label6.Text = "Observação";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 67);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 6;
            label5.Text = "Descrição";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Ativo", "Desativado" });
            cboStatus.Location = new Point(520, 38);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(147, 29);
            cboStatus.TabIndex = 5;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(12, 176);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(655, 58);
            txtObs.TabIndex = 4;
            txtObs.TabStop = false;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(11, 91);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(656, 58);
            txtDescricao.TabIndex = 3;
            txtDescricao.TabStop = false;
            // 
            // txtNomeDepartamento
            // 
            txtNomeDepartamento.Location = new Point(11, 38);
            txtNomeDepartamento.Name = "txtNomeDepartamento";
            txtNomeDepartamento.Size = new Size(312, 29);
            txtNomeDepartamento.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 14);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 1;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btoCadastrar);
            groupBox3.Controls.Add(btoSair);
            groupBox3.Controls.Add(btoLimpar);
            groupBox3.Controls.Add(btoExcluir);
            groupBox3.Controls.Add(btoAlterar);
            groupBox3.Location = new Point(12, 359);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 74);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btoCadastrar
            // 
            btoCadastrar.Location = new Point(192, 28);
            btoCadastrar.Name = "btoCadastrar";
            btoCadastrar.Size = new Size(87, 31);
            btoCadastrar.TabIndex = 4;
            btoCadastrar.Text = "&Cadastrar";
            btoCadastrar.UseVisualStyleBackColor = true;
            btoCadastrar.Click += btoCadastrar_Click;
            // 
            // btoSair
            // 
            btoSair.Location = new Point(564, 28);
            btoSair.Name = "btoSair";
            btoSair.Size = new Size(87, 31);
            btoSair.TabIndex = 3;
            btoSair.Text = "&Sair";
            btoSair.UseVisualStyleBackColor = true;
            btoSair.Click += btoSair_Click_1;
            // 
            // btoLimpar
            // 
            btoLimpar.Location = new Point(471, 28);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(87, 31);
            btoLimpar.TabIndex = 2;
            btoLimpar.Text = "&Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // btoExcluir
            // 
            btoExcluir.Location = new Point(378, 28);
            btoExcluir.Name = "btoExcluir";
            btoExcluir.Size = new Size(87, 31);
            btoExcluir.TabIndex = 1;
            btoExcluir.Text = "&Excluir";
            btoExcluir.UseVisualStyleBackColor = true;
            btoExcluir.Click += btoExcluir_Click;
            // 
            // btoAlterar
            // 
            btoAlterar.Location = new Point(285, 28);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(87, 31);
            btoAlterar.TabIndex = 0;
            btoAlterar.Text = "&Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            btoAlterar.Click += btoAlterar_Click;
            // 
            // frmCriarDepartamento
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 452);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmCriarDepartamento";
            Text = "Tela de Cadastro de Departamantos";
            Load += frmCriarDepartamento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox mtbDataCadastro;
        private TextBox txtCodigo;
        private Label label4;
        private Label label1;
        private Button btoPesquisar;
        private GroupBox groupBox2;
        private ComboBox cboStatus;
        private TextBox txtObs;
        private TextBox txtDescricao;
        private TextBox txtNomeDepartamento;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Button btoCadastrar;
        private Button btoSair;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoAlterar;
        private Label label6;
        private Label label5;
    }
}