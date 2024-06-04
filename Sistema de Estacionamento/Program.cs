using Sistema_de_Estacionamento.Models;


// VARIÁVEIS E LISTA DO SISTEMA(BLOCO INICIAL)
Estacionamento Estacionamento = new Estacionamento();

List<string> veiculos = new List<string>();

int valorInicial = Estacionamento.ValorInicial(Estacionamento.valores);
int valorPorHora = Estacionamento.ValorHora(Estacionamento.valores);
int valorTotal = 0;
int totalDoDia = 0;
// CORPO PRINCIPAL DO SISTEMA(BLOCO DO LOOP)
do
{
    int opcao = Estacionamento.OpcoesUsuario(Estacionamento.valores);

    if (opcao == 4)
    {
        break;
    }

    switch (opcao)
    {
        case 1:
            Estacionamento.AdicionarVeiculos(veiculos);
            break;
        case 2:
            valorTotal = Estacionamento.RemoveVeiculos(veiculos, valorInicial, valorPorHora); 
            totalDoDia += valorTotal;
            break;
        case 3:
            Estacionamento.ListaVeiculos(veiculos);
            break;
    }
}
while(true);

Console.WriteLine("\nO programa se encerrou.\n");
Console.WriteLine($"O lucro do dia foi: {totalDoDia}");

    

