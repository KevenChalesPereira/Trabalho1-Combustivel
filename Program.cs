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
                    Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
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
                                Console.Clear();
                                string val_gasolina;

                                Console.Write("Valor da gasolina:");
                                val_gasolina = Console.ReadLine();
                                double gas;

                                while (!double.TryParse(val_gasolina, out gas) || gas < 0)
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                    val_gasolina = Console.ReadLine();
                                }

                                Console.Clear();
                                Console.WriteLine("A unica opção disponivel para seu tipo de carro é gasolina!");


                                Console.Write("\nDeseja continuar ? (s/n):");
                                string continuar = Console.ReadLine();

                                while (continuar != "s" && continuar != "n")
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
                                    continuar = Console.ReadLine();
                                }

                                if (continuar == "s")
                                {
                                    home = 2;

                                }
                                else if (continuar == "n")
                                {
                                    home = 1;

                                }

                                Console.Clear();

                                break;

                            case "alcool":
                                Console.Clear();
                                string val_alcool;

                                Console.Write("Valor do etanol:");
                                val_alcool = Console.ReadLine();
                                double eta;

                                while (!double.TryParse(val_alcool, out eta) || eta < 0)
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                    val_alcool = Console.ReadLine();
                                }

                                Console.Clear();
                                Console.WriteLine("A unica opção disponivel para seu tipo de carro é etanol!");

                                Console.Write("\nDeseja continuar ? (s/n):");
                                string continuar1 = Console.ReadLine();

                                while (continuar1 != "s" && continuar1 != "n")
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
                                    continuar1 = Console.ReadLine();
                                }

                                if (continuar1 == "s")
                                {
                                    home = 2;

                                } else if (continuar1 == "n")
                                {
                                    home = 1;

                                } 

                                Console.Clear();

                                break;

                            case "flex":

                                Console.Clear();
                                string val_v_gas;
                                string val_v_eta;

                                Console.Write("Valor da gasolina:");
                                val_v_gas = Console.ReadLine();
                                double v_gas;

                                while (!double.TryParse(val_v_gas, out v_gas) || v_gas < 0)
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                    val_v_gas = Console.ReadLine();
                                    
                                }

                                Console.Clear();
                                Console.Write("Valor do etanol:");
                                val_v_eta = Console.ReadLine();
                                double v_eta;

                                while (!double.TryParse(val_v_eta, out v_eta) || v_eta < 0)
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                    val_v_eta = Console.ReadLine();
                                }

                                Console.Clear();
                                Console.WriteLine(calculo.calcular(carro.con_gas, carro.con_eta, v_gas, v_eta));


                                Console.Write("\nDeseja continuar ? (s/n):");
                                string continuar2 = Console.ReadLine();

                                while (continuar2 != "s" && continuar2 != "n")
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
                                    continuar2 = Console.ReadLine();
                                }

                                if (continuar2 == "s")
                                {
                                    home = 2;

                                }
                                else if (continuar2 == "n")
                                {
                                    home = 1;

                                }

                                Console.Clear();

                                break;

                            case "home":
                                Console.Write("Deseja mesmo voltar para home (s/n):");
                                string voltar = Console.ReadLine();

                                while (voltar != "s" && voltar != "n")
                                {
                                    Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
                                    voltar = Console.ReadLine();
                                }

                                if (voltar == "s")
                                {
                                    home = 1;

                                }
                                else if (voltar == "n")
                                {
                                    home = 2;

                                }

                                Console.Clear();

                                break;

                            default:
                                Console.WriteLine("Informe uma opção valida!\n");
                                break;

                                

                        }
                    }

                }

                if (opcao == "2")
                {
                    Console.Clear();
                    string validar_etanol;
                    string validar_gasolina;

                    Console.Write("Informe o tipo do carro: gasolina, alcool ou flex: ");
                    string validar_opcao = Console.ReadLine();

                    while (validar_opcao != "gasolina" && validar_opcao != "alcool" && validar_opcao != "flex")
                    {
                        Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
                        validar_opcao = Console.ReadLine();
                    }

                    double con_gas;
                    double con_eta;

                    switch (validar_opcao)
                    {
                        case "gasolina":
                            Console.Clear();
                            Console.Write("Digite o consumo do seu carro na gasolina: ");
                            validar_gasolina = Console.ReadLine();
                            
                            while (!double.TryParse(validar_gasolina, out con_gas) || con_gas < 0)
                            {
                                Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                validar_gasolina = Console.ReadLine();
                            }

                            carro.editar_dados(con_gas, 0);
                            home = 1;

                            break;

                        case "alcool":
                            Console.Clear();
                            Console.Write("Digite o consumo do seu carro no etanol: ");
                            validar_etanol = Console.ReadLine();
                            

                            while (!double.TryParse(validar_etanol, out con_eta) || con_eta < 0)
                            {
                                Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                validar_etanol = Console.ReadLine();
                            }

                            carro.editar_dados(0, con_eta);
                            home = 1;

                            break;

                        case "flex":
                            Console.Clear();
                            Console.Write("Digite o consumo do seu carro no etanol: ");
                            validar_etanol = Console.ReadLine();

                            while (!double.TryParse(validar_etanol, out con_eta) || con_eta < 0)
                            {
                                Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                validar_etanol = Console.ReadLine();
                            }

                            Console.Clear();
                            Console.Write("Digite o consumo do seu carro na gasolina: ");
                            validar_gasolina = Console.ReadLine();                       

                            while (!double.TryParse(validar_gasolina, out con_gas) || con_gas < 0)
                            {
                                Console.Write("DIGITE UMA OPÇÃO VÁLIDA: ");
                                validar_gasolina = Console.ReadLine();
                            }

                            carro.editar_dados(con_gas, con_eta);
                            home = 1;

                            break;

                        default:
                            Console.Write("Informe uma opção valida\n");
                            break;
                    }

                }

                if (opcao == "0")
                {
                    Console.Clear();
                    Console.Write("Deseja realmente sair do programa (s/n) ? :");
                    string saindo = Console.ReadLine();

                    while (saindo != "s" && saindo != "n")
                    {
                        Console.Write("DIGITE UMA OPÇÃO VALIDA: ");
                        saindo = Console.ReadLine();
                    }

                    if (saindo == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("VOCÊ SAIU DO PROGRAMA");
                        Environment.Exit(0);
                        home = 0;

                    }
                    else if (saindo == "n")
                    {
                        home = 1;

                    }
                    
                }

            }
            
            
        }

       
        
            
        
    }
}
