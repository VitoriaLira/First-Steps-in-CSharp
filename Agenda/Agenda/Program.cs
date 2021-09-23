using System;

namespace agenda
{
    struct Agenda 
    {
        public string primeiro_nome, sobrenome, tipo_contato, email, rua, complemento, bairro, cidade, estado, observacaoespecial;
        public byte dia, mes, DDD;
        public ushort ano, numero;
        public int numero_contato;

        public Agenda (string primeiro_nome, string sobrenome, string tipo_contato, string email, string rua,
            string complemento, string bairro, string cidade, string estado, string observacaoespecial, byte dia, 
            byte mes, byte DDD, ushort numero, ushort ano, int numero_contato)
        {
            this.primeiro_nome = primeiro_nome;
            this.sobrenome = sobrenome;
            this.tipo_contato = tipo_contato;
            this.email = email;
            this.rua = rua;
            this.complemento = complemento;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.observacaoespecial = observacaoespecial;
            this.dia = dia;
            this.mes = mes;
            this.DDD = DDD;
            this.ano = ano;
            this.numero_contato = numero_contato;
        }

        public void Informacao()
        {
            Console.WriteLine("\n--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=");
            Console.WriteLine($"\nNOME: {this.primeiro_nome}");
            Console.WriteLine($"SOBRENOME: {this.sobrenome}");
            Console.WriteLine($"TIPO DE CONTATO: {this.tipo_contato}");
            Console.WriteLine($"CONTATO: ({this.DDD}) {this.numero_contato}");
            Console.WriteLine($"DATA DE NASCIMENTO: {this.dia}/{this.mes}/{this.ano}");
            Console.WriteLine($"E-MAIL: {this.email}");
            Console.WriteLine($"ENDEREÇO: {this. rua}, n° {this.numero}, {this.complemento}, {this.bairro}, {this.cidade}, {this.estado}");
            Console.WriteLine($"OBSERVAÇÃO: {this.observacaoespecial}");
            DateTime dias = new DateTime(DateTime.Today.Year, this.mes, this.dia);
            var niver = (dias.Subtract(DateTime.Today).TotalDays);
            if (niver > 0)
            {
                Console.WriteLine($"Faltam {niver} dias para o aniversário de {this.primeiro_nome}!!!");
            }
            else
            {
                Console.WriteLine($"O aniversário de {this.primeiro_nome} já passou.");
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            Agenda[] agendas = new Agenda[100];

            string inicio, opcoes;
            string buscar_nome, buscar_sobrenome, buscar_tipocontato, buscar_cidade;
            char iniciar, escolha;
            byte cont;

            cont = 0;

            inicio = ("==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==\n" + 
                "\n                    MY CONTACTS                 \n" +
                "\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==\n" +
                "  Olá, seja bem vindo(a) a sua agenda virtual!!!  |\n" +
                "-------------------------------------------------- \n" +
                "     Por favor, escolha uma das opções abaixo: \n" +
                "\n[1] - Iniciar! \n" +
                "[2] - Sair! \n" +
                "--------------------------------------------------");

            Console.WriteLine(inicio);

            iniciar = char.Parse(Console.ReadLine());
            while (iniciar != '1' && iniciar != '2')
            {
                Console.WriteLine("\nEsta opção é inválida! Por favor, escolha uma das opções acima: ");
                iniciar = char.Parse(Console.ReadLine());
            }

            if (iniciar == '2') 
            {
                Console.WriteLine("Finalizando...");
            }

            else if (iniciar == '1')
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                Console.WriteLine("  ÓTIMO!!! Você optou por iniciar a sua jornada em sua agenda virtual. |");
                Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==\n");

                escolha = ('1');

                while (escolha != '7')
                {
                    System.Threading.Thread.Sleep(2000);
                    opcoes = ("\n----------------------------------------------------------------- \n" + 
                        "Por favor, escolha uma das opções abaixo: \n" +
                        "\n[1] - Adicionar um contato \n" +
                        "[2] - Buscar contato por primeiro nome \n" +
                        "[3] - Buscar contato por nome completo \n" +
                        "[4] - Buscar contato por tipo de contato \n" +
                        "[5] - Buscar contato por cidade \n" +
                        "[6] - Remover um contato \n" +
                        "[7] - Sair \n" +
                        "-----------------------------------------------------------------");
                    Console.WriteLine(opcoes);

                    escolha = char.Parse(Console.ReadLine());
                    while (escolha != '1' && escolha != '2' && escolha != '3' && escolha != '4' && escolha != '5' && escolha != '6' && escolha != '7')
                    {
                        Console.WriteLine("\nEsta opção é inválida! Por favor, escolha uma das opções acima: ");
                        escolha = char.Parse(Console.ReadLine());
                    }

                    switch (escolha)
                    {
                        case '1':

                            Console.WriteLine("\n--------------------------------------------------");
                            Console.WriteLine("                     CADASTRO                     ");
                            Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Digite o nome completo. \n");
                            Console.WriteLine("Primeiro nome: ");
                            agendas[cont].primeiro_nome = (Console.ReadLine());
                            Console.WriteLine("\nSobrenome: ");
                            agendas[cont].sobrenome = (Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------\n");

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine($"Por favor, escolha a opção referente ao tipo de contato de {agendas[cont].primeiro_nome}: \n" +
                                "\n[C] - Celular \n" +
                                "[T] - Trabalho \n" +
                                "[H] - Casa \n" +
                                "[P] - Principal \n" +
                                "[G] - Pager \n" +
                                "[F] - Fax Trabalho \n" +
                                "[X] - Fax Casa \n" +
                                "[O] - Outro \n");
                            agendas[cont].tipo_contato = Console.ReadLine();
                            while (agendas[cont].tipo_contato != "C" && agendas[cont].tipo_contato != "T" && agendas[cont].tipo_contato != "H" && agendas[cont].tipo_contato != "P" && agendas[cont].tipo_contato != "G" && agendas[cont].tipo_contato != "F" && agendas[cont].tipo_contato != "X" && agendas[cont].tipo_contato != "O")
                            {
                                Console.WriteLine("\nEsta opção é inválida! Por favor, escolha uma das opções acima: ");
                                agendas[cont].tipo_contato = (Console.ReadLine());
                            }

                            if (agendas[cont].tipo_contato == "C")
                            {
                                agendas[cont].tipo_contato = ("Celular");
                            }

                           else if (agendas[cont].tipo_contato == "T")
                            {
                                agendas[cont].tipo_contato = ("Trabalho");
                            }

                            else if (agendas[cont].tipo_contato == "H")
                            {
                                agendas[cont].tipo_contato = ("Casa");
                            }

                            else if (agendas[cont].tipo_contato == "P")
                            {
                                agendas[cont].tipo_contato = ("Principal");
                            }

                            else if (agendas[cont].tipo_contato == "G")
                            {
                                agendas[cont].tipo_contato = ("Pager");
                            }

                            else if (agendas[cont].tipo_contato == "F")
                            {
                                agendas[cont].tipo_contato = ("Fax Trabalho");
                            }

                            else if (agendas[cont].tipo_contato == "X")
                            {
                                agendas[cont].tipo_contato = ("Fax Casa");
                            }

                            else if (agendas[cont].tipo_contato == "O")
                            {
                                agendas[cont].tipo_contato = ("Outro");
                            }
                            Console.WriteLine("--------------------------------------------------------------------\n");

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine($"Digite as informações de contato de {agendas[cont].primeiro_nome}. \n");
                            Console.WriteLine("DDD: ");
                            agendas[cont].DDD = byte.Parse(Console.ReadLine());
                            Console.WriteLine("\nNúmero para contato: ");
                            agendas[cont].numero_contato = int.Parse(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------\n");

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine($"Digite a data de nascimento de {agendas[cont].primeiro_nome}. ");
                            Console.WriteLine("\nDia: ");
                            agendas[cont].dia = byte.Parse(Console.ReadLine());
                            Console.WriteLine("\nMês: ");
                            agendas[cont].mes = byte.Parse(Console.ReadLine());
                            Console.WriteLine("\nAno: ");
                            agendas[cont].ano = ushort.Parse(Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------\n");

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine($"Digite o email de {agendas[cont].primeiro_nome}: ");
                            agendas[cont].email = (Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------\n");

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine($"Digite o endereço de {agendas[cont].primeiro_nome}. ");
                            Console.WriteLine("\nRua: ");
                            agendas[cont].rua = (Console.ReadLine());
                            Console.WriteLine("\nNúmero: ");
                            agendas[cont].numero = ushort.Parse(Console.ReadLine());
                            Console.WriteLine("\nComplemento: ");
                            agendas[cont].complemento = (Console.ReadLine());
                            Console.WriteLine("\nBairro: ");
                            agendas[cont].bairro = (Console.ReadLine());
                            Console.WriteLine("\nCidade: ");
                            agendas[cont].cidade = (Console.ReadLine());
                            Console.WriteLine("\nEstado: ");
                            agendas[cont].estado = (Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------\n");

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Observação: ");
                            agendas[cont].observacaoespecial = (Console.ReadLine());
                            Console.WriteLine("--------------------------------------------------\n");

                            Console.WriteLine("\nCADASTRANDO...");

                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("               CADASTRO EFETUADO!!!               |");
                            Console.WriteLine("==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine($"NOME: {agendas[cont].primeiro_nome}"); 
                            Console.WriteLine($"SOBRENOME: {agendas[cont].sobrenome}");
                            Console.WriteLine($"TIPO DE CONTATO: {agendas[cont].tipo_contato}");
                            Console.WriteLine($"CONTATO: ({agendas[cont].DDD}) {agendas[cont].numero_contato}");
                            Console.WriteLine($"DATA DE NASCIMENTO: {agendas[cont].dia}/{agendas[cont].mes}/{agendas[cont].ano}");
                            Console.WriteLine($"E-MAIL: {agendas[cont].email}");
                            Console.WriteLine($"ENDEREÇO: {agendas[cont].rua}, n° {agendas[cont].numero}, {agendas[cont].complemento}, {agendas[cont].bairro}, {agendas[cont].cidade}, {agendas[cont].estado}");
                            Console.WriteLine($"OBSERVAÇÃO: {agendas[cont].observacaoespecial}");

                            cont += 1;

                            break;

                        case '2':

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Por favor, digite o primeiro nome do contato que deseja buscar: ");
                            buscar_nome = (Console.ReadLine());
                            for (byte contact = 0; contact < agendas.Length; contact += 1)
                            {
                                if (buscar_nome == agendas[contact].primeiro_nome)
                                {
                                    agendas[contact].Informacao();
                                }
                            }
                            Console.WriteLine("----------------------------------------------------------------\n");
                            
                            break;

                        case '3':

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Por favor, digite o primeiro nome e o sobrenome do contato que deseja buscar: \n");
                            Console.WriteLine("Primeiro nome: ");
                            buscar_nome = (Console.ReadLine());
                            Console.WriteLine("\nSobrenome: ");
                            buscar_sobrenome = (Console.ReadLine());
                            for (byte contact = 0; contact < agendas.Length; contact += 1)
                            {
                                if (buscar_nome == agendas[contact].primeiro_nome && buscar_sobrenome == agendas[contact].sobrenome)
                                {
                                    agendas[contact].Informacao();
                                }
                            }
                            Console.WriteLine("-----------------------------------------------------------------------------------\n");

                            break;

                        case '4':

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Por favor, digite o tipo de contato do contato que deseja buscar: ");
                            buscar_tipocontato = (Console.ReadLine());
                            for (byte contact = 0; contact < agendas.Length; contact += 1)
                            {
                                if (buscar_tipocontato == agendas[contact].tipo_contato)
                                {
                                    agendas[contact].Informacao();
                                }
                            }
                            Console.WriteLine("------------------------------------------------------------------------\n");

                            break;

                        case '5':

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Por favor, digite a cidade do contato que deseja buscar: ");
                            buscar_cidade = (Console.ReadLine());
                            for (byte contact = 0; contact < agendas.Length; contact += 1)
                            {
                                if (buscar_cidade == agendas[contact].cidade)
                                {
                                    agendas[contact].Informacao();
                                }
                            }
                            Console.WriteLine("---------------------------------------------------------------\n");

                            break;

                        case '6':

                            Console.WriteLine("\n==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==-==");
                            Console.WriteLine("Por favor, digite o primeiro nome, sobrenome, tipo de contato e a cidade do contato que deseja remover: \n");
                            Console.WriteLine("Primeiro nome: ");
                            buscar_nome = (Console.ReadLine());
                            Console.WriteLine("\nSobrenome: ");
                            buscar_sobrenome = (Console.ReadLine());
                            Console.WriteLine("\nTipo de contato: ");
                            buscar_tipocontato = (Console.ReadLine());
                            Console.WriteLine("\nCidade: ");
                            buscar_cidade = (Console.ReadLine());
                            for (byte contact = 0; contact < agendas.Length; contact += 1)
                            {
                                if (buscar_nome == agendas[contact].primeiro_nome && buscar_sobrenome == agendas[contact].sobrenome && buscar_tipocontato == agendas[contact].tipo_contato && buscar_cidade == agendas[contact].cidade)
                                {
                                    agendas[cont].primeiro_nome = (" ");
                                    agendas[cont].sobrenome = (" ");
                                    agendas[cont].tipo_contato = (" ");
                                    agendas[cont].DDD = 0;
                                    agendas[cont].numero_contato = 0;
                                    agendas[cont].dia = 0;
                                    agendas[cont].mes = 0;
                                    agendas[cont].ano = 0;
                                    agendas[cont].email = (" ");
                                    agendas[cont].bairro = (" ");
                                    agendas[cont].cidade = (" ");
                                    agendas[cont].estado = (" ");
                                    agendas[cont].observacaoespecial = (" ");
                                }
                            }
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------\n");

                            break;

                        case '7':

                            Console.WriteLine("\nFinalizando...");

                            break;
                    }
                }
            }   
        }
    }
}