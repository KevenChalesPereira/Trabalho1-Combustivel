namespace Trabalho1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Calc calculo = new Calc();
            int home = 1;
            string opcao;


            // UTILIZANOD WHILE, IF E ELSE PARA FAZER O MENU E TER TODOS OS CONCEITOS NO PROGRAMA

            while (home == 1)
            {
                Console.Clear();
                Console.WriteLine("========== MENU ==========");
                Console.WriteLine("1- Calcular Combustivel");
                Console.WriteLine("2- Editar Dados");
                Console.WriteLine("0- SAIR");
                Console.WriteLine("DICA: SE DESEJAR VOLTAR PARA HOME SÓ DIGITAR 'home' NO MEIO DO PROGRAMA");
                Console.WriteLine("==========================");
                opcao = Console.ReadLine();


                while (opcao != "1" && opcao != "2" && opcao != "0")
                {
                    Console.WriteLine("DIGITE UMA OPÇÃO VALIDA !!");
                    opcao = Console.ReadLine();
                }


                if (opcao == "1")
                {
                    Console.Clear();

                    home = 2;

                    while (home == 2)
                    {
                        

                        Console.Write("Informe o tipo do carro: gasolina, alcool ou flex: ");
                        carro.tipo_car = Console.ReadLine();

                        switch (carro.tipo_car)
                        {
                            case "gasolina":
                                Console.Write("Valor da gasolina:");
                                double gas = double.Parse(Console.ReadLine());
                                Console.WriteLine("A unica opção disponivel para seu tipo de carro é gasolina!");

                                Console.Write("Deseja continuar ? (s/n):");
                                home = Console.ReadLine() == "s" ? 2 : 1;
                                Console.Clear();

                                break;

                            case "alcool":
                                Console.Write("Valor do etanol:");
                                double eta = double.Parse(Console.ReadLine());
                                Console.WriteLine("A unica opção disponivel para seu tipo de carro é etanol!");

                                Console.Write("Deseja continuar ? (s/n):");
                                home = Console.ReadLine() == "s" ? 2 : 1;
                                Console.Clear();

                                break;

                            case "flex":

                                Console.Write("Valor da gasolina:");
                                double v_gas = double.Parse(Console.ReadLine());

                                Console.Write("Valor do etanol:");
                                double v_eta = double.Parse(Console.ReadLine());

                                Console.WriteLine(calculo.calcular(carro.con_gas, carro.con_eta, v_gas, v_eta));

                                Console.Write("Deseja continuar ? (s/n):");
                                home = Console.ReadLine() == "s" ? 2 : 1;
                                Console.Clear();

                                break;

                        
                            case "home":
                                Console.Write("Deseja mesmo voltar para home (s/n):");
                                home = Console.ReadLine() == "s" ? 1 : 2;

                                break;

                            default:
                                Console.WriteLine("Informe uma opção valida!");
                                break;

                                

                        }
                    }

                }

                if (opcao == "2")
                {
                    Console.Clear();
                    Console.Write("Digite o consumo do seu carro no etanol: ");
                    double con_eta = double.Parse(Console.ReadLine());
                    Console.Write("Digite o consumo do seu carro na gasolina: ");
                    double con_gas = double.Parse(Console.ReadLine());
                    carro.editar_dados(con_gas, con_eta);

                    home = 1;

                }

                if (opcao == "0")
                {
                    Console.Clear();
                    Console.WriteLine("VOCÊ SAIU DO PROGRAMA");
                    Environment.Exit(0);
                    home = 0;
                }

            }
            
            
        }

       
        
            
        
    }
}
