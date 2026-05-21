using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMVCOracle.Models
{
    [Table("PRODUCTOS_O")]
    public class Producto
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string NOMBRE { get; set; }
        
        public decimal PRECIO { get; set; }

        public int STOCK { get; set; }

        public DateTime FECHA_REGISTRO { get; set; }
    }   
}   
