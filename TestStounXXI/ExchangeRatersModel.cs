namespace TestStounXXI
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ExchangeRatersModel : DbContext
    {
        public ExchangeRatersModel()
            : base("name=ExchangeRatersModel")
        {
        }

         public virtual DbSet<DirectoryCurr> DirectoryCurrence { get; set; }
         public virtual DbSet<ExchangeRat> ExchangeRates { get; set; }


    }
}