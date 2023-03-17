using System;

namespace Aula6_Params {
    internal class Calculator {

        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) { //quantidade dos numeros 
                sum += numbers[i];
            }
            return sum;

        }
    }
}
