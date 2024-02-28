namespace Trabalho1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Calc calculo = new Calc();
            int sair = -1;
            while (sair != 0) {
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
                        Console.WriteLine("A unica opção disponivel para seu tipo de carro é etano!");
                        break;

                    case "flex":

                        Console.Write("Valor da gasolina:");
                        double v_gas = double.Parse(Console.ReadLine());

                        Console.Write("Valor do etanol:");
                        double v_eta = double.Parse(Console.ReadLine());

                        Console.WriteLine(calculo.calcular(carro.con_gas, carro.con_eta, v_gas, v_eta));
                        break;
                    case "editar":
                        Console.Write("Consumo de etanol: ");
                        double con_eta = double.Parse(Console.ReadLine());
                        Console.Write("Consumo de gasolina: ");
                        double con_gas = double.Parse(Console.ReadLine());

                        carro.editar_dados(con_gas, con_eta);

                        break;
                    case "sair":
                        Console.Write("Deseja mesmo sair (s/n):");
                        sair = Console.ReadLine() == "s" ? 0 : -1;

                        break;
                    default:
                        Console.WriteLine("Informe algo!");
                        break;
                }
            }
                    


            
            
        }

       
        
            
        
    }
}
