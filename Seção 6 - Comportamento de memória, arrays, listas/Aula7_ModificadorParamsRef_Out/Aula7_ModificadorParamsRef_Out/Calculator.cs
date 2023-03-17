using System;
using System.Globalization;

namespace Aula7_ModificadorParamsRef_Out {
    internal class Calculator {

        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void Tripli(int origin, out int reuslt) {
            reuslt = origin * 3;
        }

    }
}
