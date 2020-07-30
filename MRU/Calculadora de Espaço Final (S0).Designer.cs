namespace MRU
{
    partial class fundo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fundo));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picFormula = new System.Windows.Forms.PictureBox();
            this.picCarros = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.radKmh = new System.Windows.Forms.RadioButton();
            this.radMs = new System.Windows.Forms.RadioButton();
            this.lblUnidadeResult = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.gpbResult = new System.Windows.Forms.GroupBox();
            this.lblR4 = new System.Windows.Forms.Label();
            this.lblR3 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.radEspacoFinal = new System.Windows.Forms.RadioButton();
            this.radTempo = new System.Windows.Forms.RadioButton();
            this.radVelocidade = new System.Windows.Forms.RadioButton();
            this.radEspacoInicial = new System.Windows.Forms.RadioButton();
            this.txtEspacoFinal = new System.Windows.Forms.TextBox();
            this.lblUnidadeEspacoFinal = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblUnidadeVelocidade = new System.Windows.Forms.Label();
            this.lblUnidadeTempo = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.lblUnidadeEspacoInicial = new System.Windows.Forms.Label();
            this.txtEspacoInicial = new System.Windows.Forms.TextBox();
            this.lblEspaçoInicial = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblItensParaCalcular = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEquacaoT = new System.Windows.Forms.Label();
            this.lblVezes = new System.Windows.Forms.Label();
            this.lblEquacaoV = new System.Windows.Forms.Label();
            this.lblMais = new System.Windows.Forms.Label();
            this.lblEquacaoS0 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblEquacaoS = new System.Windows.Forms.Label();
            this.lblEquacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarros)).BeginInit();
            this.gpbResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            txtEspacoInicial.Focus();

            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(365, 346);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 32);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(450, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(69, 32);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(535, 347);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(69, 32);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picFormula
            // 
            this.picFormula.Image = ((System.Drawing.Image)(resources.GetObject("picFormula.Image")));
            this.picFormula.Location = new System.Drawing.Point(12, 12);
            this.picFormula.Name = "picFormula";
            this.picFormula.Size = new System.Drawing.Size(265, 188);
            this.picFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFormula.TabIndex = 13;
            this.picFormula.TabStop = false;
            // 
            // picCarros
            // 
            this.picCarros.Image = ((System.Drawing.Image)(resources.GetObject("picCarros.Image")));
            this.picCarros.Location = new System.Drawing.Point(12, 218);
            this.picCarros.Name = "picCarros";
            this.picCarros.Size = new System.Drawing.Size(265, 168);
            this.picCarros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarros.TabIndex = 14;
            this.picCarros.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Silver;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(509, 281);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(112, 38);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radKmh
            // 
            this.radKmh.AutoSize = true;
            this.radKmh.Checked = true;
            this.radKmh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKmh.ForeColor = System.Drawing.SystemColors.Control;
            this.radKmh.Location = new System.Drawing.Point(323, 291);
            this.radKmh.Name = "radKmh";
            this.radKmh.Size = new System.Drawing.Size(67, 24);
            this.radKmh.TabIndex = 21;
            this.radKmh.TabStop = true;
            this.radKmh.Text = "&Km/h";
            this.radKmh.UseVisualStyleBackColor = true;
            this.radKmh.CheckedChanged += new System.EventHandler(this.radKmh_CheckedChanged);
            // 
            // radMs
            // 
            this.radMs.AutoSize = true;
            this.radMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMs.ForeColor = System.Drawing.SystemColors.Control;
            this.radMs.Location = new System.Drawing.Point(412, 291);
            this.radMs.Name = "radMs";
            this.radMs.Size = new System.Drawing.Size(55, 24);
            this.radMs.TabIndex = 22;
            this.radMs.Text = "&m/s";
            this.radMs.UseVisualStyleBackColor = true;
            this.radMs.CheckedChanged += new System.EventHandler(this.radMs_CheckedChanged);
            // 
            // lblUnidadeResult
            // 
            this.lblUnidadeResult.AutoSize = true;
            this.lblUnidadeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnidadeResult.Location = new System.Drawing.Point(624, 293);
            this.lblUnidadeResult.Name = "lblUnidadeResult";
            this.lblUnidadeResult.Size = new System.Drawing.Size(34, 20);
            this.lblUnidadeResult.TabIndex = 24;
            this.lblUnidadeResult.Text = "Km";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Location = new System.Drawing.Point(503, 260);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 20);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.ForeColor = System.Drawing.SystemColors.Control;
            this.lblR.Location = new System.Drawing.Point(590, 260);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(38, 20);
            this.lblR.TabIndex = 0;
            this.lblR.Text = "(S):";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnidade.Location = new System.Drawing.Point(312, 265);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(169, 20);
            this.lblUnidade.TabIndex = 0;
            this.lblUnidade.Text = "Unidade de Medida:";
            // 
            // gpbResult
            // 
            this.gpbResult.Controls.Add(this.lblR4);
            this.gpbResult.Controls.Add(this.lblR3);
            this.gpbResult.Controls.Add(this.lblR2);
            this.gpbResult.Controls.Add(this.lblR1);
            this.gpbResult.Controls.Add(this.radEspacoFinal);
            this.gpbResult.Controls.Add(this.radTempo);
            this.gpbResult.Controls.Add(this.radVelocidade);
            this.gpbResult.Controls.Add(this.radEspacoInicial);
            this.gpbResult.Controls.Add(this.txtEspacoFinal);
            this.gpbResult.Controls.Add(this.lblUnidadeEspacoFinal);
            this.gpbResult.Controls.Add(this.lblS);
            this.gpbResult.Controls.Add(this.lblUnidadeVelocidade);
            this.gpbResult.Controls.Add(this.lblUnidadeTempo);
            this.gpbResult.Controls.Add(this.txtTempo);
            this.gpbResult.Controls.Add(this.txtVelocidade);
            this.gpbResult.Controls.Add(this.lblTempo);
            this.gpbResult.Controls.Add(this.lblVelocidade);
            this.gpbResult.Controls.Add(this.lblUnidadeEspacoInicial);
            this.gpbResult.Controls.Add(this.txtEspacoInicial);
            this.gpbResult.Controls.Add(this.lblEspaçoInicial);
            this.gpbResult.Location = new System.Drawing.Point(316, 30);
            this.gpbResult.Name = "gpbResult";
            this.gpbResult.Size = new System.Drawing.Size(342, 153);
            this.gpbResult.TabIndex = 32;
            this.gpbResult.TabStop = false;
            // 
            // lblR4
            // 
            this.lblR4.AutoSize = true;
            this.lblR4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR4.Location = new System.Drawing.Point(197, 118);
            this.lblR4.Name = "lblR4";
            this.lblR4.Size = new System.Drawing.Size(84, 18);
            this.lblR4.TabIndex = 0;
            this.lblR4.Text = "Resultado";
            this.lblR4.Visible = false;
            // 
            // lblR3
            // 
            this.lblR3.AutoSize = true;
            this.lblR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR3.Location = new System.Drawing.Point(197, 86);
            this.lblR3.Name = "lblR3";
            this.lblR3.Size = new System.Drawing.Size(84, 18);
            this.lblR3.TabIndex = 0;
            this.lblR3.Text = "Resultado";
            this.lblR3.Visible = false;
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR2.Location = new System.Drawing.Point(197, 54);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(84, 18);
            this.lblR2.TabIndex = 0;
            this.lblR2.Text = "Resultado";
            this.lblR2.Visible = false;
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblR1.Location = new System.Drawing.Point(197, 22);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(84, 18);
            this.lblR1.TabIndex = 0;
            this.lblR1.Text = "Resultado";
            // 
            // radEspacoFinal
            // 
            this.radEspacoFinal.AutoSize = true;
            this.radEspacoFinal.Checked = true;
            this.radEspacoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEspacoFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.radEspacoFinal.Location = new System.Drawing.Point(14, 26);
            this.radEspacoFinal.Name = "radEspacoFinal";
            this.radEspacoFinal.Size = new System.Drawing.Size(14, 13);
            this.radEspacoFinal.TabIndex = 71;
            this.radEspacoFinal.TabStop = true;
            this.radEspacoFinal.UseVisualStyleBackColor = true;
            this.radEspacoFinal.CheckedChanged += new System.EventHandler(this.radEspacoFinal_CheckedChanged_1);
            // 
            // radTempo
            // 
            this.radTempo.AutoSize = true;
            this.radTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTempo.ForeColor = System.Drawing.SystemColors.Control;
            this.radTempo.Location = new System.Drawing.Point(14, 122);
            this.radTempo.Name = "radTempo";
            this.radTempo.Size = new System.Drawing.Size(14, 13);
            this.radTempo.TabIndex = 70;
            this.radTempo.UseVisualStyleBackColor = true;
            this.radTempo.CheckedChanged += new System.EventHandler(this.radTempo_CheckedChanged_1);
            // 
            // radVelocidade
            // 
            this.radVelocidade.AutoSize = true;
            this.radVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVelocidade.ForeColor = System.Drawing.SystemColors.Control;
            this.radVelocidade.Location = new System.Drawing.Point(14, 90);
            this.radVelocidade.Name = "radVelocidade";
            this.radVelocidade.Size = new System.Drawing.Size(14, 13);
            this.radVelocidade.TabIndex = 69;
            this.radVelocidade.UseVisualStyleBackColor = true;
            this.radVelocidade.CheckedChanged += new System.EventHandler(this.radVelocidade_CheckedChanged_1);
            // 
            // radEspacoInicial
            // 
            this.radEspacoInicial.AutoSize = true;
            this.radEspacoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEspacoInicial.ForeColor = System.Drawing.SystemColors.Control;
            this.radEspacoInicial.Location = new System.Drawing.Point(14, 58);
            this.radEspacoInicial.Name = "radEspacoInicial";
            this.radEspacoInicial.Size = new System.Drawing.Size(14, 13);
            this.radEspacoInicial.TabIndex = 68;
            this.radEspacoInicial.UseVisualStyleBackColor = true;
            this.radEspacoInicial.CheckedChanged += new System.EventHandler(this.radEspacoInicial_CheckedChanged_1);
            // 
            // txtEspacoFinal
            // 
            this.txtEspacoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacoFinal.Location = new System.Drawing.Point(196, 19);
            this.txtEspacoFinal.Name = "txtEspacoFinal";
            this.txtEspacoFinal.Size = new System.Drawing.Size(84, 26);
            this.txtEspacoFinal.TabIndex = 1;
            this.txtEspacoFinal.Visible = false;
            this.txtEspacoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspacoFinal_KeyPress);
            // 
            // lblUnidadeEspacoFinal
            // 
            this.lblUnidadeEspacoFinal.AutoSize = true;
            this.lblUnidadeEspacoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeEspacoFinal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnidadeEspacoFinal.Location = new System.Drawing.Point(279, 22);
            this.lblUnidadeEspacoFinal.Name = "lblUnidadeEspacoFinal";
            this.lblUnidadeEspacoFinal.Size = new System.Drawing.Size(34, 20);
            this.lblUnidadeEspacoFinal.TabIndex = 66;
            this.lblUnidadeEspacoFinal.Text = "Km";
            this.lblUnidadeEspacoFinal.Visible = false;
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblS.Location = new System.Drawing.Point(52, 22);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(147, 20);
            this.lblS.TabIndex = 0;
            this.lblS.Text = "Espaço Final (S):";
            // 
            // lblUnidadeVelocidade
            // 
            this.lblUnidadeVelocidade.AutoSize = true;
            this.lblUnidadeVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeVelocidade.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnidadeVelocidade.Location = new System.Drawing.Point(279, 86);
            this.lblUnidadeVelocidade.Name = "lblUnidadeVelocidade";
            this.lblUnidadeVelocidade.Size = new System.Drawing.Size(49, 20);
            this.lblUnidadeVelocidade.TabIndex = 64;
            this.lblUnidadeVelocidade.Text = "Km/h";
            // 
            // lblUnidadeTempo
            // 
            this.lblUnidadeTempo.AutoSize = true;
            this.lblUnidadeTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeTempo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnidadeTempo.Location = new System.Drawing.Point(279, 118);
            this.lblUnidadeTempo.Name = "lblUnidadeTempo";
            this.lblUnidadeTempo.Size = new System.Drawing.Size(19, 20);
            this.lblUnidadeTempo.TabIndex = 63;
            this.lblUnidadeTempo.Text = "h";
            // 
            // txtTempo
            // 
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.Location = new System.Drawing.Point(196, 115);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(84, 26);
            this.txtTempo.TabIndex = 4;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidade.Location = new System.Drawing.Point(196, 83);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(84, 26);
            this.txtVelocidade.TabIndex = 3;
            this.txtVelocidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVelocidade_KeyPress);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTempo.Location = new System.Drawing.Point(108, 118);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(91, 20);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "Tempo (t):";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidade.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVelocidade.Location = new System.Drawing.Point(71, 86);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(128, 20);
            this.lblVelocidade.TabIndex = 59;
            this.lblVelocidade.Text = "Velocidade (v):";
            // 
            // lblUnidadeEspacoInicial
            // 
            this.lblUnidadeEspacoInicial.AutoSize = true;
            this.lblUnidadeEspacoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeEspacoInicial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUnidadeEspacoInicial.Location = new System.Drawing.Point(279, 54);
            this.lblUnidadeEspacoInicial.Name = "lblUnidadeEspacoInicial";
            this.lblUnidadeEspacoInicial.Size = new System.Drawing.Size(34, 20);
            this.lblUnidadeEspacoInicial.TabIndex = 58;
            this.lblUnidadeEspacoInicial.Text = "Km";
            // 
            // txtEspacoInicial
            // 
            this.txtEspacoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacoInicial.Location = new System.Drawing.Point(196, 51);
            this.txtEspacoInicial.Name = "txtEspacoInicial";
            this.txtEspacoInicial.Size = new System.Drawing.Size(84, 26);
            this.txtEspacoInicial.TabIndex = 2;
            this.txtEspacoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspacoInicial_KeyPress);
            // 
            // lblEspaçoInicial
            // 
            this.lblEspaçoInicial.AutoSize = true;
            this.lblEspaçoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaçoInicial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEspaçoInicial.Location = new System.Drawing.Point(34, 54);
            this.lblEspaçoInicial.Name = "lblEspaçoInicial";
            this.lblEspaçoInicial.Size = new System.Drawing.Size(165, 20);
            this.lblEspaçoInicial.TabIndex = 56;
            this.lblEspaçoInicial.Text = "Espaço Inicial (S0):";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(664, 363);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(19, 22);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblItensParaCalcular
            // 
            this.lblItensParaCalcular.AutoSize = true;
            this.lblItensParaCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensParaCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItensParaCalcular.Location = new System.Drawing.Point(335, 16);
            this.lblItensParaCalcular.Name = "lblItensParaCalcular";
            this.lblItensParaCalcular.Size = new System.Drawing.Size(303, 20);
            this.lblItensParaCalcular.TabIndex = 34;
            this.lblItensParaCalcular.Text = "Selecione o ítem que será calculado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEquacaoT);
            this.groupBox1.Controls.Add(this.lblVezes);
            this.groupBox1.Controls.Add(this.lblEquacaoV);
            this.groupBox1.Controls.Add(this.lblMais);
            this.groupBox1.Controls.Add(this.lblEquacaoS0);
            this.groupBox1.Controls.Add(this.lblIgual);
            this.groupBox1.Controls.Add(this.lblEquacaoS);
            this.groupBox1.Location = new System.Drawing.Point(347, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 42);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // lblEquacaoT
            // 
            this.lblEquacaoT.AutoSize = true;
            this.lblEquacaoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquacaoT.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEquacaoT.Location = new System.Drawing.Point(210, 13);
            this.lblEquacaoT.Name = "lblEquacaoT";
            this.lblEquacaoT.Size = new System.Drawing.Size(15, 20);
            this.lblEquacaoT.TabIndex = 44;
            this.lblEquacaoT.Text = "t";
            // 
            // lblVezes
            // 
            this.lblVezes.AutoSize = true;
            this.lblVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVezes.Location = new System.Drawing.Point(202, 13);
            this.lblVezes.Name = "lblVezes";
            this.lblVezes.Size = new System.Drawing.Size(14, 20);
            this.lblVezes.TabIndex = 43;
            this.lblVezes.Text = ".";
            // 
            // lblEquacaoV
            // 
            this.lblEquacaoV.AutoSize = true;
            this.lblEquacaoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquacaoV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEquacaoV.Location = new System.Drawing.Point(158, 13);
            this.lblEquacaoV.Name = "lblEquacaoV";
            this.lblEquacaoV.Size = new System.Drawing.Size(17, 20);
            this.lblEquacaoV.TabIndex = 42;
            this.lblEquacaoV.Text = "v";
            // 
            // lblMais
            // 
            this.lblMais.AutoSize = true;
            this.lblMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMais.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMais.Location = new System.Drawing.Point(135, 13);
            this.lblMais.Name = "lblMais";
            this.lblMais.Size = new System.Drawing.Size(19, 20);
            this.lblMais.TabIndex = 0;
            this.lblMais.Text = "+";
            // 
            // lblEquacaoS0
            // 
            this.lblEquacaoS0.AutoSize = true;
            this.lblEquacaoS0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquacaoS0.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEquacaoS0.Location = new System.Drawing.Point(78, 13);
            this.lblEquacaoS0.Name = "lblEquacaoS0";
            this.lblEquacaoS0.Size = new System.Drawing.Size(31, 20);
            this.lblEquacaoS0.TabIndex = 40;
            this.lblEquacaoS0.Text = "S0";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIgual.Location = new System.Drawing.Point(65, 14);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(19, 20);
            this.lblIgual.TabIndex = 39;
            this.lblIgual.Text = "=";
            // 
            // lblEquacaoS
            // 
            this.lblEquacaoS.AutoSize = true;
            this.lblEquacaoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquacaoS.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEquacaoS.Location = new System.Drawing.Point(8, 13);
            this.lblEquacaoS.Name = "lblEquacaoS";
            this.lblEquacaoS.Size = new System.Drawing.Size(21, 20);
            this.lblEquacaoS.TabIndex = 38;
            this.lblEquacaoS.Text = "S";
            // 
            // lblEquacao
            // 
            this.lblEquacao.AutoSize = true;
            this.lblEquacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquacao.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEquacao.Location = new System.Drawing.Point(437, 191);
            this.lblEquacao.Name = "lblEquacao";
            this.lblEquacao.Size = new System.Drawing.Size(85, 20);
            this.lblEquacao.TabIndex = 38;
            this.lblEquacao.Text = "Equação:";
            // 
            // fundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(695, 397);
            this.Controls.Add(this.lblEquacao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblItensParaCalcular);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gpbResult);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblUnidadeResult);
            this.Controls.Add(this.radMs);
            this.Controls.Add(this.radKmh);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picCarros);
            this.Controls.Add(this.picFormula);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fundo";
            this.Text = "Calculadora de MRU";
            ((System.ComponentModel.ISupportInitialize)(this.picFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarros)).EndInit();
            this.gpbResult.ResumeLayout(false);
            this.gpbResult.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            txtEspacoInicial.Focus();

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picFormula;
        private System.Windows.Forms.PictureBox picCarros;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radKmh;
        private System.Windows.Forms.RadioButton radMs;
        private System.Windows.Forms.Label lblUnidadeResult;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.GroupBox gpbResult;
        private System.Windows.Forms.Label lblR4;
        private System.Windows.Forms.Label lblR3;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.RadioButton radEspacoFinal;
        private System.Windows.Forms.RadioButton radTempo;
        private System.Windows.Forms.RadioButton radVelocidade;
        private System.Windows.Forms.RadioButton radEspacoInicial;
        private System.Windows.Forms.TextBox txtEspacoFinal;
        private System.Windows.Forms.Label lblUnidadeEspacoFinal;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblUnidadeVelocidade;
        private System.Windows.Forms.Label lblUnidadeTempo;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.Label lblUnidadeEspacoInicial;
        private System.Windows.Forms.TextBox txtEspacoInicial;
        private System.Windows.Forms.Label lblEspaçoInicial;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblItensParaCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEquacaoT;
        private System.Windows.Forms.Label lblVezes;
        private System.Windows.Forms.Label lblEquacaoV;
        private System.Windows.Forms.Label lblMais;
        private System.Windows.Forms.Label lblEquacaoS0;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblEquacaoS;
        private System.Windows.Forms.Label lblEquacao;
    }
}

