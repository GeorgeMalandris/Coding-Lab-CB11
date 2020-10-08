using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05102020
{
    class CreditCard
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public bool IsActive { 
            get 
            {
                if (ExpirationDate > DateTime.Now)
                    return true;
                else
                    return false;
            } 
        }
        public DateTime ExpirationDate { get; set; }
        public Student Owner { get; set; }
        public CreditCard(int id, string cardName, string cardNumber, DateTime expirationDate, Student owner)
        {
            if (owner == null)
            {
                Console.WriteLine("No student - No Credit card");
                return;
            }

            this.Id = id;
            this.CardName = cardName;
            this.CardNumber = cardNumber;
            this.ExpirationDate = expirationDate;
            this.Owner = owner;
        }
    }
}
