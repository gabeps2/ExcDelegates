using System;

namespace ExcDelegates.Q1 {
    public static class Calculadora {

        public delegate int meuDelegate (int x, int y);
        public static meuDelegate[] vetDelegates;
        
        static public int soma (int a, int b) {
            return a + b;
        }

        static public int subtracao (int a, int b) {
            return a - b;
        }
        static public int divisao (int a, int b) {
            return a / b;
        }
        static public int multiplicacao (int a, int b) {
            return a * b;
        }
        static public int modulo (int a, int b) {
            return a % b;
        }
        public static void calcula(int numA, int numB, int posV)
        {
            vetDelegates = new meuDelegate[6];
            vetDelegates[1] = new meuDelegate (Calculadora.soma);
            vetDelegates[2] = new meuDelegate (Calculadora.subtracao);
            vetDelegates[3] = new meuDelegate (Calculadora.multiplicacao);
            vetDelegates[4] = new meuDelegate (Calculadora.divisao);
            vetDelegates[5] = new meuDelegate (Calculadora.modulo);

            while (true) 
            {
                try {
                    System.Console.WriteLine ("Resultado: " + (vetDelegates[posV] (numA, numB).ToString ("F1")));
                    break;
                } catch (DivideByZeroException) {
                    System.Console.Write ("Erro! Tentativa de divisão por zero.");
                } catch (FormatException) {
                    System.Console.WriteLine ("O número digitado não é valido.");
                }
            }

        }
    }
}