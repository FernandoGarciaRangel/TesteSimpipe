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

namespace TesteSimpipe
{
    public partial class FrmBomba : Form
    {
        public FrmBomba()
        {
            InitializeComponent();
            //DADOS PARA TESTE
            inputVazaoBombeio.Text = "3600";
            inputPressaoSuccao.Text = "1";
            inputPressaoDescarga.Text = "5";
            inputEficienciaBomba.Text = "85";
            inputEficienciaMotor.Text = "90";
            inputFatorPotencia.Text = "0.95";
            inputFormula.Text = "Potência Hidráulica e do Motor";
        }
        public void validarNumeral(KeyPressEventArgs e)
        {
            char teclaDigitada = e.KeyChar;
            if (char.IsLetter(teclaDigitada) || char.IsWhiteSpace(teclaDigitada))
                e.Handled = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        // Método calcular bomba
        private void button1_Click(object sender, EventArgs e)
        {    
                var vazaoBombeio = Bomba.ConverterVazaoParaM3s(double.Parse(inputVazaoBombeio.Text), "m³/s");
                var pressaoSuccao = Bomba.ConverterPressaoParaPa(double.Parse(inputPressaoSuccao.Text), "kgf/cm²");
                var pressaoDescarga = Bomba.ConverterPressaoParaPa(double.Parse(inputPressaoDescarga.Text), "kgf/cm²");
                var eficienciaBomba = Bomba.ConverterParaPercentual(double.Parse(inputEficienciaBomba.Text));
                var eficienciaMotor = Bomba.ConverterParaPercentual(double.Parse(inputEficienciaMotor.Text));
                var fatorPotencia = double.Parse(inputFatorPotencia.Text, CultureInfo.InvariantCulture);
                Bomba bomba = new Bomba(pressaoDescarga, pressaoSuccao, vazaoBombeio, eficienciaBomba, eficienciaMotor, fatorPotencia);
                PotenciaHidraulicaInput.Text = bomba.CalcularPotenciaHidraulica().ToString();
                PotenciaMotorInput.Text = bomba.CalcularPotenciaMotor().ToString();

            MessageBox.Show("Deu certo");
 
            //ssMessageBox.Show(teste.ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidarNumeral(object sender, KeyPressEventArgs e)
        {
            validarNumeral(e);
        }

        private void FrmBomba_Load(object sender, EventArgs e)
        {

        }
    }
}
