using System;
namespace code
{
    class code
    {
        static void call(string[] args)
        {
            int numero;
            Console.WriteLine("bem vindo a seletor den--par");
            Console.WriteLine("Digite um número");
            numero = (int)Convert.ToInt64(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par");

            }
            else
            {
                Console.WriteLine("O número é impar");
            }



        }


    }


}