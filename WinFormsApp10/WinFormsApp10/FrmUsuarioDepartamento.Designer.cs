namespace WinFormsApp10
{
    partial class FrmUsuarioDepartamento
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
            cboStatus = new ComboBox();
            mtbDataCadastro = new MaskedTextBox();
            txtID = new TextBox();
            label1 = new Label();
            btoPesquisar = new Button();
            label9 = new Label();
            mtbCnpj = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btoLimpar = new Button();
            btoSair = new Button();
            btoAlterar = new Button();
            btoCadastrar = new Button();
            groupBox2 = new GroupBox();
            mtbTelefone2 = new MaskedTextBox();
            txtObservacao = new TextBox();
            mtbTelefone1 = new MaskedTextBox();
            label22 = new Label();
            label20 = new Label();
            mtbHorario = new MaskedTextBox();
            txtTipoServico = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            cboEspecialidade = new ComboBox();
            cboUF = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            mtbCep = new MaskedTextBox();
            label14 = new Label();
            label13 = new Label();
            txtSenha = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtLogin = new TextBox();
            txtEmail = new TextBox();
            txtLogradouro = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(mtbDataCadastro);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btoPesquisar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(mtbCnpj);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Ativo", "Desativado" });
            cboStatus.Location = new Point(723, 103);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(155, 29);
            cboStatus.TabIndex = 25;
            // 
            // mtbDataCadastro
            // 
            mtbDataCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbDataCadastro.Location = new Point(714, 34);
            mtbDataCadastro.Mask = "00/00/0000 90:00";
            mtbDataCadastro.Name = "mtbDataCadastro";
            mtbDataCadastro.Size = new Size(165, 29);
            mtbDataCadastro.TabIndex = 11;
            mtbDataCadastro.ValidatingType = typeof(DateTime);
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(6, 34);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 29);
            txtID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // btoPesquisar
            // 
            btoPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btoPesquisar.Location = new Point(112, 32);
            btoPesquisar.Name = "btoPesquisar";
            btoPesquisar.Size = new Size(84, 30);
            btoPesquisar.TabIndex = 0;
            btoPesquisar.Text = "Pesquisar";
            btoPesquisar.UseVisualStyleBackColor = true;
            btoPesquisar.Click += btoPesquisar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(714, 10);
            label9.Name = "label9";
            label9.Size = new Size(129, 21);
            label9.TabIndex = 10;
            label9.Text = "Data de Cadastro";
            // 
            // mtbCnpj
            // 
            mtbCnpj.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbCnpj.Location = new Point(541, 103);
            mtbCnpj.Mask = "00.000.000/0000-00";
            mtbCnpj.Name = "mtbCnpj";
            mtbCnpj.Size = new Size(176, 29);
            mtbCnpj.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 79);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(541, 79);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 1;
            label3.Text = "Cnpj";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(6, 103);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(262, 29);
            txtNome.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(723, 79);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 2;
            label4.Text = "Status";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btoLimpar);
            groupBox3.Controls.Add(btoSair);
            groupBox3.Controls.Add(btoAlterar);
            groupBox3.Controls.Add(btoCadastrar);
            groupBox3.Location = new Point(12, 453);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(885, 64);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btoLimpar
            // 
            btoLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btoLimpar.Location = new Point(677, 22);
            btoLimpar.Name = "btoLimpar";
            btoLimpar.Size = new Size(88, 36);
            btoLimpar.TabIndex = 3;
            btoLimpar.Text = "Limpar";
            btoLimpar.UseVisualStyleBackColor = true;
            btoLimpar.Click += btoLimpar_Click;
            // 
            // btoSair
            // 
            btoSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btoSair.Location = new Point(778, 22);
            btoSair.Name = "btoSair";
            btoSair.Size = new Size(88, 34);
            btoSair.TabIndex = 2;
            btoSair.Text = "Sair";
            btoSair.UseVisualStyleBackColor = true;
            btoSair.Click += btoSair_Click;
            // 
            // btoAlterar
            // 
            btoAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btoAlterar.Location = new Point(583, 22);
            btoAlterar.Name = "btoAlterar";
            btoAlterar.Size = new Size(88, 36);
            btoAlterar.TabIndex = 1;
            btoAlterar.Text = "Alterar";
            btoAlterar.UseVisualStyleBackColor = true;
            btoAlterar.Click += btoAlterar_Click;
            // 
            // btoCadastrar
            // 
            btoCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btoCadastrar.Location = new Point(489, 22);
            btoCadastrar.Name = "btoCadastrar";
            btoCadastrar.Size = new Size(88, 34);
            btoCadastrar.TabIndex = 0;
            btoCadastrar.Text = "Cadastrar";
            btoCadastrar.UseVisualStyleBackColor = true;
            btoCadastrar.Click += btoCadastrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mtbTelefone2);
            groupBox2.Controls.Add(txtObservacao);
            groupBox2.Controls.Add(mtbTelefone1);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(mtbHorario);
            groupBox2.Controls.Add(txtTipoServico);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(cboEspecialidade);
            groupBox2.Controls.Add(cboUF);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtComplemento);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(mtbCep);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtSenha);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(txtLogin);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtLogradouro);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(885, 292);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // mtbTelefone2
            // 
            mtbTelefone2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTelefone2.Location = new Point(395, 98);
            mtbTelefone2.Mask = "(99) 00000-0000";
            mtbTelefone2.Name = "mtbTelefone2";
            mtbTelefone2.Size = new Size(128, 29);
            mtbTelefone2.TabIndex = 26;
            // 
            // txtObservacao
            // 
            txtObservacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtObservacao.Location = new Point(6, 214);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(860, 72);
            txtObservacao.TabIndex = 41;
            // 
            // mtbTelefone1
            // 
            mtbTelefone1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbTelefone1.Location = new Point(261, 98);
            mtbTelefone1.Mask = "(99) 00000-0000";
            mtbTelefone1.Name = "mtbTelefone1";
            mtbTelefone1.Size = new Size(128, 29);
            mtbTelefone1.TabIndex = 25;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(6, 190);
            label22.Name = "label22";
            label22.Size = new Size(92, 21);
            label22.TabIndex = 40;
            label22.Text = "Observação";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(6, 132);
            label20.Name = "label20";
            label20.Size = new Size(196, 21);
            label20.TabIndex = 39;
            label20.Text = "Horario de Funcionamento";
            label20.Click += label20_Click;
            // 
            // mtbHorario
            // 
            mtbHorario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbHorario.Location = new Point(6, 156);
            mtbHorario.Mask = "      00:00 ás 00:00  ";
            mtbHorario.Name = "mtbHorario";
            mtbHorario.Size = new Size(190, 29);
            mtbHorario.TabIndex = 38;
            mtbHorario.ValidatingType = typeof(DateTime);
            // 
            // txtTipoServico
            // 
            txtTipoServico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoServico.Location = new Point(206, 156);
            txtTipoServico.Name = "txtTipoServico";
            txtTipoServico.Size = new Size(179, 29);
            txtTipoServico.TabIndex = 37;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(205, 132);
            label19.Name = "label19";
            label19.Size = new Size(116, 21);
            label19.TabIndex = 36;
            label19.Text = "Tipo de Serviço";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(177, 74);
            label18.Name = "label18";
            label18.Size = new Size(26, 21);
            label18.TabIndex = 35;
            label18.Text = "Uf";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(391, 132);
            label17.Name = "label17";
            label17.Size = new Size(108, 21);
            label17.TabIndex = 34;
            label17.Text = "Especialização";
            // 
            // cboEspecialidade
            // 
            cboEspecialidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboEspecialidade.FormattingEnabled = true;
            cboEspecialidade.Location = new Point(391, 156);
            cboEspecialidade.Name = "cboEspecialidade";
            cboEspecialidade.Size = new Size(121, 29);
            cboEspecialidade.TabIndex = 33;
            // 
            // cboUF
            // 
            cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboUF.FormattingEnabled = true;
            cboUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboUF.Location = new Point(177, 98);
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(78, 29);
            cboUF.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(332, 21);
            label16.Name = "label16";
            label16.Size = new Size(109, 21);
            label16.TabIndex = 31;
            label16.Text = "Complemento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(226, 21);
            label15.Name = "label15";
            label15.Size = new Size(29, 21);
            label15.TabIndex = 30;
            label15.Text = "Nº";
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(332, 45);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(224, 29);
            txtComplemento.TabIndex = 29;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(226, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 29);
            txtNumero.TabIndex = 28;
            // 
            // mtbCep
            // 
            mtbCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mtbCep.Location = new Point(714, 45);
            mtbCep.Mask = "000-00-000";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(152, 29);
            mtbCep.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(714, 22);
            label14.Name = "label14";
            label14.Size = new Size(37, 21);
            label14.TabIndex = 25;
            label14.Text = "Cep";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(691, 133);
            label13.Name = "label13";
            label13.Size = new Size(53, 21);
            label13.TabIndex = 23;
            label13.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(695, 156);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(171, 29);
            txtSenha.TabIndex = 22;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(562, 45);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(146, 29);
            txtBairro.TabIndex = 20;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(6, 98);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(165, 29);
            txtCidade.TabIndex = 19;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(518, 156);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(171, 29);
            txtLogin.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(529, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(337, 29);
            txtEmail.TabIndex = 17;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(6, 45);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(214, 29);
            txtLogradouro.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(514, 133);
            label12.Name = "label12";
            label12.Size = new Size(49, 21);
            label12.TabIndex = 13;
            label12.Text = "Login";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(529, 77);
            label11.Name = "label11";
            label11.Size = new Size(54, 21);
            label11.TabIndex = 12;
            label11.Text = "E-Mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(395, 74);
            label10.Name = "label10";
            label10.Size = new Size(80, 21);
            label10.TabIndex = 11;
            label10.Text = "Telefone 2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(261, 77);
            label8.Name = "label8";
            label8.Size = new Size(80, 21);
            label8.TabIndex = 9;
            label8.Text = "Telefone 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(562, 22);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 8;
            label7.Text = "Bairro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 7;
            label6.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 21);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 6;
            label5.Text = "Logradouro";
            // 
            // FrmUsuarioDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 521);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmUsuarioDepartamento";
            Text = "Tela de Validação do RH para os Clientes";
            Load += FrmUsuarioDepartamento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label1;
        private Button btoPesquisar;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox mtbDataCadastro;
        private Label label9;
        private MaskedTextBox mtbCnpj;
        private Label label13;
        private TextBox txtSenha;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtLogin;
        private TextBox txtEmail;
        private TextBox txtLogradouro;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label18;
        private Label label17;
        private ComboBox cboEspecialidade;
        private ComboBox cboUF;
        private Label label16;
        private Label label15;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private MaskedTextBox mtbCep;
        private Label label14;
        private Label label20;
        private MaskedTextBox mtbHorario;
        private TextBox txtTipoServico;
        private Label label19;
        private TextBox txtObservacao;
        private Label label22;
        private Button btoAlterar;
        private Button btoCadastrar;
        private MaskedTextBox mtbTelefone2;
        private MaskedTextBox mtbTelefone1;
        private Button btoSair;
        private Button btoLimpar;
        private ComboBox cboStatus;
    }
}