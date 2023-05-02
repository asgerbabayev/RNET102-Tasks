using ExcelExample.Models.Base;

namespace ExcelExample.Models
{
    class Category : NameAuditableEnitity
    {
        public Product[] Products { get; set; }
    }
}
