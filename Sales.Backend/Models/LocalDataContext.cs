namespace Sales.Backend.Models
{
    using Sales.Domain.Models;
    using System.Data.Entity;

    public class LocalDataContext :DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
   
}