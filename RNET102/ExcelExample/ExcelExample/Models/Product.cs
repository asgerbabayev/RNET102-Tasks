using ExcelExample.Models.Base;

namespace ExcelExample.Models
{
    class Product : NameAuditableEnitity
    {
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
