using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contatos = new string[100];

            int iniciar;
            int escolha;
            string primeiro_nome, sobrenome;
            int dia, mes, ano;
            char tipo_contato;
            int DDD, numero_contato;
            string email;
            string bairro, cidade, estado;
            string observacaoespecial;

            Console.WriteLine("---------------------------------------------------\n" + 
                "Olá, seja bem vindo(a) a sua agenda virtual!!! \n" +
                "\nPor favor, escolha uma das opções abaixo: \n" +
                "1 - Iniciar \n" +
                "2 - Sair \n" +
                "---------------------------------------------------");
            
            iniciar = int.Parse(Console.ReadLine());

            // Adicionar um loop para iniciar

            Console.WriteLine("\n----------------------------------------------------------------- \n" + 
                "Você optou por iniciar a sua jornada em sua agenda virtual. \n" + 
                "Por favor, escolha uma das opções abaixo: \n" +
                "\n[1] Adicionar um contato \n" +
                "[2] Buscar contato por primeiro nome \n" +
                "[3] Buscar contato por nome completo \n" +
                "[4] Buscar contato por tipo de contato \n" +
                "[5] Buscar contato por cidade \n" +
                "[6] Remover um contato \n" +
                "-----------------------------------------------------------------");


            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    
                    Console.WriteLine("\nDigite o primeiro nome: ");
                    primeiro_nome = (Console.ReadLine());

                    Console.WriteLine("\nDigite o sobrenome: ");
                    sobrenome = (Console.ReadLine());

                    Console.WriteLine($"\nPor favor, escolha a opção referente ao tipo de contato de {primeiro_nome}: \n" +
                        "[C] Celular \n" +
                        "[T] Trabalho \n" + 
                        "[H] Casa \n" +
                        "[P] Principal \n" +
                        "[G] Pager \n" +
                        "[F] Fax Trabalho \n" + 
                        "[X] Fax Casa \n" +
                        "[O] Outro \n");
                    tipo_contato = char.Parse(Console.ReadLine());

                    Console.WriteLine($"\nPor favor, digite o DDD do número de contato de {primeiro_nome}: ");
                    DDD = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\nPor favor, digite o número de contato de {primeiro_nome}: ");
                    numero_contato = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\nPor favor, digite a data de nascimento de {primeiro_nome}: ");
                    Console.WriteLine($"Dia: ");
                    dia = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nMês: ");
                    mes = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nAno: ");
                    ano = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\nPor favor, digite o email de {primeiro_nome}: ");
                    email = (Console.ReadLine());

                    Console.WriteLine($"\nPor favor, digite o endereço de {primeiro_nome}: ");
                    Console.WriteLine($"Digite o bairro: ");
                    bairro = (Console.ReadLine());
                    Console.WriteLine($"\nDigite a cidade: ");
                    cidade = (Console.ReadLine());
                    Console.WriteLine($"\nDigite o estado: ");
                    estado = (Console.ReadLine());

                    Console.WriteLine("\nObservação: ");
                    observacaoespecial = (Console.ReadLine());

                    break;

              
                 

                    
            }
        }
    }
}
