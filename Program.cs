﻿namespace Trabalho1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Calc calculo = new Calc();

            Console.Write("Informe o tipo do carro: gasolina, alcool ou flex: ");
            carro.tipo_car = Console.ReadLine();

            switch (carro.tipo_car)
            {
                case "gasolina":
                    Console.Write("Valor da gasolina:");
                    double gas = double.Parse(Console.ReadLine());
                    Console.WriteLine("A unica opção disponivel para seu tipo de carro é gasolina!");
                    break;

                case "alcool":
                    Console.Write("Valor do etanol:");
                    double eta = double.Parse(Console.ReadLine());
                    Console.WriteLine("A unica opção disponivel para seu tipo de carro é etanol!");
                    break;

                case "flex":

                    Console.Write("Valor da gasolina:");
                    double v_gas = double.Parse(Console.ReadLine());

                    Console.Write("Valor do etanol:");
                    double v_eta = double.Parse(Console.ReadLine());

                    Console.WriteLine(calculo.calcular(carro.con_gas, carro.con_eta, v_gas, v_eta));
                    break;
                default:
                    Console.WriteLine("Informe algo!");
                    break;
            }
                    


            
            
        }

       
        
            
        
    }
}
