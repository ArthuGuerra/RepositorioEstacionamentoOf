using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamentoDois.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;  
        private decimal precoPorHora = 0;    
        
        private List<string> veiculos = new List<string>();

        public Estacionamento (decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;

        }

        public string placa { get; set; }
        
      


        public void AdicionarVeiculo()
        {

            Console.WriteLine("Escreva a placa do seu veículo nesse formato: (XXX-0000)");
            placa = Console.ReadLine();
            bool placaVeiculo = veiculos.Any(x => x.ToUpper() == placa.ToUpper());  // verifica se ja existe a placa estacionada
          
            if (placaVeiculo)
            {

                Console.WriteLine("Este veículo ja está estacionado. Verifique se digitou a placa errada. Caso contrário, chame a polícia!!");
                Console.WriteLine("Aperte qualquer botão");
                Console.ReadLine();
     
            } 
            else {
               
                veiculos.Add(placa);
                Console.WriteLine("Veículo adiconado, obrigado.");
                Console.WriteLine("Aperte qualquer botão");
                Console.ReadLine();
            } 
         

        }


        public void RemoverVeiculo()
        {
            Console.WriteLine("Escreva a placa do seu veículo nesse formato: (XXX-0000)");
            placa = Console.ReadLine();
            bool placaVeiculo = veiculos.Any(x => x.ToUpper() == placa.ToUpper()); 

            if (placaVeiculo)
            {
                Console.WriteLine("Quantas horas o veículo permaneceu no estacionamento ?");
                decimal horas = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($" O valor para retirada é {precoInicial + (precoPorHora * horas)} ");
                Console.ReadLine();
                veiculos.Remove(placa);
                Console.WriteLine("Veículo retirado. Volte sempre!");
                Console.WriteLine("Aperte qualquer botão");
                Console.ReadLine();
     
            } 
            else {
                Console.WriteLine("Esse carro não está aqui. Verifique se colocou a placa certa!");
                 Console.WriteLine("Aperte qualquer botão");
                Console.ReadLine();
            } 
        }


        public void Listar()
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"Veiculo{i + 1}: {veiculos[i]}");
            }
            
            Console.WriteLine("Aperte qualquer botão");
            Console.ReadLine();
        }





    }
}