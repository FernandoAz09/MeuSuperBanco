namespace MeuSuperBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            MeuSuperBanco.ContaBanco contaB = new ContaBanco("Fernando", 50000);

            Console.WriteLine($"1- A conta {contaB.Numero} do {contaB.Dono} foi criada com o saldo de {contaB.Saldo}");

            contaB.Depositar(100, DateTime.Now, "PAGO");

            Console.WriteLine($"2- A conta {contaB.Numero} do {contaB.Dono} está com {contaB.Saldo}");

            contaB.Sacar(1000, DateTime.Now, "PAGO");

            Console.WriteLine($"3- A conta {contaB.Numero} do {contaB.Dono} está com {contaB.Saldo}");

        }
    }
}