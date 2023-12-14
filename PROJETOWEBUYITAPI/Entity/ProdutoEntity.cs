using System.ComponentModel.DataAnnotations.Schema;

namespace PROJETOWEBUYITAPI.Entity
{
    public class ProdutoEntity
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal? OriginalPrice { get; set; }

        public decimal? CurrentPrice { get; set; }

        public decimal? Discount { get; set; }

        public int? Buyers { get; set; }


      



    
    
    }
}
