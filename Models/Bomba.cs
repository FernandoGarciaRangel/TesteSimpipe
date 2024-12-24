using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimpipe.Models
{
    public class Bomba{

        public Bomba()
        {

        }
        public Bomba(double pressaoDescarga, double pressaoSuccao, double vazaoVolumetrica, double eficienciaHidraulica, double eficienciaMotor, double fatorPotenciaMotor)
        {
            PressaoDescarga = pressaoDescarga;
            PressaoSuccao = pressaoSuccao;
            VazaoVolumetrica = vazaoVolumetrica;
            EficienciaHidraulica = eficienciaHidraulica;
            EficienciaMotor = eficienciaMotor;
            FatorPotenciaMotor = fatorPotenciaMotor;
        }

        public double PressaoDescarga { get; set; }
        public double PressaoSuccao { get; set; }
        public double VazaoVolumetrica { get; set; }
        public double EficienciaHidraulica { get; set; }
        public double EficienciaMotor { get; set; }
        public double FatorPotenciaMotor { get; set; }

        // Métodos de Cálculo
        public double CalcularPotenciaHidraulica()
        {
            return ((PressaoDescarga - PressaoSuccao) * VazaoVolumetrica) / EficienciaHidraulica;
        }

        public double CalcularPotenciaMotor()
        {
            double potenciaHidraulica = CalcularPotenciaHidraulica();
            return potenciaHidraulica / (EficienciaMotor * FatorPotenciaMotor);
        }

        // Métodos de Conversão
        public static double ConverterPressaoParaPa(double valor, string unidade)
        {            
            if(unidade == "kgf/cm²")
            {
                valor = valor * 98066.5;
            }
            else if (unidade == "psi")
            {
                valor = valor * 6894.757;
            }
            return valor;
          
        }

        public static double ConverterPressaoDePa(double valor, string unidade)
        {
            if(unidade == "kgf/cm²")
            {
                valor = valor / 98066.5;
            }else if (unidade == "kgf/cm²")
            {
                valor = valor / 6894.757;
            }
            return valor;
           
        }

        public static double ConverterVazaoParaM3s(double valor, string unidade)
        {
            if(unidade == "m³/h")
            {
                valor = valor / 3600;
            }else if(unidade == "gpm")
            {
                valor = valor / 15850.32;
            }
            return valor;
        }

        public static double ConverterVazaoDeM3s(double valor, string unidade)
        {
            if(unidade == "m³/h")
            {
                valor = valor * 3600;
            }else if(unidade == "gpm"){ 
                valor = valor * 15850.32;
            }
            return valor;
           
        }

        public static double ConverterPotenciaParaW(double valor, string unidade)
        {
            if (unidade == "kW")
            {
                valor = valor * 1000;
            }else if(unidade == "HP")
            {
                valor = valor * 745.7;
            }
            return valor;
        }

        public static double ConverterPotenciaDeW(double valor, string unidade)
        {
            if(unidade == "kW")
            {
                valor = valor / 1000;
            }else if(unidade == "HP")
            {
                valor = valor / 745.7;
            }
            return valor;
        }
    }

}

