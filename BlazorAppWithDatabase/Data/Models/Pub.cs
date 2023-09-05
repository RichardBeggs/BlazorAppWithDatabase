using System.ComponentModel.DataAnnotations;

namespace BlazorAppWithDatabase.Data.Models
{
    public class Pub
    {
        public Pub()
        {
            
        }
        [Required]
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        [Required]
        public string? City { get; set; }
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
