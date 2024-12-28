using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSimpipe.Models
{
    public class Valvula
    {
        public Valvula()
        {
        }

        public Valvula(double pressaoDescarga, double pressaoSuccao, double coeficienteValvula, double densidadeRelativaProduto)
        {
            PressaoDescarga = pressaoDescarga;
            PressaoSuccao = pressaoSuccao;
            CoeficienteValvula = coeficienteValvula;
            DensidadeRelativaProduto = densidadeRelativaProduto;
        }

        public double PressaoDescarga { get; set; } 
        public double PressaoSuccao { get; set; } 
        public double CoeficienteValvula { get; set; } 
        public double DensidadeRelativaProduto { get; set; } 

        // Método para calcular a vazão através da válvula
        public double CalcularVazao()
        {
            return CoeficienteValvula * Math.Sqrt((PressaoDescarga - PressaoSuccao) / DensidadeRelativaProduto);
        }

        // Método para calcular a perda de pressão através da válvula
        public double CalcularPerdaPressao(double vazao)
        {
            return DensidadeRelativaProduto * Math.Pow(vazao, 2) / Math.Pow(CoeficienteValvula, 2);
        }

        // Métodos de Conversão
        public static double ConverterPressaoParaPsi(double valor, string unidade)
        {
            if (unidade == "Pa")
            {
                valor = valor / 6894.757;
            }
            else if (unidade == "kgf/cm²")
            {
                valor = valor * 14.2233;
            }
            return valor;
        }

        public static double ConverterPressaoDePsi(double valor, string unidade)
        {
            if (unidade == "Pa")
            {
                valor = valor * 6894.757;
            }
            else if (unidade == "kgf/cm²")
            {
                valor = valor / 14.2233;
            }
            return valor;
        }

        public static double ConverterVazaoParaGpm(double valor, string unidade)
        {
            if (unidade == "m³/s")
            {
                valor = valor * 15850.32;
            }
            else if (unidade == "m³/h")
            {
                valor = valor * 264.172;
            }
            return valor;
        }

        public static double ConverterVazaoDeGpm(double valor, string unidade)
        {
            if (unidade == "m³/s")
            {
                valor = valor / 15850.32;
            }
            else if (unidade == "m³/h")
            {
                valor = valor / 264.172;
            }
            return valor;
        }
    }
}

