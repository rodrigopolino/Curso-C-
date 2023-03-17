using System;
using System.Globalization;

namespace TerceiroExercicio {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double Conversao(double cotacao, double valor) {
            return (valor * cotacao) * (Iof / 100) + (valor * cotacao);
        }

    }
}
