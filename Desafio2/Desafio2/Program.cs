using System;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UBUNTU 002 - START...");

            string nome1 = "Ubuntu1 Silva";
            int idade1 = 33;
            double peso1 = 88.5;
            decimal altura1 = 1.65M;
            bool EhDev1 = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.5;
            decimal altura2 = 2.1M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Selva";
            int idade3 = 85;
            double peso3 = 66.5;
            decimal altura3 = 1.4M;
            bool EhDev3 = false;

            int somaIdade = 0, contDev = 0;
            string nomeAll;
            double imc1, imc2, imc3;

            somaIdade = idade1 + idade2 + idade3;
            nomeAll = nome1 + " " + nome2 + " " + nome3;
            imc1 = peso1 / ((Double)altura1 * (Double)altura1);
            imc2 = peso2 / ((Double)altura2 * (Double)altura2);
            imc3 = peso3 / ((Double)altura3 * (Double)altura3);

            if (EhDev1)
                contDev++;
            if (EhDev2)
                contDev++;
            if (EhDev3)
                contDev++;

            /*Console.WriteLine("Idade de todos Ubuntus: " +somaIdade);
            Console.WriteLine("Nome de todos Ubuntus: " +nomeAll);
            Console.WriteLine("IMC do Ubuntu1: " + imc1.ToString("N2"));
            Console.WriteLine("IMC do Ubuntu2: " + imc2.ToString("N2"));
            Console.WriteLine("IMC do Ubuntu3: " + imc3.ToString("N2"));
            Console.WriteLine("Quantidade de Devs: " + contDev);*/

            if(nome1.Contains("Silva"))
                Console.WriteLine(nome1);
            if (nome2.Contains("Silva"))
                Console.WriteLine(nome2);
            if (nome3.Contains("Silva"))
                Console.WriteLine(nome3);

            Console.ReadKey();

            
        }
    }
}