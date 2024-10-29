using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Collections.Generic;
using System.Globalization;

Console.OutputEncoding = Encoding.UTF8;

//menu inicial do sistema de hospedagem

bool exbirMenu = true;
Reserva reserva = new Reserva();

while(exbirMenu)
{
    Console.WriteLine("Bem vindo ao Sistema de hospedagem.");
    Console.WriteLine("Escolha a opção desejada abaixo:");
    Console.WriteLine("1 - Criar reserva.");
    Console.WriteLine("2 - Listar hospedes da reserva.");
    Console.WriteLine("3 - Obter quantidade de hospedes da reserva.");
    Console.WriteLine("4 - Cadastrar suite.");
    Console.WriteLine("5 - Obtenha os valores da reserva.");
    Console.WriteLine("6 - Para sair do programa.");
    
    string opcao = Console.ReadLine();
    
    switch(opcao)
    {
        case "1":
        {
           Console.Clear();
           Console.WriteLine("Criar reserva.");
           reserva.CadastrarReserva();           
           break;
        }
        case "2":
        {
            Console.Clear();
            Console.WriteLine("Hospedes cadastrados na reserva.");
            reserva.Listar();
            break;
        }
        case "3":
        {
            Console.Clear();
            Console.WriteLine("Quantidade de hospedes da reserva:");
            int obterRetornoQuantidadeHospedes = reserva.ObterQuantidadeHospedes();
            Console.WriteLine($"{obterRetornoQuantidadeHospedes} hospede(s) nesta reserva.");
            break;
        }
        case "4":
        {
            Console.Clear();
            Console.WriteLine("Suites:");
            reserva.CadastrarSuite();            
            break;
        }
        case "5":
        {
            Console.Clear();
            Console.WriteLine("Segue abaixo a confirmação da reserva e o preço final do calculo de diárias.");
            reserva.CalcularValorDiaria();
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
