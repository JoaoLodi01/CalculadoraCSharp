using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CalculadoraC_;


namespace CalculadoraC_
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool porcentagem = false;
        bool resultado = false;

        public object TextBox1 { get; private set; }

        public Form1()
        {
            this.KeyPreview = true;

            this.KeyDown += (sender, e) => Atalhos(e);

            InitializeComponent();

        }
        private void Um_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text += "1";

        }

        private void Dois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox2.Text += "2";
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox2.Text += "3";
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox2.Text += "4";
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox2.Text += "5";
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox2.Text += "6";
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox2.Text += "7";
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox2.Text += "8";
        }
        private void Nove_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox2.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox2.Text += "0";
        }

        private void Igualdade_Click(object sender, EventArgs e)
        {
            resultado = true;

            textBox2.Text += "=";

            if (adicao == true)
            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) + calculo);

                textBox2.Text += textBox1.Text;
            }

            if (subtracao == true)
            {
                textBox1.Text = Convert.ToString(calculo - Convert.ToDecimal(textBox1.Text));

                textBox2.Text += textBox1.Text;
            }

            if (multiplicacao == true)
            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) * calculo);

                textBox2.Text += textBox1.Text;
            }

            if (divisao == true)
            {
                textBox1.Text = Convert.ToString(calculo / Convert.ToDecimal(textBox1.Text));

                textBox2.Text += textBox1.Text;
            }
        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            textBox2.Text += ",";
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(textBox2.Text);

                textBox1.Text = "";
                textBox2.Text += "÷";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }
        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(textBox2.Text);

                textBox1.Text = "";
                textBox2.Text += "*";
                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(textBox2.Text);

                textBox1.Text = "";

                textBox2.Text += "-";

                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(textBox2.Text);

                textBox1.Text = "";

                textBox2.Text += "+";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
            }
            catch
            {
                MessageBox.Show("Operação incorreta");
            }
        }
        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Porcentagem_Click(object sender, EventArgs e)
        {
            if (subtracao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;

                textBox1.Text = Convert.ToString(valor1 - (percentual * valor1));
                textBox2.Text += "%";
                textBox2.Text += textBox1.Text;
            }

            else if (adicao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;

                textBox1.Text = Convert.ToString(valor1 + (percentual * valor1));
                textBox2.Text += "%";
                textBox2.Text += textBox1.Text;
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = textBox1.Text;

                apagar = apagar.Remove(apagar.Length - 1);

                textBox1.Text = apagar;
                textBox2.Text = apagar;
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atalhos(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    Zero.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    Um.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    Dois.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    Tres.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    Quatro.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    Cinco.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    Seis.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    Sete.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    Oito.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    Nove.PerformClick();
                    break;
                case Keys.Oemcomma:
                case Keys.Decimal:
                    Virgula.PerformClick();
                    break;
                case Keys.Add:
                    Adicao.PerformClick();
                    break;
                case Keys.Subtract:
                    Subtracao.PerformClick();
                    break;
                case Keys.Divide:
                    Divisao.PerformClick();
                    break;
                case Keys.Escape:
                case Keys.Delete:
                    Limpar.PerformClick();
                    break;
            }
        }
    }
}

