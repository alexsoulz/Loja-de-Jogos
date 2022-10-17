string[] jogos = new string[3] { "Hollow Knight", "Zelda", "Dark Souls" };
double[] precoVendas = new double[3] { 27.99, 299.99, 249.99 };
double[] precoEstoque = new double[3] { 14.99, 150.00, 125.00 };
int[] quantidade = new int[3] { 5, 3, 10 };
int vendas;
int comprasDeEstoque;

int op = 0;

while (op != 4) {
    Console.WriteLine("1 - Registrar venda" + "\n" + "2 - Compra de Estoque" + "\n" + "3 - Resumo da Loja" + "\n" + "4 - Sair");
    Console.WriteLine("\n" + "Opção desejada: ");
    op = int.Parse(Console.ReadLine());

    if (op == 1) {
        Console.WriteLine("\n" + "Jogo Vendido: ");
        string jogoVendido = Console.ReadLine();
        Console.WriteLine("Quantidade Vendida: ");
        int quantidadeVendida = int.Parse(Console.ReadLine());
    }
};
