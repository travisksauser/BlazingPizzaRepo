using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Need to Provide a Name bud"), MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "You delivering this pizza to the Void?"), MaxLength(100)]
        public string Line1 { get; set; }
        [MaxLength(100)]
        public string Line2 { get; set; }
        [Required(ErrorMessage = "One pizza to Nowhere-Town comin right up"), MaxLength(50)]
        public string City { get; set; }
        [MaxLength(20)]
        public string Region { get; set; }
        [Required(ErrorMessage = "Just give a Postal Code atleast come on"), MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
