int opcaoMenu = 0;
int numeroPedido = 0;

Queue<(int, string)> filaDePedidos = new();
Stack<(int, string)> pilhaDePedidosConcluúdos = new();

while (opcaoMenu != 5)
{
    Console.WriteLine("\nEscolha uma opção\n1 - Adicionar Pedido\n2 - Preparar Pedido\n3 - Visualizar Pedidos Pendentes\n4 - Visualizar Pedidos Concluídos\n5 - Sair\n");
    try
    {
        opcaoMenu = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        opcaoMenu = 0;
    }

    switch (opcaoMenu)
    {
        case 1:
            Console.WriteLine("Digite o seu pedido:");
            numeroPedido++;
            filaDePedidos.Enqueue((numeroPedido, Console.ReadLine() ?? ""));
            break;

        case 2:
            if (filaDePedidos.Count == 0)
            {
                Console.WriteLine("Não há pedidos há ser preparados.");
                break;
            }
            Console.WriteLine("Seu pedido será preparado em instantes...");
            pilhaDePedidosConcluúdos.Push(filaDePedidos.Dequeue());
            Thread.Sleep(700);
            Console.WriteLine("Pedido prontinho!");
            break;

        case 3:
            if (filaDePedidos.Count == 0)
            {
                Console.WriteLine("Não há pedidos pendentes.");
                break;
            }
            Console.WriteLine("Pedidos pedentes\n");
            foreach (var pedido in filaDePedidos)
            {
                Console.WriteLine($" Pedido #{pedido.Item1} - {pedido.Item2}");
            }
            break;

        case 4:
            if (pilhaDePedidosConcluúdos.Count == 0)
            {
                Console.WriteLine("Não há pedidos concluídos.");
                break;
            }
            Console.WriteLine("Pedidos concluídos:");
            foreach (var pedido in pilhaDePedidosConcluúdos)
            {
                Console.WriteLine($" Pedido #{pedido.Item1} - {pedido.Item2}");
            }
            break;

        case 5:
            Console.WriteLine("Fim.");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}