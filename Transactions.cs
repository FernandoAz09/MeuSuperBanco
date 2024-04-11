namespace MeuSuperBanco
{
    public class Transactions
    {
        public decimal Valor {  get; set; }
        public DateTime Date { get; set; }
        public string Obs {  get; set; }

        public Transactions(decimal valor, DateTime date, string obs)
        {
            this.Valor = valor;
            this.Date = date;
            this.Obs = obs;
        }
    }
}
