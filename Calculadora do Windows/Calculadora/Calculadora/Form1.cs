using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Input.Text = "0";
            prev.Text = "";
        }

        public decimal PrimeiroValor;
        public decimal SegundoValor;

        public string TipoDeOperacao;
        public bool TemPrev = false; //Variável que irá conter a informação se tem ou não um número no input "prev"
        public bool Invalid = false; //Variável que irá conter a informação se o cálculo foi inválido

        public void Invalido()
        {
            if (Invalid == true)
            {
                Delete();
                Invalid = false;
            }
        }

        public decimal Resultado;


        public void GetPrimeiroValor()  
        {
            PrimeiroValor = Convert.ToDecimal(Input.Text);
        }

        public void ShowValueInInput(string valor) //Mostra o valor dos botões no Input
        {
            Invalido();
            if (!TemPrev) //Se não tiver número no input "prev"
            {
                if (Input.Text == "0") //Retira o Zero Inicial
                {
                    Input.Text = "";
                }

                Input.Text += valor;
            }
            else
            {
                Input.Text = "";
                Input.Text += valor;
                TemPrev = false;
            }
        }

        public void ShowPrev() // Mostra o valor1 no input prev
        {
            prev.Text = Convert.ToString(PrimeiroValor) + " " + TipoDeOperacao;
            TemPrev = true;
        }


        /* Botões */

        private void Num0_Click(object sender, EventArgs e)
        {
            ShowValueInInput("0");
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            ShowValueInInput("1");
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            ShowValueInInput("2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            ShowValueInInput("3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            ShowValueInInput("4");
        }
        private void Num5_Click(object sender, EventArgs e)
        {
            ShowValueInInput("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            ShowValueInInput("6");
        }

        private void Num7_Click(object sender, EventArgs e)
        {
             ShowValueInInput("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            ShowValueInInput("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            ShowValueInInput("9");
        }

        private void Ponto_Click(object sender, EventArgs e)
        {
            Invalido();
            if (!Input.Text.Contains(",")){
                Input.Text += ",";
            }
        }

        

        /* Operadores */


        public void Operacao(string Tipo)
        {
            if(Invalid == false)
            {
                if (!TemPrev)
                {
                    GetPrimeiroValor();
                }
                TipoDeOperacao = Tipo;
                ShowPrev();
            }
            else {Invalido();}
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Operacao("÷");
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            Operacao("*");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Operacao("-");
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            Operacao("+");
        }


        /* Voltar apagar */

        public void Back()
        {
            if (TemPrev)
            {
                Input.Text = "0";
            }
            else
            {
                Input.Text = "0";
                prev.Text = "";
            }
        }

        public void Delete()
        {
            Input.Text = "0";
            prev.Text = "";
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            Delete();
        }


        /* Cálculo */

        public void Calcular()
        {
            Invalido();
            SegundoValor = Convert.ToDecimal(Input.Text);
            switch (TipoDeOperacao)
            {
                case "+":
                    Resultado = PrimeiroValor + SegundoValor;
                    break;
                case "-":
                    Resultado = PrimeiroValor - SegundoValor;
                    break;
                case "*":
                    Resultado = PrimeiroValor * SegundoValor;
                    break;
                case "÷":
                    if (SegundoValor == 0)
                    {
                        Invalid = true;
                        prev.Text = "";
                        Input.Text = "Cálculo Invalido";
                    }
                    else
                    {
                        Resultado = PrimeiroValor / SegundoValor;
                    }
                    break;
            }
            if (!Invalid)
            {
                Input.Text = Convert.ToString(Resultado);
                prev.Text = Convert.ToString(PrimeiroValor) + " + " + Convert.ToString(SegundoValor) + " = ";
            }
        }


        private void Calc_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        /* Lendo o teclado */

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                /* Números */
                case 96:
                case 48:
                    ShowValueInInput("0");
                    break;
                case 97:
                case 49:
                    ShowValueInInput("1");
                    break;
                case 98:
                case 50:
                    ShowValueInInput("2");
                    break;
                case 99:
                case 51:
                    ShowValueInInput("3");
                    break;
                case 100:
                case 52:
                    ShowValueInInput("4");
                    break;
                case 101:
                case 53:
                    ShowValueInInput("5");
                    break;
                case 102:
                case 54:
                    ShowValueInInput("6");
                    break;
                case 103:
                case 55:
                    ShowValueInInput("7");
                    break;
                case 104:
                case 56:
                    ShowValueInInput("8");
                    break;
                case 105:
                case 57:
                    ShowValueInInput("9");
                    break;

                /* Voltar e Apagar */
                case 8:
                    Back();
                    break;

                case 27:
                    Delete();
                    break;

                /* Operadores  */
                case 107:
                    Operacao("+");
                    break;
                case 109:
                    Operacao("-");
                    break;
                case 106:
                    Operacao("*");
                    break;
                case 111:
                    Operacao("÷");
                    break;

                /* Virgula */
                case 110:
                case 188:
                case 190:
                    if (!Input.Text.Contains(","))
                    {
                        Input.Text += ",";
                    }
                    break;
                /* Enter */
                case 13:
                    Calcular();
                    break;
            }
        }
    }
}
