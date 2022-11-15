using myPet.Data;

namespace myPet.Models
{
    public class Data
    {
        public List<Transaction> Transactions { get; set; }
        public Person CurrentPerson { get; set; }
        public List<Item> Items { get; set; }
        public List<Income> Incomes { get; set; }
        public Finance Finance { get; set; }

        //List<Transaction> InicializeTransactions(int personsID, DateOnly dateBegin, DateOnly dateEnd)
        //{
        //    Transactions = new List<Transaction>();

        //    return Transactions;
        //}
    }
}
