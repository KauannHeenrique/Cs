using System.Collections.Generic;
using System.Threading;
using System;

public class JUPITER
{
    static List<Produto> listaProdutos = new List<Produto>();

    public static void Main()
    {
        string senha = "";
        bool produtos = false;
        while (true)
        {

            Console.WriteLine("--------------------------BEM-VINDO AO--------------------------");
            Console.WriteLine("");
            Console.WriteLine(Logo());

            if (senha == "")
            {
                Console.WriteLine("INFORME A SUA SENHA DE ADMINISTRADOR!");
                senha = Console.ReadLine();
                Console.Clear();
            }
            else if (!produtos)
            {
                produtos = true;
                Console.WriteLine("----------------------ADICIONANDO OS PRODUTOS----------------------");
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.WriteLine("..");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                AdicionarProduto(1, "Caixa de Bolete", 10);
                AdicionarProduto(2, "Pirulitos un.", 30);
                AdicionarProduto(3, "Heineken", 6);
                AdicionarProduto(4, "Doce de leite", 20);
                AdicionarProduto(5, "Cigarro", 3);
                AdicionarProduto(6, "Paçoca", 15);
                AdicionarProduto(7, "Água 500ml", 10);
                AdicionarProduto(8, "Coca-cola 2Lt", 4);
                Console.Clear();
                Console.WriteLine("PRODUTOS ADICIONADOS!");
                Thread.Sleep(1000);
                Console.WriteLine("Vamos começar......");
                Thread.Sleep(1000);
                Console.WriteLine("Vamos começar.....");
                Thread.Sleep(1000);
                Console.WriteLine("Vamos começar....");
                Thread.Sleep(1000);
                Console.WriteLine("Vamos começar...");
                Thread.Sleep(1000);
                Console.WriteLine("Vamos começar..");
                Thread.Sleep(1000);
                Console.WriteLine("Vamos começar.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------PAINEL DE CONTROLE-----------");
                Console.WriteLine("");
                Console.WriteLine("[1] - Vender Produto");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Alterar Senha");
                Console.WriteLine("[4] - Fechar Caixa");


                int decisao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (decisao)
                {
                    case 1:
                        Console.WriteLine("-----------PAINEL DE VENDA-----------");
                        Console.WriteLine();
                        Console.Write("Informe o id do produto:");
                        int id_venda = Convert.ToInt32(Console.ReadLine());

                        Produto produtoEncontrado = listaProdutos.Find(x => x.Id == id_venda);

                        if (produtoEncontrado == null)
                        {
                            Console.WriteLine("Erro: Produto com o ID informado não encontrado!");
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Produto encontrado: {produtoEncontrado.Nome}");
                            Console.WriteLine($"Quantidade em estoque: {produtoEncontrado.Quantidade}");
                            Console.WriteLine();

                            if (produtoEncontrado.Quantidade > 0)
                            {
                                Console.Write("Informe a quantidade da venda: ");
                                int quantidadeVenda = 0;
                                quantidadeVenda = Convert.ToInt32(Console.ReadLine());

                                    if (quantidadeVenda > produtoEncontrado.Quantidade)
                                    {
                                    Console.WriteLine();
                                    Console.WriteLine("Quantidade vendida maior que a quantidade em estoque");
                                    Console.ReadKey();
                                    Console.Clear();
                                    }

                                    else
                                {
                                    produtoEncontrado.Quantidade -= quantidadeVenda;
                                    Console.WriteLine();
                                    Console.WriteLine($"Venda realizada! Quantidade em estoque: {produtoEncontrado.Quantidade}");
                                    Console.WriteLine();
                                    Console.WriteLine("Pressione qualquer tecla..");
                                    Console.ReadKey();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Desculpe, este produto está fora de estoque!");
                                Console.ReadKey();
                                break;
                            }
                        }

                    break;

                    case 2:
                        Console.WriteLine("-----------LISTA DE PRODUTOS-----------");
                        Console.WriteLine();
                        Console.WriteLine("ID          NOME          QUANTIDADE ");
                        Console.WriteLine("--------------------------------------");

                        foreach (var item in listaProdutos)
                                {
                                    Console.WriteLine(item);
                                }

                        Console.WriteLine();
                        Console.WriteLine("Pressione qualquer tecla..");
                        Console.ReadKey();

                    break;

                    case 3:

                        Console.Write("Informe a senha antiga: ");
                        string senhaAntiga = Console.ReadLine();
                        Console.WriteLine();

                        if (senhaAntiga == senha)
                        {
                            Console.Write("Informe a nova senha: ");
                            string novaSenha = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Informe a nova senha novamente: ");
                            string confirmasenha = Console.ReadLine();

                            if (novaSenha == confirmasenha)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Senha alterada com sucesso :)");
                                senha = novaSenha;
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("As senhas não coincidem :/");
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Senha Incorreta, tente novamente :(");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("-----------FECHAMENTO DE CAIXA-----------");
                        Console.WriteLine("");
                        Console.Write("Insira a senha: ");
                        string senhaCaixa = Console.ReadLine();

                        if(senhaCaixa == senha)
                        {
                            Console.Clear();
                            Console.WriteLine("-----------FECHAMENTO DE CAIXA-----------");
                            Console.WriteLine();
                            Console.WriteLine("-----------LISTA DE PRODUTOS-----------");
                            Console.WriteLine();
                            Console.WriteLine("ID          NOME          QUANTIDADE ");
                            Console.WriteLine("--------------------------------------");

                            foreach (var item in listaProdutos)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine();
                            Thread.Sleep(20000);
                            Environment.Exit(0);
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Senha Incorreta, tente novamente :(");
                        }

                        break;
                }


                //-------------------


                //4 - PARA FECHAR O CAIXA DEVE SER INSERIDO A SENHA ATUAL, MOSTRAR A LISTA DE PRODUTOS
                // COM A QUANTIDADE ATUALZIADA E DEPOIS DE 20 SEGUNDOS FINALIZAR O PROGRAMA
            }

        }
    }

    public static string Logo()
    {
        string logo = "   JJJJJJJJ  U     U  PPPPPPP   II  TTTTTTTT  EEEEEEE  RRRRRRR\n";
        logo += "      JJ     U     U  PP   PP   II     TT     EE       RR   RR\n";
        logo += "      JJ     U     U  PP   PP   II     TT     EE       RR   RR\n";
        logo += "      JJ     U     U  PPPPPPP   II     TT     EEEEE    RRRRRRR\n";
        logo += "JJ    JJ     U     U  PP        II     TT     EE       RR RR\n";
        logo += "JJ    JJ     U     U  PP        II     TT     EE       RR   RR\n";
        logo += " JJJJJJ       UUUUU   PP        II     TT     EEEEEEE  RR    RR\n";
        logo += "\n";
        logo += "          3333333   00000000  00000000 00000000  !!!\n";
        logo += "          33    33  00    00  00    00 00    00  !!!\n";
        logo += "                33  00    00  00    00 00    00  !!!\n";
        logo += "          3333333   00    00  00    00 00    00  !!!\n";
        logo += "                33  00    00  00    00 00    00  !!!\n";
        logo += "          33    33  00    00  00    00 00    00     \n";
        logo += "          3333333   00000000  00000000 00000000  !!!\n";

        return logo;
    }
    static void AdicionarProduto(int id, string nome, int quantidade)
    {
        Produto produto = new Produto(id, nome, quantidade);
        listaProdutos.Add(produto);
    }
}
class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public Produto(int id, string nome, int quantidade)
    {
        Id = id;
        Nome = nome;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"{Id.ToString().PadRight(6)}" +  
               $"{Nome.PadRight(24)}" +        
               $"{Quantidade.ToString().PadRight(10)}"; 
    }
}