using System;

namespace ExcDelegates.Q2
{
    public static class TesteQ2
    {
        public static void testar()
        {
            System.Console.WriteLine ("Informe a operação: \n1 - Soma \n2 - Subtração \n3 - Multiplicação \n4 - Divisão \n5 - Modulo");
            int op = int.Parse (Console.ReadLine ());

            //System.Console.Write ("Informe o primeiro número: ");
            System.Console.WriteLine ("Primeiro número = 10,3");
            double numA = 10.3; //double.Parse (Console.ReadLine ());

            //System.Console.Write ("Informe o segundo número: ");
            System.Console.WriteLine ("Segundo número = 2,4");
            double numB = 2.4; //double.Parse (Console.ReadLine ());
            
            Real obj = new Real();
            obj.calcula (numA, numB, op);
        }
    }
}