
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Full Name")]
        [StringLength(100)]
        [Required]

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Required]
        public string Email  { get; set; }
    }
}
