using System;
namespace ABC {
    class ABC
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            Console.WriteLine("Digite o valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b");
            b = double.Parse(Console.ReadLine());
             Console.WriteLine("Digite o valor de c");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de d");
            d = double.Parse(Console.ReadLine());
            double resultadoab;
            resultadoab = a*b;
            double resultadocd;
            resultadocd = c*d; 
            double resultadot = resultadoab - resultadocd; 
            Console.WriteLine("Eh:"+ resultadot);
        }
    }
}
