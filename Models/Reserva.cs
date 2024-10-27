namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> hospedes = new List<Pessoa>();
        
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public DateTime DataCheckin {get; set;}
        public DateTime Checkin{get; set;}
        
        public Reserva(){ }
        public Reserva(int diasReservados, DateTime dataCheckin)
        {
            DiasReservados = diasReservados;
            DataCheckin = dataCheckin;            
        }     

           
        

        public void CadastrarHospedes()
        {
           Console.Clear();
            Console.WriteLine("--Checkin e Cadastrar Hospedes--");
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
            
           //Checkin = checkin;
        }

        public void Listar()
        {
            foreach (var hospede in hospedes)
            {
                Console.WriteLine(hospede);
            }
        }

        public void HospedarNaSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = hospedes.Count;
            return quantidade;
        }
        public decimal CalcularValorDiaria()
        {
            return 0;
        } 
        
    }
}