using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

//menu inicial do sistema de hospedagem

bool exbirMenu = true;


while(exbirMenu)
{
    Console.WriteLine("Bem vindo ao Sistema de hospedagem.");
    Console.WriteLine("Escolha a opção desejada abaixo:");
    Console.WriteLine("1 - Checkin e Cadastrar Hospedes.");
    Console.WriteLine("2 - Listar Hospedes.");
    Console.WriteLine("3 - Checkout e Baixa na hospedagem.");
    Console.WriteLine("4 - Para sair do programa.");
    string opcao = Console.ReadLine();
    
    switch(opcao)
    {
        case "1":
        {
            Console.Clear();
            Console.WriteLine("Checkin e Cadastrar Hospedes");
            
            
            break;
        }

        case "2":
        {
            Console.Clear();
            Console.WriteLine("Listar Hospedes.");
            

            break;
        }

        case "3":
        {
            Console.Clear();
            Console.WriteLine("Checkout e Baixa na hospedagem.");
            
            break;
        }

        case "4":
        {
            Console.WriteLine("Encerrando programa");
            exbirMenu = false;
            break;
        }

        default:
        {
            Console.WriteLine("Opção invalida.");
            break;
        }
    }
    
}
