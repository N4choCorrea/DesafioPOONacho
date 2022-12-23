using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public PublicationDiscount(int amount)
        {
            
            if (amount > 0)
            {
                throw new ArgumentException("El descuento debe ser negativo");
            }
            
            this.SubTotal = amount;
        }

    }
}