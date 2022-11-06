using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Conta
{
    public partial class Conta : Form
    {
        public Conta()
        {
            InitializeComponent();
        }

        public string Name; //Variável que irá conter o Nome do Usuário
        public string Id; //Variável que irá conter o Número da conta

        public class Acount  //Criacão da classe
        {
            public double Saldo = 1000;

            public void Sacar(double valor)
            {
                Saldo -= valor;
            }
            public void Depositar(double valor)
            {
                Saldo += valor;
            }
        }

        Acount Objeto = new Acount(); //Instancia a Classe no Objeto

        double value; // Variável que vai conter o valor digitado no Input
        public void SetValue() // Função que vai passar o valor atual do input para a Variável "value"
        {
            value = Convert.ToDouble(Entrada.Text);
        }

        public void Mostrar() //Mostra o Valor do Saldo Atual na Tela
        {
            Saldo.Text = Convert.ToString(Objeto.Saldo);
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            if(Entrada.Text == "")
            {
                Entrada.Text = "0";
            }

            SetValue();
            Objeto.Sacar(value);
            Mostrar();
        }

        private void Deposito_Click(object sender, EventArgs e)
        {
            if (Entrada.Text == "")
            {
                Entrada.Text = "0";
            }

            SetValue();
            Objeto.Depositar(value);
            Mostrar();
        }

        private void Conta_Load(object sender, EventArgs e)
        {
            Mostrar();
            Entrada.Text = "0";
            UserName.Text = Name;
            UserId.Text = Id;
        }
    }
}
