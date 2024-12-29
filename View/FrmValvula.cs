using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteSimpipe.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TesteSimpipe
{
    public partial class FrmValvula : Form
    {
        public FrmValvula()
        {
            InitializeComponent();
        }

     
        public void validarNumeral(KeyPressEventArgs e)
        {
            char teclaDigitada = e.KeyChar;
            if (char.IsLetter(teclaDigitada) || char.IsWhiteSpace(teclaDigitada))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pressaoDescarga = double.Parse(inputPressaoDescarga.Text);
            double pressaoSuccao = double.Parse(inputPressaoSuccao.Text);
            double coeficienteValvula = double.Parse(inputCoeficienteValvula.Text);
            double densidadeRelativa = double.Parse(inputDensidadeRelativa.Text);

            double pressaoDescargaPsi = Valvula.ConverterPressaoParaPsi(pressaoDescarga, "psi");
            double pressaoSuccaoPsi = Valvula.ConverterPressaoParaPsi(pressaoSuccao, "psi");

           
            Valvula valvula = new Valvula(pressaoDescargaPsi, pressaoSuccaoPsi, coeficienteValvula, densidadeRelativa);

            double Q = valvula.CalcularVazao();
            double perdaPressao = valvula.CalcularPerdaPressao(Q);
            double CVcalculado = valvula.CalcularCoeficienteValvula(Q);

            if (inputFormula.Text == "Vazão Através da Válvula")
            {
                labelFormula.Text = "Vazão Através da Válvula";
                outputVazaoValvula.Text = Q.ToString();
            }
            else if (inputFormula.Text == "Perda de Pressão Através da Válvula")
            {
                labelFormula.Text = "Perda de Pressão Através da Válvula";
                outputVazaoValvula.Text = perdaPressao.ToString();
            }
            else if (inputFormula.Text == "Coeficiente de Vazão")
            {
                labelFormula.Text = "Coeficiente de Vazão";
                outputVazaoValvula.Text = CVcalculado.ToString();
            }
        }



        private void ValidarNumeral(object sender, KeyPressEventArgs e)
        {
            validarNumeral(e);
        }

        private void FrmValvula_Load(object sender, EventArgs e)
        {

        }

        private void inputDensidadeRelativa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

