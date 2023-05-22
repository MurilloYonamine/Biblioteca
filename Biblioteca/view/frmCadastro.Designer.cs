
namespace Biblioteca.view
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblCadastro = new System.Windows.Forms.Label();
            this.grpAcesso = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblConfirmarEmail = new System.Windows.Forms.Label();
            this.txtConfirmarEmail = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoNaoBinario = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtNaoBinario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpAcesso.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(382, 9);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(191, 36);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "CADASTRO";
            // 
            // grpAcesso
            // 
            this.grpAcesso.Controls.Add(this.lblConfirmarSenha);
            this.grpAcesso.Controls.Add(this.txtConfirmarSenha);
            this.grpAcesso.Controls.Add(this.lblSenha);
            this.grpAcesso.Controls.Add(this.txtSenha);
            this.grpAcesso.Controls.Add(this.lblConfirmarEmail);
            this.grpAcesso.Controls.Add(this.txtConfirmarEmail);
            this.grpAcesso.Controls.Add(this.lblEmail);
            this.grpAcesso.Controls.Add(this.txtEmail);
            this.grpAcesso.Location = new System.Drawing.Point(12, 75);
            this.grpAcesso.Name = "grpAcesso";
            this.grpAcesso.Size = new System.Drawing.Size(927, 110);
            this.grpAcesso.TabIndex = 1;
            this.grpAcesso.TabStop = false;
            this.grpAcesso.Text = "Acesso";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(25, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmail.Location = new System.Drawing.Point(28, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 19);
            this.txtEmail.TabIndex = 4;
            // 
            // lblConfirmarEmail
            // 
            this.lblConfirmarEmail.AutoSize = true;
            this.lblConfirmarEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfirmarEmail.Location = new System.Drawing.Point(243, 32);
            this.lblConfirmarEmail.Name = "lblConfirmarEmail";
            this.lblConfirmarEmail.Size = new System.Drawing.Size(125, 18);
            this.lblConfirmarEmail.TabIndex = 7;
            this.lblConfirmarEmail.Text = "Confirmar Email:";
            // 
            // txtConfirmarEmail
            // 
            this.txtConfirmarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtConfirmarEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.txtConfirmarEmail.Location = new System.Drawing.Point(246, 53);
            this.txtConfirmarEmail.Name = "txtConfirmarEmail";
            this.txtConfirmarEmail.Size = new System.Drawing.Size(163, 19);
            this.txtConfirmarEmail.TabIndex = 6;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(725, 32);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(130, 18);
            this.lblConfirmarSenha.TabIndex = 11;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtConfirmarSenha.Location = new System.Drawing.Point(728, 53);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(163, 19);
            this.txtConfirmarSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Location = new System.Drawing.Point(507, 32);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenha.Location = new System.Drawing.Point(510, 53);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(163, 19);
            this.txtSenha.TabIndex = 8;
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtNaoBinario);
            this.grpDados.Controls.Add(this.lblGenero);
            this.grpDados.Controls.Add(this.rdoNaoBinario);
            this.grpDados.Controls.Add(this.rdoFeminino);
            this.grpDados.Controls.Add(this.rdoMasculino);
            this.grpDados.Controls.Add(this.lblNascimento);
            this.grpDados.Controls.Add(this.dtpNascimento);
            this.grpDados.Controls.Add(this.lblCpf);
            this.grpDados.Controls.Add(this.txtCpf);
            this.grpDados.Controls.Add(this.lblNomeSocial);
            this.grpDados.Controls.Add(this.txtNomeSocial);
            this.grpDados.Controls.Add(this.lblNome);
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Location = new System.Drawing.Point(12, 217);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(927, 177);
            this.grpDados.TabIndex = 12;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados Pessoais";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(25, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 18);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNome.Location = new System.Drawing.Point(28, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 19);
            this.txtNome.TabIndex = 4;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeSocial.Location = new System.Drawing.Point(302, 32);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(102, 18);
            this.lblNomeSocial.TabIndex = 7;
            this.lblNomeSocial.Text = "Nome Social:";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtNomeSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeSocial.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeSocial.Location = new System.Drawing.Point(305, 53);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(233, 19);
            this.txtNomeSocial.TabIndex = 6;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCpf.Location = new System.Drawing.Point(588, 32);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(45, 18);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCpf.Location = new System.Drawing.Point(591, 53);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(300, 19);
            this.txtCpf.TabIndex = 10;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(28, 111);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(164, 26);
            this.dtpNascimento.TabIndex = 10;
            this.dtpNascimento.Value = new System.DateTime(2023, 5, 21, 0, 0, 0, 0);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNascimento.Location = new System.Drawing.Point(25, 90);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(155, 18);
            this.lblNascimento.TabIndex = 11;
            this.lblNascimento.Text = "Data de Nascimento:";
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(237, 114);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(96, 22);
            this.rdoMasculino.TabIndex = 12;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(339, 114);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(91, 22);
            this.rdoFeminino.TabIndex = 13;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoNaoBinario
            // 
            this.rdoNaoBinario.AutoSize = true;
            this.rdoNaoBinario.Location = new System.Drawing.Point(436, 114);
            this.rdoNaoBinario.Name = "rdoNaoBinario";
            this.rdoNaoBinario.Size = new System.Drawing.Size(109, 22);
            this.rdoNaoBinario.TabIndex = 14;
            this.rdoNaoBinario.TabStop = true;
            this.rdoNaoBinario.Text = "Não Binário";
            this.rdoNaoBinario.UseVisualStyleBackColor = true;
            this.rdoNaoBinario.CheckedChanged += new System.EventHandler(this.rdoNaoBinario_CheckedChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGenero.Location = new System.Drawing.Point(234, 93);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 18);
            this.lblGenero.TabIndex = 16;
            this.lblGenero.Text = "Gênero:";
            // 
            // txtNaoBinario
            // 
            this.txtNaoBinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtNaoBinario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaoBinario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNaoBinario.Location = new System.Drawing.Point(551, 117);
            this.txtNaoBinario.Name = "txtNaoBinario";
            this.txtNaoBinario.Size = new System.Drawing.Size(207, 19);
            this.txtNaoBinario.TabIndex = 17;
            this.txtNaoBinario.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(239)))));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(328, 438);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(299, 41);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "CADASTRAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 491);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grpDados);
            this.Controls.Add(this.grpAcesso);
            this.Controls.Add(this.lblCadastro);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encerrar);
            this.grpAcesso.ResumeLayout(false);
            this.grpAcesso.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.GroupBox grpAcesso;
        private System.Windows.Forms.Label lblConfirmarEmail;
        private System.Windows.Forms.TextBox txtConfirmarEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoNaoBinario;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.TextBox txtNaoBinario;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnLogin;
    }
}