namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLimpar = new Button();
            btnAlterarSinal = new Button();
            btnDivisao = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnMultiplicacao = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSubtracao = new Button();
            btnUm = new Button();
            btnZero = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            btnTres = new Button();
            btnDois = new Button();
            btnSoma = new Button();
            btnIgual = new Button();
            btnPonto = new Button();
            txtResultado = new TextBox();
            lblHistorico = new Label();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkSeaGreen;
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(28, 175);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 70);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAlterarSinal
            // 
            btnAlterarSinal.BackColor = Color.DarkSeaGreen;
            btnAlterarSinal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarSinal.Location = new Point(104, 175);
            btnAlterarSinal.Name = "btnAlterarSinal";
            btnAlterarSinal.Size = new Size(70, 70);
            btnAlterarSinal.TabIndex = 1;
            btnAlterarSinal.Text = "+/-";
            btnAlterarSinal.UseVisualStyleBackColor = false;
            btnAlterarSinal.Click += btnAlterarSinal_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.DarkSeaGreen;
            btnDivisao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivisao.Location = new Point(256, 175);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(70, 70);
            btnDivisao.TabIndex = 2;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = SystemColors.Info;
            btnSete.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSete.Location = new Point(28, 251);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(70, 70);
            btnSete.TabIndex = 3;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = SystemColors.Info;
            btnOito.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOito.Location = new Point(104, 251);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(70, 70);
            btnOito.TabIndex = 4;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = SystemColors.Info;
            btnNove.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnNove.Location = new Point(180, 251);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(70, 70);
            btnNove.TabIndex = 5;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.DarkSeaGreen;
            btnMultiplicacao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(256, 251);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(70, 70);
            btnMultiplicacao.TabIndex = 6;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = SystemColors.Info;
            btnQuatro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuatro.Location = new Point(28, 327);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(70, 70);
            btnQuatro.TabIndex = 7;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = SystemColors.Info;
            btnCinco.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCinco.Location = new Point(104, 327);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(70, 70);
            btnCinco.TabIndex = 8;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = SystemColors.Info;
            btnSeis.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeis.Location = new Point(180, 327);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(70, 70);
            btnSeis.TabIndex = 9;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.DarkSeaGreen;
            btnSubtracao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(256, 327);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(70, 70);
            btnSubtracao.TabIndex = 10;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = SystemColors.Info;
            btnUm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnUm.Location = new Point(28, 403);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(70, 70);
            btnUm.TabIndex = 11;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.Info;
            btnZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnZero.Location = new Point(28, 479);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(146, 70);
            btnZero.TabIndex = 12;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // button14
            // 
            button14.Location = new Point(310, 567);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 13;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(210, 567);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 14;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(112, 567);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 15;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(12, 567);
            button17.Name = "button17";
            button17.Size = new Size(75, 23);
            button17.TabIndex = 16;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.Info;
            btnTres.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.Location = new Point(180, 403);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(70, 70);
            btnTres.TabIndex = 17;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = SystemColors.Info;
            btnDois.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDois.Location = new Point(104, 403);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(70, 70);
            btnDois.TabIndex = 18;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.DarkSeaGreen;
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoma.Location = new Point(256, 403);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(70, 70);
            btnSoma.TabIndex = 19;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DarkSeaGreen;
            btnIgual.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(256, 479);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(70, 70);
            btnIgual.TabIndex = 20;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnPonto
            // 
            btnPonto.BackColor = Color.DarkSeaGreen;
            btnPonto.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnPonto.Location = new Point(180, 479);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(70, 70);
            btnPonto.TabIndex = 21;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = false;
            btnPonto.Click += btnPonto_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Info;
            txtResultado.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(28, 84);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(298, 52);
            txtResultado.TabIndex = 22;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.BackColor = SystemColors.Info;
            lblHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorico.Location = new Point(28, 30);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(0, 21);
            lblHistorico.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(355, 561);
            Controls.Add(lblHistorico);
            Controls.Add(txtResultado);
            Controls.Add(btnPonto);
            Controls.Add(btnIgual);
            Controls.Add(btnSoma);
            Controls.Add(btnDois);
            Controls.Add(btnTres);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(btnZero);
            Controls.Add(btnUm);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnDivisao);
            Controls.Add(btnAlterarSinal);
            Controls.Add(btnLimpar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnAlterarSinal;
        private Button btnDivisao;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnMultiplicacao;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSubtracao;
        private Button btnUm;
        private Button btnZero;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btnTres;
        private Button btnDois;
        private Button btnSoma;
        private Button btnIgual;
        private Button btnPonto;
        private TextBox txtResultado;
        private Label lblHistorico;
    }
}