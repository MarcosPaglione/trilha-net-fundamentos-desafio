namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
         // Iplementado!! Pede para o usuário digitar uma placa, converte pra maiscula e adicionar na lista "veiculos"
            Console.WriteLine("Digite a Placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para Remover:");

         // Implementado!! Pede para o usuário digitar a Placa e armazena na variável placa
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de Horas que o veículo permaneceu estacionado:");

         /* Implementado!! Pede para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            converte a string para int, Realiza o cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal */               
                //double horas = Convert.ToDouble(Console.ReadLine());
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Implementado!! Remove a placa digitada da lista de veículos
                veiculos.Remove(placa); 

                Console.WriteLine($"O veículo {placa} foi removido! \nPreço Total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
             // Implementado!! Realiza um laço de repetição, exibindo os veículos estacionados
                foreach (string exibir in veiculos)
                {
                    Console.WriteLine(exibir);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
