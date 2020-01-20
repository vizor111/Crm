using System.Collections.Generic;

namespace Crm.BL.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        #region Navigation

        public virtual ICollection<Sell> Sells { get; set; }

        #endregion
    }
}
