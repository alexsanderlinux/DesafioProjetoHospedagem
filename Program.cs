using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Collections.Generic;

Console.OutputEncoding = Encoding.UTF8;

//menu inicial do sistema de hospedagem

bool exbirMenu = true;
Reserva reserva = new Reserva();







while(exbirMenu)
{
    Console.WriteLine("Bem vindo ao Sistema de hospedagem.");
    Console.WriteLine("Escolha a opção desejada abaixo:");
    Console.WriteLine("1 - Checkin e Cadastrar hospedes.");
    Console.WriteLine("2 - Listar hospedes.");
    Console.WriteLine("3 - Obter quantidade de hospedes.");
    Console.WriteLine("4 - Hospedar na suite.");
    Console.WriteLine("5 - Checkout e Baixa na hospedagem.");
    Console.WriteLine("6 - Para sair do programa.");
    
    string opcao = Console.ReadLine();
    
    switch(opcao)
    {
        case "1":
        {
           Console.Clear();
           Console.WriteLine("Cadastrar hospedes.");
           reserva.CadastrarHospedes();           
           break;
        }

        case "2":
        {
            Console.Clear();
            Console.WriteLine("Hospedes cadastrados.");
            reserva.Listar();
            break;
        }

        case "3":
        {
            Console.Clear();
            Console.WriteLine("Quantidade:");
            int oterRetorno = reserva.ObterQuantidadeHospedes();
            Console.WriteLine(oterRetorno);

            break;
        }
        case "4":
        {
            Console.Clear();
            Console.WriteLine("Hospedagem na suite abaixo.");
            
            break;
        }


        case "5":
        {
            Console.Clear();
            Console.WriteLine("Checkout e Baixa na hospedagem.");
            
            break;
        }

        case "6":
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
