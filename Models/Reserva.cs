using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> hospedes = new List<Pessoa>();
        public List<Suite> reservas = new List<Suite>();
        public Suite suite = new Suite();
        public List<Suite> carregaListaSuites()
        {
            List<Suite> suites = new List<Suite>();
            suites.Add(new Suite(tipoSuite: "Simples", capacidade: 2, valorDiaria: 30, identificacao: 1, 0));
            suites.Add(new Suite(tipoSuite: "Master Comum", capacidade: 3, valorDiaria: 60, identificacao: 2, 0));
            suites.Add(new Suite(tipoSuite: "Master Premium", capacidade: 3, valorDiaria: 90, identificacao: 3, 0));
            suites.Add(new Suite(tipoSuite: "Master Plus", capacidade: 4, valorDiaria: 120, identificacao: 4, 0));
            suites.Add(new Suite(tipoSuite: "Mega blaster", capacidade: 4, valorDiaria: 150, identificacao: 5, 0));
            suites.Add(new Suite(tipoSuite: "Blaster ultra suite premium", capacidade: 5, valorDiaria: 300, identificacao: 6, 0));

            return suites;
        }

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
            foreach (var suite in carregaListaSuites())
            {
                Console.WriteLine(suite);
            }

            string suiteEscolhida = Console.ReadLine();
            int convSuiteEscolhida = Convert.ToInt32(suiteEscolhida);

            var indice = carregaListaSuites().FindIndex(suites => suites.Identificacao == convSuiteEscolhida);

            int quantidadeDeHospedes = ObterQuantidadeHospedes();
            
            Console.WriteLine("Quantos dias você deseja reservar");

            string obterDiasDeReserva = Console.ReadLine();
            int convDiasDeReserva = Convert.ToInt32(obterDiasDeReserva);
            

            foreach (var suite in carregaListaSuites())
            {
                Console.WriteLine(suite);

                if(indice+1 == convSuiteEscolhida && suite.Capacidade < quantidadeDeHospedes)
                {
                    throw new ArgumentException("não foi possivel cadastrar reserva nesta suite, pois a capacidade é inferior ao numero de hospedes");                    
                }
                else if(indice+1 == convSuiteEscolhida && convSuiteEscolhida == suite.Identificacao)
                {
                    reservas.Add(new Suite (suite.TipoSuite, suite.Capacidade, suite.ValorDiaria, suite.Identificacao, convDiasDeReserva));
                }
            }

            Console.Clear();
            Console.WriteLine("Suite cadastrada com êxito.");

        }

        
        
        public int ObterQuantidadeHospedes()
        {
            int quantidade = hospedes.Count;
            return quantidade;
        }
        public void CalcularValorDiaria()
        {
            foreach (var reserva in reservas)
            {
                decimal resultado = reserva.ValorDiaria * reserva.DiasReservados;
                Console.WriteLine(reserva);
                Console.WriteLine(resultado.ToString("C"));  
                
                if(reserva.DiasReservados >= 10)
                {
                    decimal dezPorcento = resultado * 0.1M;
                    decimal precoComDesconto = resultado - dezPorcento; 
                    Console.WriteLine($"Você foi contemplado com 10% de desconto "+
                     ""+$"e preço final de sua estadia que era de {resultado.ToString("C")}, "+
                    ""+$"passou a ser de {precoComDesconto.ToString("C")}. ");
                }       
            }
        } 
        
    }
}