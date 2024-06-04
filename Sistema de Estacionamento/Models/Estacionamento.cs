using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Estacionamento.Models
{
    internal class Estacionamento
    {
        // INICIO DO CÓDIGO
        public int valores {  get; set; }
        public static int ValorInicial(int inicial)
        {
            Console.WriteLine("Bem vindo ao sistema de estacionamento!");
            Console.WriteLine("Digite o preço inicial:");
            inicial = Convert.ToInt32(Console.ReadLine());
            return inicial;
        }
        public static int ValorHora(int valorPorHora)
        {
            Console.WriteLine("Agora digite o preço por hora:");
            valorPorHora = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return valorPorHora;
        }



        // CORPO DO SISTEMA
        public static int OpcoesUsuario(int opcao)
        {
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículo\n4 - Encerrar");
            opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }



        // LÓGICA DO SISTEMA(ADICIONA, REMOVE, LISTA CARROS)
        public void AdicionarVeiculos(List<string> veiculos)
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
            veiculos.Add(placa);
            Console.Clear();
        }

        public static int RemoveVeiculos(List<string> veiculos, int valorInicial, int valorPorHora)
        {
            if (veiculos.Count() > 0)
            {
                Console.WriteLine("Lista de veículos estacionados:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                Console.WriteLine("\nDigite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                if (veiculos.Contains(placa))
                {
                    veiculos.Remove(placa);
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int tempo = Convert.ToInt32(Console.ReadLine());
                    int total = valorInicial + valorPorHora * tempo;
                    Console.WriteLine($"O veículo {placa} foi removido e om preço final foi de: R$ {total}");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    return total;
                }
                else
                {
                    Console.WriteLine("Esse veículo não está registrado.");
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine();
                }
                Console.Clear();
                return 0;
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados no momento.\n");
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
            Console.Clear();
            return 0;
            
        }

        public void ListaVeiculos(List<string> veiculos)
        {
            if (veiculos.Count() > 0)
            {
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados no momento.\n");
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
