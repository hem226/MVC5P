using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication2.Models
{   
	public  class vwSummaryPriceRepository : EFRepository<vwSummaryPrice>, IvwSummaryPriceRepository
	{

	}

	public  interface IvwSummaryPriceRepository : IRepository<vwSummaryPrice>
	{

	}
}