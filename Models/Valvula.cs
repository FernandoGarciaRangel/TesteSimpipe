using System;

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

        public static  double PressaoDescarga { get; set; }
        public static double PressaoSuccao { get; set; }
        public static double CoeficienteValvula { get; set; }
        public static double DensidadeRelativaProduto { get; set; }

         //<summary>
         //Método para calcular a vazão através da válvula.
         //Fórmula: Q = CV * sqrt((P2 - P1) / SG)
         //Retorna vazão em gpm (galões por minuto) assumindo pressão em psi.
         //</summary>
        public static double CalcularVazao()
        {
            // Proteção contra valores inválidos
            double diferencaPressao = PressaoDescarga - PressaoSuccao;
            if (diferencaPressao <= 0 || DensidadeRelativaProduto <= 0 || CoeficienteValvula <= 0)
            {
                return 0.0; // ou gerar exception, conforme a necessidade
            }

            return CoeficienteValvula * Math.Sqrt(diferencaPressao / DensidadeRelativaProduto);
        }

        /// <summary>
        /// Método para calcular o coeficiente de vazão (CV) quando já se conhece a vazão.
        /// Fórmula: CV = Q / sqrt((P2 - P1) / SG)
        /// </summary>
        public static double CalcularCoeficienteValvula(double vazao)
        {
            // Proteção contra valores inválidos
            double diferencaPressao = PressaoDescarga - PressaoSuccao;
            if (diferencaPressao <= 0 || DensidadeRelativaProduto <= 0)
            {
                return 0.0; // ou gerar exception
            }

            return vazao / Math.Sqrt(diferencaPressao / DensidadeRelativaProduto);
        }

        /// <summary>
        /// Método para calcular a perda de pressão através da válvula.
        /// Fórmula: ΔP = SG * (Q^2 / CV^2)
        /// </summary>
        public double CalcularPerdaPressao(double vazao)
        {
            // Proteção contra divisão por zero
            if (CoeficienteValvula == 0)
                return 0.0; // ou gerar exception

            return DensidadeRelativaProduto * Math.Pow(vazao, 2) / Math.Pow(CoeficienteValvula, 2);
        }

        // ---------------------------------------
        // Métodos de Conversão de Unidades
        // ---------------------------------------

        /// <summary>
        /// Converte um valor de pressão qualquer para psi.
        /// </summary>
        /// <param name="valor">Valor da pressão de entrada.</param>
        /// <param name="unidade">Unidade de entrada ("Pa", "kgf/cm²", ou "psi").</param>
        /// <returns>Retorna o valor convertido para psi.</returns>
        public static double ConverterPressaoParaPsi(double valor, string unidade)
        {
            if (unidade == "Pa")
            {
                valor = valor / 6894.757;   // 1 psi ~ 6894.757 Pa
            }
            else if (unidade == "kgf/cm²")
            {
                valor = valor * 14.2233;    // 1 kgf/cm² ~ 14.2233 psi
            }
            // Se for psi, não faz nada
            return valor;
        }

        /// <summary>
        /// Converte um valor de pressão em psi para outra unidade.
        /// </summary>
        /// <param name="valor">Valor da pressão em psi.</param>
        /// <param name="unidade">Unidade de destino ("Pa", "kgf/cm²", ou "psi").</param>
        /// <returns>Retorna o valor convertido.</returns>
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
            // Se for psi, não faz nada
            return valor;
        }

        /// <summary>
        /// Converte um valor de vazão qualquer para gpm.
        /// </summary>
        /// <param name="valor">Valor da vazão de entrada.</param>
        /// <param name="unidade">Unidade de entrada ("m³/s", "m³/h", ou "gpm").</param>
        /// <returns>Retorna o valor convertido para gpm.</returns>
        public static double ConverterVazaoParaGpm(double valor, string unidade)
        {
            if (unidade == "m³/s")
            {
                // 1 m³/s ~ 15850.323141489 gpm
                valor = valor * 15850.32;
            }
            else if (unidade == "m³/h")
            {
                // 1 m³/h ~ 4.403 gpm (aprox)
                // Exato: 1 m³/h = 0.27778... m³/s 
                // -> 0.27778 * 15850.32 = ~4403.05
                valor = valor * 264.172;
            }
            // Se for gpm, não faz nada
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
            // Se for gpm, não faz nada
            return valor;
        }
    }
}
