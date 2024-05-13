using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*namespace SaimonCu.fe_n
{
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calcular()
        {
            try
            {
                //Declaro as variáveis, as converto para decimal e as jogo nos labels
                decimal nota1, nota2, nota3, nota4, maiornota, menornota, media;

                nota1 = Convert.ToDecimal(txtNota1.Text);
                nota2 = Convert.ToDecimal(txtNota2.Text);
                nota3 = Convert.ToDecimal(txtNota3.Text);
                nota4 = Convert.ToDecimal(txtNota4.Text);
                maiornota = Convert.ToDecimal(IsTextValidated(lblMaiorNota.Text));
                menornota = Convert.ToDecimal(IsTextValidated(lblMenorNota.Text));
                media = Convert.ToDecimal(IsTextValidated(lblMedia.Text));

                //Teste condicional para descobrir qual é a maior nota
                if (nota1 > nota2 && nota1 > nota3 && nota1 > nota4)
                {
                    maiornota = nota1;
                }
                else if (nota2 > nota1 && nota2 > nota3 && nota2 > nota4)
                {
                    maiornota = nota2;
                }
                else if (nota3 > nota1 && nota3 > nota2 && nota3 > nota4)
                {
                    maiornota = nota3;
                }
                else
                {
                    maiornota = nota4;
                }

                //Teste condicional para descobrir qual é a menor nota
                if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4)
                {
                    menornota = nota1;
                }
                else if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4)
                {
                    menornota = nota2;
                }
                else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4)
                {
                    menornota = nota3;
                }
                else
                {
                    menornota = nota4;
                }

                //Faço a conversão dos valores das labels para string
                lblMaiorNota.Text = maiornota.ToString();
                lblMenorNota.Text = menornota.ToString();

                //Calculo a média das notas e as armazeno na label
                media = (nota1 + nota2 + nota3 + nota4) / 4;
                lblMedia.Text = media.ToString();
            }

            catch (FormatException)
            {
                //Caso ocorra algum erro, apresento uma mensagem ao usuário
                MessageBox.Show("Digite números de 0 a 10, com ou sem vírgulas",
                "Mensagem do Sistema");
            }
        }

        private bool IsTextValidated(string strTextEntry)
        {
            //Método para não deixar o label vazio, senão dá erro de InvalidCast
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strTextEntry);
        }

        public void Limpar()
        {
            //Limpo as variáveis
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            lblMaiorNota.Text = "";
            lblMenorNota.Text = "";
            lblMedia.Text = "";
            lblResultado.Text = "";
        }

        public void Sair()
        {
            //Crio o método para o botão Sair
            DialogResult result;

            result = MessageBox.Show("Tem certeza que deseja sair?",
            "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Teste condicional para aceitar números no textbox
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            //Teste condicional para aceitar a tecla Backspace e vírgula
            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void txtNota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.Handled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}


namespace SaimonCu.fe_n
{
    internal class pepe
    {
    }
}
*/
