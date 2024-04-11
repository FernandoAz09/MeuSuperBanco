namespace MeuSuperBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco contaB = new ContaBanco("Fernando", 50000);

            Console.WriteLine($"A conta {contaB.Numero} do {contaB.Dono} foi criada com o saldo de {contaB.Saldo}");
        }
    }
}