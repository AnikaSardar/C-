namespace Assign05
{
    /// <summary>
    /// Invoice class
    /// </summary>
    public class Invoice
    {
        // declare variables for Invoice object
        private int quantityValue;
        private decimal priceValue;

        // auto-implemented property PartNumber
        public int PartNumber { get; set; }

        // auto-implemented property PartDescription
        public string PartDescription { get; set; }

        /// <summary>
        /// four-argument constructor
        /// </summary>
        /// <param name="part"></param>
        /// <param name="description"></param>
        /// <param name="count"></param>
        /// <param name="pricePerItem"></param>
        public Invoice(int part, string description,
           int count, decimal pricePerItem)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            Price = pricePerItem;
        }

        /// <summary>
        /// property for quantityValue; ensures value is positive
        /// </summary>
        public int Quantity
        {
            get
            {
                return quantityValue;
            }
            set
            {
                if (value > 0) // determine whether quantity is positive
                {
                    quantityValue = value; // valid quantity assigned
                }
            }
        }

        /// <summary>
        /// property for pricePerItemValue; ensures value is positive
        /// </summary>
        public decimal Price
        {
            get
            {
                return priceValue;
            }
            set
            {
                if (value >= 0M) // determine whether price is non-negative
                {
                    priceValue = value; // valid price assigned
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>string containing the fields in the Invoice in a nice format</returns>
        public override string ToString()
        {
            return $"{PartNumber,-5} {PartDescription,-20} {Quantity,-5} {Price,6:C}";
        }
    }
}