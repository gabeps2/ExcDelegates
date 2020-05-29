using System;

namespace ExcDelegates.Q1 {
    public static class TesteQ1 {

        public static void testar () {
            System.Console.WriteLine ("Informe a operação: \n1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão \n5 - Modulo");
            int op = int.Parse (Console.ReadLine ());

            //System.Console.Write ("Informe o primeiro número: ");
            System.Console.WriteLine ("Primeiro número = 10");
            int numA = 10; //int.Parse (Console.ReadLine ());

            //System.Console.Write ("Informe o segundo número: ");
            System.Console.WriteLine ("Segundo número = 2");
            int numB = 2; //int.Parse (Console.ReadLine ());

            Calculadora.calcula (numA, numB, op);
        }
    }
}