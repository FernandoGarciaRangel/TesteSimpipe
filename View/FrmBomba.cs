﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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


            inputFormula.Text = "Potência Hidráulica e do Motor";
        }
        public void validarNumeral(KeyPressEventArgs e)
        {
            char teclaDigitada = e.KeyChar;
            if (char.IsLetter(teclaDigitada) || char.IsWhiteSpace(teclaDigitada))
                e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var vazaoBombeio = Bomba.ConverterVazaoParaM3s(double.Parse(inputVazaoBombeio.Text), "m³/s");
            var pressaoSuccao = Bomba.ConverterPressaoParaPa(double.Parse(inputPressaoSuccao.Text), "kgf/cm²");
            var pressaoDescarga = Bomba.ConverterPressaoParaPa(double.Parse(inputPressaoDescarga.Text), "kgf/cm²");
            var eficienciaBomba = Bomba.ConverterParaPercentual(double.Parse(inputEficienciaBomba.Text));
            var eficienciaMotor = Bomba.ConverterParaPercentual(double.Parse(inputEficienciaMotor.Text));
            var fatorPotencia = double.Parse(inputFatorPotencia.Text, CultureInfo.InvariantCulture);
            Bomba bomba = new Bomba(pressaoDescarga, pressaoSuccao, vazaoBombeio, eficienciaBomba, eficienciaMotor, fatorPotencia);
            PotenciaHidraulicaInput.Text = bomba.CalcularPotenciaHidraulica(inputUnidadeMedida1.Text).ToString();
            PotenciaMotorInput.Text = bomba.CalcularPotenciaMotor(inputUnidadeMedida1.Text).ToString();

        }


        private void ValidarNumeral(object sender, KeyPressEventArgs e)
        {
            validarNumeral(e);
        }

    }
}