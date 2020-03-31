using System;
using System.IO;

namespace Aula5Ferramenta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinuar = true;

            string menu = "\n1 - Inserir\n2 - Listar\n3 - Gerar Arquivo\n4 - Sair";

            while (isContinuar)
            {
                Console.WriteLine(menu);
                Console.Write("Opção: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        GerarArquivo();
                        break;
                    case 4:
                        isContinuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }
        private static void Adicionar()
        {
            Console.Write("\nDescrição: ");
            string decricao = Console.ReadLine();
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Preço: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            new FerramentaService().Adicionar(new Ferramenta(decricao, tipo, marca, preco));
        }

        private static void Listar()
        {
            Console.WriteLine();
            foreach (var item in new FerramentaService().Listar())
            {
                Console.WriteLine(item + "\n-----------------------------");
            }
        }

        private static void GerarArquivo()
        {
            string caminho = @"C:\Users\Marcelo\Desktop\ralatorio-ferramenta" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".txt";
            StreamWriter writer = new StreamWriter(caminho);
            foreach (var ferramenta in new FerramentaService().Listar())
            {
                writer.WriteLine(ferramenta + "\n-----------------------------");
            }
            writer.Close();
        }
    }
}
