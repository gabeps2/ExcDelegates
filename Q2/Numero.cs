using System;

namespace ExcDelegates.Q2
{
    interface Numero
    {
        double soma(double numA, double numB);
        double subtracao(double numA, double numB);
        double multiplicacao(double numA, double numB);
        double divisao(double numA, double numB);
        double modulo(double numA, double numB);
        void calcula(double numA, double numB, int posV);
    }
}
