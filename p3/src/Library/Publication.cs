using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    public class Publication
    {
        public DateTime EndDate { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }

        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }
        //Aqui aplicamos el patron expert porque Publication es el experto en informacion por lo que
        //es el que deberia tener la responsabilidad de calcular el total
        public double Total()
        {
            int total = 0;
            foreach (PublicationItem item in this.items)
            {
                total += item.Quantity * item.Price;
                
            }
            return total;
        }
    }
}