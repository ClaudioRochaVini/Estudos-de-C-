using Estoque;
using System;
using System.Globalization;

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {

            Produto p;

            Console.WriteLine("==========================================");
            Console.WriteLine("-------------    CADASTRO   --------------");
            Console.WriteLine("==========================================");
            Console.Write("Digite o CODIGO do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite a DESCRICAO do produto: ");
            string descricao =  Console.ReadLine();
            Console.Write("Digite o VALOR do produto: $ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Deseja dar ENTRADA no estoque (s/n)? ");
            char ent = char.Parse(Console.ReadLine());

            if(ent == 's' || ent == 'S') {
                Console.Write("QUANTIDADE de produtos para entrada: ");
                int qnt = int.Parse(Console.ReadLine());
                p = new Produto(codigo,descricao, valor, qnt);
            }
            else {
                p = new Produto(codigo, descricao, valor);
            }

            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Dar ENTRADA no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.Entrada(quantidade);
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Dar SAIDA no estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.Saida(quantidade);
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Atualizar DESCRICAO (s/n)? ");
            char desc = char.Parse(Console.ReadLine());
            if (desc == 's' || desc == 'S') {
                Console.Write("Nova DESCRICAO: ");
                descricao = Console.ReadLine();
                p.Descricao = descricao;
                Console.WriteLine(p);
            }

        }
    }
}
