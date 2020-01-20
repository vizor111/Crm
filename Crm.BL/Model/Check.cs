using System;
using System.Collections.Generic;

namespace Crm.BL.Model
{
    public class Check
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int SellerId { get; set; }

        public DateTime Created { get; set; }

        #region Navigation

        public virtual Customer Customer { get; set; }

        public virtual Seller Seller { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        #endregion
    }
}
