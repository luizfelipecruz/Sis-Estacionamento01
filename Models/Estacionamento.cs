namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 4;
        private decimal precoPorHora = 3;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Add_Placa = Console.ReadLine();
            veiculos.Add(Add_Placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string Remover_Placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == Remover_Placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int.TryParse(Console.ReadLine(), out int N_horas);
                decimal valorTotal = precoInicial + precoPorHora * N_horas;


                veiculos.Remove(Remover_Placa);
                Console.WriteLine($"O veículo {Remover_Placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                
                int contador = 0;
                foreach(string item in veiculos)
                {
                    Console.WriteLine($" Nº{contador + 1} - {item}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
