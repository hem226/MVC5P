using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication2.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public override IQueryable<Product> All()
        {
            return base.All().Where(p => p.Active == true);
        }

        public IQueryable<Product> Get5Data()
        {
            return this.All().Take(5);
        }

        public Product find(int id)
        {
            return this.All().FirstOrDefault(p => p.ProductId == id);
        }

	}

	public  interface IProductRepository : IRepository<Product>
	{

	}
}