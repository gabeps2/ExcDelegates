using System;

namespace ExcDelegates.Q2
{
    class Real:Numero
    {
        private double numPrivado;
        public delegate double meuDelegate (double x, double y);
        public static meuDelegate[] vetDelegates;
        public virtual double soma(double numA, double numB)
        {
            return numA+numB;
        }
        public virtual double subtracao (double a, double b) {
            return a - b;
        }
        public virtual double divisao (double a, double b) {
            return a / b;
        }
        public virtual double multiplicacao (double a, double b) {
            return a * b;
        }
        public virtual double modulo (double a, double b) {
            return a % b;
        }
        public virtual void calcula(double numA, double numB, int posV)
        {
            vetDelegates = new meuDelegate[6];
            vetDelegates[1] = new meuDelegate (soma);
            vetDelegates[2] = new meuDelegate (subtracao);
            vetDelegates[3] = new meuDelegate (multiplicacao);
            vetDelegates[4] = new meuDelegate (divisao);
            vetDelegates[5] = new meuDelegate (modulo);

            while (true) 
            {
                try {
                    System.Console.WriteLine ("Resultado: " + (vetDelegates[posV] (numA, numB).ToString ("F2")));
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