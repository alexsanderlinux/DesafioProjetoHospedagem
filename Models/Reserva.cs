namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> hospedes = new List<Pessoa>();
        public List<Suite> suites = new List<Suite>();

        Suite suite = new Suite();

        Suite novaSuite1 = new Suite(tipoSuite: "Simples", capacidade: 2, valorDiaria: 30, identificacao: 1, 0);
        Suite novaSuite2 = new Suite(tipoSuite: "Master Comum", capacidade: 3, valorDiaria: 60, identificacao: 2, 0);
        Suite novaSuite3 = new Suite(tipoSuite: "Master Premium", capacidade: 3, valorDiaria: 90, identificacao: 3, 0);
        Suite novaSuite4 = new Suite(tipoSuite: "Master Plus", capacidade: 4, valorDiaria: 120, identificacao: 4, 0);
        Suite novaSuite5 = new Suite(tipoSuite: "Mega blaster", capacidade: 4, valorDiaria: 150, identificacao: 5, 0);
        Suite novaSuite6 = new Suite(tipoSuite: "Blaster ultra suite premium", capacidade: 5, valorDiaria: 300, identificacao: 6, 0);

        
        
        //public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public Reserva(){ }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;                      
        }     

        public void CadastrarReserva()
        {//rodar loop para pegar quantidade de hospedes para validar na suite
            Console.Clear();
            
            bool cadastrar = true;

            while(cadastrar == true)
            {
                Console.WriteLine("--Criar reserva para Hospedes--");
                Console.WriteLine("Informe o nome do hospede: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe também o Sobrenome do hospede: ");
                string sobrenome = Console.ReadLine();
                Console.WriteLine("Informe a idade do hospede: ");
                string recIdade = Console.ReadLine();
                int idade = Convert.ToInt32(recIdade);

                Pessoa novoHospede = new Pessoa();
                
                novoHospede.Nome = nome;
                novoHospede.Sobrenome = sobrenome;
                novoHospede.Idade = idade;

                    
                hospedes.Add(novoHospede);

                Console.WriteLine("Deseja cadastrar mais um hospede? \n Digite 1 - para sim e 2 - para não");
                string resposta = Console.ReadLine();

                if(resposta == "1")
                {
                    cadastrar = true;
                }
                else if(resposta == "2")
                {
                    cadastrar = false;
                }
                else
                {
                    Console.WriteLine("Opção invalalida!");
                    break;
                }
            }
            
           
        }

        public void Listar()
        {
            foreach (var hospede in hospedes)
            {
                Console.WriteLine(hospede);
            }
        }

        public void CadastrarSuite()
        {
            Console.WriteLine("Escolha uma suite abaixo: ");
            //preencher a lista de suites globalmente
            suites.Add(novaSuite1);
            suites.Add(novaSuite2);
            suites.Add(novaSuite3);
            suites.Add(novaSuite4);
            suites.Add(novaSuite5);
            suites.Add(novaSuite6);

            foreach (var suite in suites)
            {
                Console.WriteLine(suite);
            }

            string suiteEscolhida = Console.ReadLine();
            int convSuiteEscolhida = Convert.ToInt32(suiteEscolhida);

            var indice = suites.FindIndex(suites => suites.Identificacao == convSuiteEscolhida);

            int quantidadeDeHospedes = ObterQuantidadeHospedes();
            

            

            foreach (var suite in suites)
            {
                Console.WriteLine(suite);

                if(indice+1 == convSuiteEscolhida && suite.Capacidade < quantidadeDeHospedes)
                {
                    throw new ArgumentException("não foi possivel cadastrar reserva nesta suite, pois a capacidade é inferior ao numero de hospedes");                    
                }
                
            }
            Console.Clear();

            Console.WriteLine("Quantos dias você deseja reservar");

            string obterDiasDeReserva = Console.ReadLine();
            int convDiasDeReserva = Convert.ToInt32(obterDiasDeReserva);

            if(indice+1 == convSuiteEscolhida)
            {
                suite.DiasReservados = convDiasDeReserva;
            }

            Console.WriteLine("Suite cadastrada com êxito.");

                   
           

            
        }

        
        public int ObterQuantidadeHospedes()
        {
            int quantidade = hospedes.Count;
            return quantidade;
        }
        public void CalcularValorDiaria()
        {
            Console.WriteLine(suites);
            //Console.WriteLine(suite.ValorDiaria * suite.DiasReservados);         
        } 
        
    }
}