using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_sort.Models;

namespace razor_sort.Pages
{
    public class SupplierModel : PageModel
    {
        private readonly NorthwindContext _dbContext;

        public string SupplierName { get; set; }
        public SupplierModel(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(int id)
        {
            SupplierName = _dbContext.Suppliers
                .First(s => s.SupplierId == id).CompanyName;
        }
    }
}
