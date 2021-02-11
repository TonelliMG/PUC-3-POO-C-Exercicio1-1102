using System;

namespace Exercício1_1
{
    class Program
    {
        struct Dados
        {
            public String Nome;
            public String Email;
            public int Nascimento;
            public String Telefone;
        }

        static void Main(string[] args)
        {
            Dados[] Cadastro = new Dados[1];

            for (int i = 0; i < 1; i++)
            {
                Dados MeuDados = new Dados();

                Console.Write("Nome:");
                Console.Write("\n");
                MeuDados.Nome = Console.ReadLine();

                Console.Write("Email:");
                Console.Write("\n");
                MeuDados.Email = Console.ReadLine();

                Console.Write("Nascimento: (ex: DDMMAA)");
                Console.Write("\n");
                MeuDados.Nascimento = int.Parse(Console.ReadLine());

                Console.Write("Telefone: (ex: 998765432)");
                Console.Write("\n");
                MeuDados.Telefone = Console.ReadLine();

                Console.Write("\n\n");

                Cadastro[i] = MeuDados;
            }
            Console.Clear();

            foreach (Dados D in Cadastro)
            {
                Console.WriteLine("==== DADO(S) DO(S) ALUNO(S) CADASTRADO(S) ====");
                Console.WriteLine("Nome: {0}", D.Nome);
                Console.WriteLine("Email: {0}", D.Email);
                Console.WriteLine("Nascimento: {0}", D.Nascimento);
                Console.WriteLine("Telefone: {0}", D.Telefone);
                Console.Write("\n\n");
            }
        }
    }
}
