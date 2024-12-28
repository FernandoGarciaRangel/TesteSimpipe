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

        /// <summary>
        /// Impede que o usuário digite letras ou espaços em campos numéricos.
        /// </summary>
        public void validarNumeral(KeyPressEventArgs e)
        {
            char teclaDigitada = e.KeyChar;
            if (char.IsLetter(teclaDigitada) || char.IsWhiteSpace(teclaDigitada))
            {
                e.Handled = true;
            }
        }

        private void FrmValvula_Load(object sender, EventArgs e)
        {
            // Aqui poderia iniciar algo, se necessário
        }

        private void label26_Click(object sender, EventArgs e)
        {
            // Evento de label (sem uso)
        }

        private void label25_Click(object sender, EventArgs e)
        { }
     
        private void button1_Click(object sender, EventArgs e)       
        {
           
                // 1) Ler valores digitados (em psi)
                double pressaoDescarga = double.Parse(inputPressaoDescarga.Text);
                double pressaoSuccao = double.Parse(inputPressaoSuccao.Text);
                double coeficienteValvula = double.Parse(inputCoeficienteValvula.Text);
                double densidadeRelativa = double.Parse(inputDensidadeRelativa.Text);

                // 2) Se os valores já estão em psi, chame:
                //    ConverterPressaoParaPsi(valor, "psi") 
                //    ou nem chame e use direto.
                double pressaoDescargaPsi = Valvula.ConverterPressaoParaPsi(pressaoDescarga, "psi");
                double pressaoSuccaoPsi = Valvula.ConverterPressaoParaPsi(pressaoSuccao, "psi");

                // 3) Atribuir aos campos estáticos da classe Valvula
                Valvula.PressaoDescarga = pressaoDescargaPsi;
                Valvula.PressaoSuccao = pressaoSuccaoPsi;
                Valvula.CoeficienteValvula = coeficienteValvula;
                Valvula.DensidadeRelativaProduto = densidadeRelativa;

                // 4) Calcular vazão e perda de pressão
                double Q = Valvula.CalcularVazao();
                double perdaPressao = new Valvula(Valvula.PressaoDescarga,Valvula.PressaoSuccao,Valvula.CoeficienteValvula,Valvula.DensidadeRelativaProduto).CalcularPerdaPressao(Q);

                // 5) Calcular coeficiente (reverso)
                double CVcalculado = Valvula.CalcularCoeficienteValvula(Q);

            if(inputFormula.Text == "Vazão Através da Válvula") {
                labelFormula.Text = "Vazão Através da Válvula";
                outputVazaoValvula.Text = Q.ToString();
            }else if(inputFormula.Text == "Perda de Pressão Através da Válvula")
            {
                labelFormula.Text = "Perda de Pressão Através da Válvula";
                outputVazaoValvula.Text = perdaPressao.ToString();
            }else if (inputFormula.Text == "Coeficiente de Vazão"){
                labelFormula.Text = "Coeficiente de Vazão";
                outputVazaoValvula.Text = CVcalculado.ToString();
            }

                // 6) Exibir resultados
                MessageBox.Show(
                    $"Vazão (Q) = {Q}\n" +
                    $"ΔP = {perdaPressao}\n" +
                    $"CV calculado = {CVcalculado}"
                );
            }
           
           
              
          
        



        private void ValidarNumeral(object sender, KeyPressEventArgs e)
        {
            validarNumeral(e);
        }
    }
}

