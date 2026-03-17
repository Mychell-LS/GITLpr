using System;
namespace chell {
    class chell
    {
        static void call(string[] args)
        {
            double area;
            Console.WriteLine("Calculadora de area");
            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine());
            area = 3.14 * raio^2;
            Console.WriteLine("Eh: " + area);
        }
    }
}