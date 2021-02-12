using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Filme
    {
        private string _Nome;
        public string Nome
            {
            get {return _Nome;}
            set { _Nome = value;}
            }
        private string _Duracao;
        public string Duracao
            {
            get { return _Duracao; }
            set { _Duracao = value; }
            }
        private string _Diretor;
        public string Diretor
            {
            get { return _Diretor; }
            set { _Diretor = value; }
            }
        private string _Categoria;
        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }
        private string _Outros;
        public string Outros
        {
            get { return _Outros; }
            set { _Outros = value; }
        }

        public void LeDados()
        {
            Console.Clear();

            Console.Write("Nome do filme:");
            _Nome = Console.ReadLine();

            Console.Write("Duracao do filme:");
            _Duracao = Console.ReadLine();

            Console.Write("Diretor do filme:");
            _Diretor = Console.ReadLine();

            Console.Write("Categoria do filme:");
            _Categoria = Console.ReadLine();

            Console.Write("Outros detalhes do filme:");
            _Outros = Console.ReadLine();
        }
    }
    class Dados
    {
        private List<Filme> Cadastro = new List<Filme>();

        public void GravarDados(Filme x)
        {
            Cadastro.Add(x);
        }
        public void ListarDados()
        {
            Console.Clear();
            int k = 1;
            foreach (Filme x in Cadastro)
            {
                Console.WriteLine("FILME ("+k+"):");
                Console.WriteLine("NOME: {0}", x.Nome);
                Console.WriteLine("DURACAO: {0}", x.Duracao);
                Console.WriteLine("DIRETOR: {0}", x.Diretor);
                Console.WriteLine("CATEGORIA: {0}", x.Categoria);
                Console.WriteLine("OUTROS DETALHES: {0}\n\n", x.Outros);
                k++;
            }
            Console.WriteLine("ENTER PARA CONTINUAR:");
        }
        public void ListaCat()
        {
            Console.Clear();
            Console.WriteLine("CATEGORIAS DE FILME:" +
                "\n1 - ACAO" +
                "\n2 - AVENTURA" +
                "\n3 - COMEDIA" +
                "\n4 - TERROR" +
                "\n5 - SUSPENSE" +
                "\n6 - DRAMA" +
                "\n7 - FICCAO" +
                "\n8 - MUSICAL" +
                "\n9 - OUTROS");
            Console.WriteLine("QUAL A CATEGORIA DESEJADA:");
            string user;
            user = Console.ReadLine();
            Console.Clear();
            int j = 1;
            foreach (Filme x in Cadastro)
            {
                if (user == x.Categoria)
                {
                    Console.WriteLine("FILME (" + j + "):");
                    Console.WriteLine("NOME: {0}", x.Nome);
                    Console.WriteLine("DURACAO: {0}", x.Duracao);
                    Console.WriteLine("DIRETOR: {0}", x.Diretor);
                    Console.WriteLine("CATEGORIA: {0}", x.Categoria);
                    Console.WriteLine("OUTROS DETALHES: {0}\n\n", x.Outros);
                    j++;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dados MeusDados = new Dados();
            int op;
            static void menu()
            {
                Console.Clear();
                Console.WriteLine("==================== MENU ====================");
                Console.WriteLine("1) ADICIONAR FILMES");
                Console.WriteLine("2) LISTAR TODOS OS FILMES");
                Console.WriteLine("3) LISTAR FILMES POR CATEGORIA");
                Console.WriteLine("ESC) ENCERRA O PROGRAMA");
                Console.WriteLine("==============================================");
                Console.WriteLine("OPCAO DESEJADA:");
            }
            do
            {
                menu();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int i = 0;
                        do
                        {
                            Filme x = new Filme();
                            Console.Clear();
                            x.LeDados();
                            MeusDados.GravarDados(x);
                            i++;
                        } while (i < 5);
                        break;

                    case 2:
                        Console.Clear();
                        MeusDados.ListarDados();
                        break;

                    case 3:
                        Console.Clear();
                        MeusDados.ListaCat();
                        break;

                    default:
                        Console.WriteLine("Opcao Invalida!");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
