﻿using System.Collections.Generic;

namespace Crm.BL.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        #region Navigation

        public virtual ICollection<Check> Checks { get; set; }

        #endregion
    }
}
