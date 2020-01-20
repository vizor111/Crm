namespace Crm.BL.Model
{
    public class Sell
    {
        public int Id { get; set; }

        public int CheckId { get; set; }

        public int ProductId { get; set; }

        #region Navigation

        public virtual Check Check { get; set; }

        public virtual Product Product { get; set; }

        #endregion
    }
}
