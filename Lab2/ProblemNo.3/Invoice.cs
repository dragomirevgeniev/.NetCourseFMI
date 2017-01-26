using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemNo._3
{
    public class Invoice
    {
        #region Fields
        private string partDescription;
        private string partNumber;
        private decimal pricePerItem;
        private int quantity;
        #endregion

        public Invoice(string partDescription, string partNumber, decimal pricePerItem, int quantity)
        {
            PartDescription = partDescription;
            PartNumber = partNumber;
            PricePerItem = pricePerItem;
            Quantity = quantity;
        }

        #region Properties
        public string PartDescription
        {
            get
            {
                return partDescription;
            }

            set
            {
                partDescription = value;
            }
        }

        public string PartNumber
        {
            get
            {
                return PartNumber;
            }

            set
            {
                partNumber = value;
            }
        }

        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }

            set
            {
                pricePerItem = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
        #endregion
        public decimal GetInvoiceAmount()
        {
            if (this.quantity >= 0 && this.pricePerItem >= 0)
            {
                return this.quantity * this.pricePerItem;
            }

            else
            {
                Console.WriteLine("Error in invoice ({0})! Either quantity is negative or price is negative.", this.ToString());
                return 0;
            }
        }

        public override string ToString()
        {
            return string.Format("PartNumber: {0}; PartDescription: {1}", this.partNumber, this.partDescription);
        }
    }
}