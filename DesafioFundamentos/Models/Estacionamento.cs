using System;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private double precoInicial;
        private double precoPorHora;
        private List<string> veiculos;

        public Estacionamento(double precoInicial, double precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo(double precoInicial, double precoPorHora)
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();
            Console.WriteLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                double horas = Convert.ToDouble(Console.ReadLine());

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                double valorTotal = (precoInicial + precoPorHora) * horas;

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine();

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
                Console.WriteLine($"Deculpe, a placa {placa} não existe!");
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                for(int i =0; i < veiculos.Count; i++)
                {
                  //faça um for para colocar a posição e n a quantiade total de veiculos
                    Console.WriteLine($"Veículo: {i + 1}  Placa: {veiculo[i]}");
                }
             }
            else            
                Console.WriteLine("Não há veículos estacionados.");
            
        }
    }
}
