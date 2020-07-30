using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRU
{
    public partial class fundo : Form
    {
        
        public fundo()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DialogResult resposta = DialogResult.Yes;
            float resultado = 0;
            float espacoFinal = 0;
            float espacoInicial = 0;
            float velocidade = 0;
            float tempo = 0;
            
            if (radEspacoFinal.Checked)
            {
                txtEspacoInicial.Focus();
                txtEspacoInicial.TabIndex = 1;
                txtVelocidade.TabIndex = 2;
                txtTempo.TabIndex = 3;
                btnCalcular.TabIndex = 4;
                btnNovo.TabIndex = 5;
                btnSair.TabIndex = 6;
                btnHelp.TabIndex = 7;

                if (txtEspacoInicial.Text != "")
                {
                    espacoInicial = Convert.ToSingle(txtEspacoInicial.Text);
                }
                if (txtVelocidade.Text != "")
                {
                    velocidade = Convert.ToSingle(txtVelocidade.Text);
                }
                if (txtTempo.Text != "")
                {
                    tempo = Convert.ToSingle(txtTempo.Text);
                }

                if (txtEspacoInicial.Text == "" || txtVelocidade.Text == "" || txtTempo.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtEspacoInicial.Text == "")
                        {
                            txtEspacoInicial.Text = "0";
                            lblEquacaoS0.Text = "0";
                        }
                        if (txtVelocidade.Text == "")
                        {
                            txtVelocidade.Text = "0";
                            lblEquacaoV.Text = "0";
                        }
                        if (txtTempo.Text == "")
                        {
                            txtTempo.Text = "0";
                            lblEquacaoT.Text = "0";
                        }
                    }
                    else if (resposta == DialogResult.No)
                    {
                        txtEspacoFinal.Text = "";
                        txtEspacoInicial.Text = "";
                        txtVelocidade.Text = "";
                        txtTempo.Text = "";
                        lblResult.Text = "";
                    }
                }
                resultado = EspacoFinal(espacoInicial, velocidade, tempo);
                lblResult.Text = resultado.ToString();
                espacoFinal = resultado;
                lblEquacaoS.Text = espacoFinal.ToString();
                lblEquacaoS0.Text = espacoInicial.ToString();
                lblEquacaoV.Text = velocidade.ToString();
                lblEquacaoT.Text = tempo.ToString();
            }
            else if (radVelocidade.Checked)
            {
                txtEspacoFinal.Focus();
                txtEspacoFinal.TabIndex = 1;
                txtEspacoInicial.TabIndex = 2;
                txtTempo.TabIndex = 3;
                btnCalcular.TabIndex = 4;
                btnNovo.TabIndex = 5;
                btnSair.TabIndex = 6;
                btnHelp.TabIndex = 7;

                if (txtEspacoFinal.Text != "")
                {
                    espacoFinal = Convert.ToSingle(txtEspacoFinal.Text);
                }
                if (txtEspacoInicial.Text != "")
                {
                    espacoInicial = Convert.ToSingle(txtEspacoInicial.Text);
                }
                if (txtTempo.Text != "")
                {
                    tempo = Convert.ToSingle(txtTempo.Text);
                }
                if (txtEspacoInicial.Text == "" || txtEspacoFinal.Text == "" || txtTempo.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtEspacoInicial.Text == "")
                        {
                            txtEspacoInicial.Text = "0";
                            lblEquacaoS0.Text = "0";
                        }
                        if (txtEspacoFinal.Text == "")
                        {
                            txtEspacoFinal.Text = "0";
                            lblEquacaoS.Text = "0";
                        }
                        if (txtTempo.Text == "")
                        {
                            txtTempo.Text = "0";
                            lblEquacaoT.Text = "0";
                        }
                    }
                    else if (resposta == DialogResult.No)
                    {
                        txtEspacoFinal.Text = "";
                        txtEspacoInicial.Text = "";
                        txtVelocidade.Text = "";
                        txtTempo.Text = "";
                        lblResult.Text = "";
                    }
                }
                resultado = Velocidade(espacoInicial, tempo, espacoFinal);
                lblResult.Text = resultado.ToString();
                velocidade = resultado;
                lblEquacaoS.Text = espacoFinal.ToString();
                lblEquacaoS0.Text = espacoInicial.ToString();
                lblEquacaoV.Text = velocidade.ToString();
                lblEquacaoT.Text = tempo.ToString();
            }
            else if (radTempo.Checked)
            {
                txtEspacoFinal.Focus();
                txtEspacoFinal.TabIndex = 1;
                txtEspacoInicial.TabIndex = 2;
                txtVelocidade.TabIndex = 3;
                btnCalcular.TabIndex = 4;
                btnNovo.TabIndex = 5;
                btnSair.TabIndex = 6;
                btnHelp.TabIndex = 7;
                if (txtEspacoFinal.Text != "")
                {
                    espacoFinal = Convert.ToSingle(txtEspacoFinal.Text);
                }
                if (txtEspacoInicial.Text != "")
                {
                    espacoInicial = Convert.ToSingle(txtEspacoInicial.Text);
                }
                if (txtVelocidade.Text != "")
                {
                    velocidade = Convert.ToSingle(txtVelocidade.Text);
                }
                if (txtEspacoInicial.Text == "" || txtEspacoFinal.Text == "" || txtVelocidade.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtEspacoInicial.Text == "")
                        {
                            txtEspacoInicial.Text = "0";
                            lblEquacaoS0.Text = "0";
                        }
                        if (txtEspacoFinal.Text == "")
                        {
                            txtEspacoFinal.Text = "0";
                            lblEquacaoS.Text = "0";
                        }
                        if (txtVelocidade.Text == "")
                        {
                            txtVelocidade.Text = "0";
                            lblEquacaoV.Text = "0";
                        }
                    }
                    else if (resposta == DialogResult.No)
                    {
                        txtEspacoFinal.Text = "";
                        txtEspacoInicial.Text = "";
                        txtVelocidade.Text = "";
                        txtTempo.Text = "";
                        lblResult.Text = "";
                    }
                }
                resultado = Tempo(espacoInicial, velocidade, espacoFinal);
                lblResult.Text = resultado.ToString();
                tempo = resultado;
                lblEquacaoS.Text = espacoFinal.ToString();
                lblEquacaoS0.Text = espacoInicial.ToString();
                lblEquacaoV.Text = velocidade.ToString();
                lblEquacaoT.Text = tempo.ToString();
            }
            else if (radEspacoInicial.Checked)
            {
                txtEspacoFinal.Focus();
                txtEspacoFinal.TabIndex = 1;
                txtVelocidade.TabIndex = 2;
                txtTempo.TabIndex = 3;
                btnCalcular.TabIndex = 4;
                btnNovo.TabIndex = 5;
                btnSair.TabIndex = 6;
                btnHelp.TabIndex = 7;
                if (txtEspacoFinal.Text != "")
                {
                    espacoFinal = Convert.ToSingle(txtEspacoFinal.Text);
                }
                if (txtVelocidade.Text != "")
                {
                    velocidade = Convert.ToSingle(txtVelocidade.Text);
                }
                if (txtTempo.Text != "")
                {
                    tempo = Convert.ToSingle(txtTempo.Text);
                }
                if (txtTempo.Text == "" || txtEspacoFinal.Text == "" || txtVelocidade.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtTempo.Text == "")
                            txtTempo.Text = "0";
                        if (txtEspacoFinal.Text == "")
                            txtEspacoFinal.Text = "0";
                        if (txtVelocidade.Text == "")
                            txtVelocidade.Text = "0"; 
                    }
                    else if (resposta == DialogResult.No)
                    {
                        txtEspacoFinal.Text = "";
                        txtEspacoInicial.Text = "";
                        txtVelocidade.Text = "";
                        txtTempo.Text = "";
                        lblResult.Text = "";
                    }
                }
                resultado = EspacoInicial(velocidade, tempo, espacoFinal);
                lblResult.Text = resultado.ToString();
                espacoInicial = resultado;
                lblEquacaoS.Text = espacoFinal.ToString();
                lblEquacaoS0.Text = espacoInicial.ToString();
                lblEquacaoV.Text = velocidade.ToString();
                lblEquacaoT.Text = tempo.ToString();
            }

            radEspacoFinal.Visible = false;
            radEspacoInicial.Visible = false;
            radVelocidade.Visible = false;
            radTempo.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtEspacoFinal.Clear();
            txtEspacoInicial.Clear();
            txtVelocidade.Clear();
            txtTempo.Clear();
            if (radEspacoInicial.Checked || radVelocidade.Checked || radTempo.Checked)
                txtEspacoFinal.Focus();
            else if (radEspacoFinal.Checked)
                txtEspacoInicial.Focus();
            lblResult.Text = "";
            radEspacoFinal.Visible = true;
            radEspacoInicial.Visible = true;
            radVelocidade.Visible = true;
            radTempo.Visible = true;
            lblEquacaoS.Text = "S";
            lblEquacaoS0.Text = "S0";
            lblEquacaoV.Text = "v";
            lblEquacaoT.Text = "t";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você quer mesmo sair?", "Cálculo do MRU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        private void radKmh_CheckedChanged(object sender, EventArgs e)
        {
            if(radKmh.Checked)
            {
                //  m/s -> km/h
                lblUnidadeEspacoInicial.Text = "Km";
                lblUnidadeVelocidade.Text = "Km/h";
                lblUnidadeTempo.Text = "h";
                lblUnidadeEspacoFinal.Text = "Km";

                double S0 = 0;
                double v = 0;
                double t = 0;
                double S = 0;
                double R = 0;

                if (radEspacoFinal.Checked)
                {
                    R = double.Parse(lblResult.Text) / 1000;
                    S0 = double.Parse(txtEspacoInicial.Text) / 1000;
                    v = double.Parse(txtVelocidade.Text) * 3.6;
                    t = double.Parse(txtTempo.Text) / 3600;
                    lblUnidadeResult.Text = "Km";
                    lblEquacaoS.Text = R.ToString();
                    lblEquacaoS0.Text = S0.ToString();
                    lblEquacaoV.Text = v.ToString();
                    lblEquacaoT.Text = t.ToString();
                }
                if (radEspacoInicial.Checked)
                {
                    S = double.Parse(txtEspacoFinal.Text) / 1000;
                    R = double.Parse(lblResult.Text) / 1000;
                    v = double.Parse(txtVelocidade.Text) * 3.6;
                    t = double.Parse(txtTempo.Text) / 3600;
                    lblUnidadeResult.Text = "Km";
                    lblEquacaoS.Text = S.ToString();
                    lblEquacaoS0.Text = R.ToString();
                    lblEquacaoV.Text = v.ToString();
                    lblEquacaoT.Text = t.ToString();
                }
                if (radVelocidade.Checked)
                {
                    S = double.Parse(txtEspacoFinal.Text) / 1000;
                    S0 = double.Parse(txtEspacoInicial.Text) / 1000;
                    R = double.Parse(lblResult.Text) * 3.6;
                    t = double.Parse(txtTempo.Text) / 3600;
                    lblUnidadeResult.Text = "Km/h";
                    lblEquacaoS.Text = S.ToString();
                    lblEquacaoS0.Text = S0.ToString();
                    lblEquacaoV.Text = R.ToString();
                    lblEquacaoT.Text = t.ToString();
                }
                if (radTempo.Checked)
                {
                    S = double.Parse(txtEspacoFinal.Text) / 1000;
                    S0 = double.Parse(txtEspacoInicial.Text) / 1000;
                    v = double.Parse(txtVelocidade.Text) * 3.6;
                    R = double.Parse(lblResult.Text) / 3600;
                    lblUnidadeResult.Text = "s";
                    lblEquacaoS.Text = S.ToString();
                    lblEquacaoS0.Text = S0.ToString();
                    lblEquacaoV.Text = v.ToString();
                    lblEquacaoT.Text = R.ToString();
                }

                txtEspacoFinal.Text = S.ToString();
                txtEspacoInicial.Text = S0.ToString();
                txtVelocidade.Text = v.ToString();
                txtTempo.Text = t.ToString();
                lblResult.Text = R.ToString();

                //btnNovo.Focus();
            }
        }

        private void radMs_CheckedChanged(object sender, EventArgs e)
        {
            if (radMs.Checked)
            {
                //  km/h -> m/s
                lblUnidadeEspacoInicial.Text = "m";
                lblUnidadeVelocidade.Text = "m/s";
                lblUnidadeTempo.Text = "s";
                lblUnidadeEspacoFinal.Text = "m";

                double S0 = 0;
                double v = 0;
                double t = 0;
                double S = 0;
                double R = 0;

                if (radEspacoFinal.Checked)
                {
                    R = double.Parse(lblResult.Text) * 1000;
                    S0 = double.Parse(txtEspacoInicial.Text) * 1000;
                    v = double.Parse(txtVelocidade.Text) / 3.6;
                    t = double.Parse(txtTempo.Text) * 3600;
                    lblUnidadeResult.Text = "m";
                    lblEquacaoS.Text = R.ToString();
                    lblEquacaoS0.Text = S0.ToString();
                    lblEquacaoV.Text = v.ToString();
                    lblEquacaoT.Text = t.ToString();
                }
                if (radEspacoInicial.Checked)
                {
                    S = double.Parse(txtEspacoFinal.Text) * 1000;
                    R = double.Parse(lblResult.Text) * 1000;
                    v = double.Parse(txtVelocidade.Text) / 3.6;
                    t = double.Parse(txtTempo.Text) * 3600;
                    lblUnidadeResult.Text = "m";
                    lblEquacaoS.Text = S.ToString();
                    lblEquacaoS0.Text = R.ToString();
                    lblEquacaoV.Text = v.ToString();
                    lblEquacaoT.Text = t.ToString();
                }
                if (radVelocidade.Checked)
                {
                    S = double.Parse(txtEspacoFinal.Text) * 1000;
                    S0 = double.Parse(txtEspacoInicial.Text) * 1000;
                    R = double.Parse(lblResult.Text) / 3.6;
                    t = double.Parse(txtTempo.Text) * 3600;
                    lblUnidadeResult.Text = "m/s";
                    lblEquacaoS.Text = S.ToString();
                    lblEquacaoS0.Text = S0.ToString();
                    lblEquacaoV.Text = R.ToString();
                    lblEquacaoT.Text = t.ToString();
                }
                if (radTempo.Checked)
                {
                    S = double.Parse(txtEspacoFinal.Text) * 1000;
                    S0 = double.Parse(txtEspacoInicial.Text) * 1000;
                    v = double.Parse(lblResult.Text) / 3.6;
                    R = double.Parse(lblResult.Text) * 3600;
                    lblUnidadeResult.Text = "s";
                    lblEquacaoS.Text = S.ToString();
                    lblEquacaoS0.Text = S0.ToString();
                    lblEquacaoV.Text = v.ToString();
                    lblEquacaoT.Text = R.ToString();
                }

                txtEspacoInicial.Text = S0.ToString();
                txtEspacoFinal.Text = S.ToString();
                txtVelocidade.Text = v.ToString();
                txtTempo.Text = t.ToString();
                lblResult.Text = R.ToString();

                //btnNovo.Focus();
            }
        }

        private float EspacoFinal (float espacoInicial, float velocidade, float tempo)
        {
            float espacoFinal = 0;
            espacoFinal = espacoInicial + velocidade * tempo;
            return espacoFinal;
        }

        private float Velocidade (float espacoInicial, float tempo, float espacoFinal)
        {
            float velocidade = 0;
            if (tempo == 0)
                return 0;
            else
                velocidade = (espacoFinal - espacoInicial) / tempo;
            return velocidade;
        }

        private float Tempo (float espacoInicial, float velocidade, float espacoFinal)
        {
            float tempo = 0;
            if (velocidade == 0)
                return 0;
            else
                tempo = (espacoFinal - espacoInicial) / velocidade;
            return tempo;
        }
        private float EspacoInicial (float velocidade, float tempo, float espacoFinal)
        {
            float espacoInicial = 0;
            espacoInicial = espacoFinal - velocidade * tempo;
            return espacoInicial;
        }

        private void radEspacoFinal_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radEspacoFinal.Checked)
            {
                txtEspacoInicial.Focus();

                lblR1.Visible = true;
                lblR2.Visible = false;
                lblR3.Visible = false;
                lblR4.Visible = false;

                txtEspacoFinal.Visible = false;
                txtEspacoInicial.Visible = true;
                txtVelocidade.Visible = true;
                txtTempo.Visible = true;

                lblUnidadeEspacoFinal.Visible = false;
                lblUnidadeEspacoInicial.Visible = true;
                lblUnidadeVelocidade.Visible = true;
                lblUnidadeTempo.Visible = true;

                lblUnidadeResult.Text = "Km";
                lblR.Text = "(S):";

                //txtEspacoFinal.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtEspacoInicial.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtVelocidade.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtTempo.Text = ?; //mostrar o valor correto para a equação fazer sentido
                lblResult.Text = txtEspacoFinal.Text; //o valor do resultado mudou e faz sentido!
            }
        }

        private void radEspacoInicial_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radEspacoInicial.Checked)
            {
                txtEspacoFinal.Focus();

                lblR1.Visible = false;
                lblR2.Visible = true;
                lblR3.Visible = false;
                lblR4.Visible = false;

                txtEspacoFinal.Visible = true;
                txtEspacoInicial.Visible = false;
                txtVelocidade.Visible = true;
                txtTempo.Visible = true;

                lblUnidadeEspacoFinal.Visible = true;
                lblUnidadeEspacoInicial.Visible = false;
                lblUnidadeVelocidade.Visible = true;
                lblUnidadeTempo.Visible = true;

                lblUnidadeResult.Text = "Km";
                lblR.Text = "(S0):";

                //txtEspacoFinal.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtEspacoInicial.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtVelocidade.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtTempo.Text = ?; //mostrar o valor correto para a equação fazer sentido
                lblResult.Text = txtEspacoInicial.Text; //o valor do resultado mudou e faz sentido!
            }
        }

        private void radVelocidade_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radVelocidade.Checked)
            {
                txtEspacoFinal.Focus();

                lblR1.Visible = false;
                lblR2.Visible = false;
                lblR3.Visible = true;
                lblR4.Visible = false;

                txtEspacoFinal.Visible = true;
                txtEspacoInicial.Visible = true;
                txtVelocidade.Visible = false;
                txtTempo.Visible = true;

                lblUnidadeEspacoFinal.Visible = true;
                lblUnidadeEspacoInicial.Visible = true;
                lblUnidadeVelocidade.Visible = false;
                lblUnidadeTempo.Visible = true;

                lblUnidadeResult.Text = "Km/h";
                lblR.Text = "(v):";

                //txtEspacoFinal.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtEspacoInicial.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtVelocidade.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtTempo.Text = ?; //mostrar o valor correto para a equação fazer sentido
                lblResult.Text = txtVelocidade.Text; //o valor do resultado mudou e faz sentido!
            }
        }

        private void radTempo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radTempo.Checked)
            {

                txtEspacoFinal.Focus();

                lblR1.Visible = false;
                lblR2.Visible = false;
                lblR3.Visible = false;
                lblR4.Visible = true;

                txtEspacoFinal.Visible = true;
                txtEspacoInicial.Visible = true;
                txtVelocidade.Visible = true;
                txtTempo.Visible = false;

                lblUnidadeEspacoFinal.Visible = true;
                lblUnidadeEspacoInicial.Visible = true;
                lblUnidadeVelocidade.Visible = true;
                lblUnidadeTempo.Visible = false;

                lblUnidadeResult.Text = "h";
                lblR.Text = "(t):";

                //txtEspacoFinal.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtEspacoInicial.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtVelocidade.Text = ?; //mostrar o valor correto para a equação fazer sentido
                //txtTempo.Text = ?; //mostrar o valor correto para a equação fazer sentido
                lblResult.Text = txtTempo.Text; //o valor do resultado mudou e faz sentido!
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções de uso: \n\n1) selecione o campo que " +
                "deseja calcular: 'S', 'S0', 'v' ou 't';" +
                "\n\n2) para calcular, clique no botão 'Calcular' ou ALT+C;" +
                "\n\n3) para converter, clique no botão 'Km/h' ou 'm/s'" +
                "\n\n4) para limpar a tela, clique no botão 'Novo' ou ALT+N" +
                "\n\n5) para sair, clique no botão 'Sair' ou ALT+R ou no X vermelho " +
                "\n(canto superior direito)" +
                "\n\n\nObrigado por utilizar minha calculadora de MRU!" +
                "\nDeveloped by: Dieguito (72B - 2020)   -->   (14)99101-5057 ", "Ajuda do desenvolvedor");
        }

        private void txtEspacoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEspacoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtVelocidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
   