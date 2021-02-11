using System;

namespace Exercicio1_2
{
    class Program
    {
        struct Dados
        {
            public String Nome;
            public String Email;
            public Nascimento Nasc;
            public String Telefone;
        }
        struct Nascimento
        {
            public string Dia;
            public string Mes;
            public string Ano;
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

                Console.Write("Telefone: (ex: 998765432)");
                Console.Write("\n");
                MeuDados.Telefone = Console.ReadLine();

                MeuDados.Nasc = new Nascimento();
                Console.Write("Dia do Nascimento: (ex: 01)");
                Console.Write("\n");
                MeuDados.Nasc.Dia = Console.ReadLine();

                Console.Write("Mes do Nascimento: (ex: 05)");
                Console.Write("\n");
                MeuDados.Nasc.Mes = Console.ReadLine();

                Console.Write("Ano do Nascimento: (ex: 03)");
                Console.Write("\n");
                MeuDados.Nasc.Ano = Console.ReadLine();


                Console.Write("\n\n");

                Cadastro[i] = MeuDados;
            }
            Console.Clear();

            foreach (Dados D in Cadastro)
            {
                Console.WriteLine("==== DADO(S) DO(S) ALUNO(S) CADASTRADO(S) ====");
                Console.WriteLine("Nome: {0}", D.Nome);
                Console.WriteLine("Email: {0}", D.Email);
                Console.WriteLine("Nascimento: {0}/{1}/{2}", D.Nasc.Dia, D.Nasc.Mes, D.Nasc.Ano); 
                Console.WriteLine("Telefone: {0}", D.Telefone);
                Console.Write("\n\n");
            }
        }
    }
}
