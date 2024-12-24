using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        // Método calcular bomba
        private void button1_Click(object sender, EventArgs e)
        {
            PotenciaHidraulicaInput.Text = "";
            PotenciaMotorInput.Text = "";
            var msgErros = "";
            //Peguei



            var vazaoBombeio = Bomba.ConverterPressaoParaPa((double)inputVazaoBombeio.Value, "m³/h");
            var pressaoSuccao = Bomba.ConverterPressaoParaPa((double)inputPressaoSuccao.Value, "kgf/cm²");
            var pressaoDescarga = Bomba.ConverterPressaoParaPa((double)inputPressaoDescarga.Value, "kgf/cm²");
            var eficienciaBomba = ((double)inputEficienciaBomba.Value) * 100;
            var eficienciaMotor = ((double)inputEficienciaMotor.Value) * 100;
            var fatorPotencia = (double)inputFatorPotencia.Value;
            Bomba model = new Bomba(pressaoDescarga, pressaoSuccao, vazaoBombeio, eficienciaBomba, eficienciaMotor, fatorPotencia);


          

            PotenciaHidraulicaInput.Text = model.CalcularPotenciaHidraulica().ToString();
            PotenciaMotorInput.Text = model.CalcularPotenciaMotor().ToString();
 
            //ssMessageBox.Show(teste.ToString());
        }
    }
}
