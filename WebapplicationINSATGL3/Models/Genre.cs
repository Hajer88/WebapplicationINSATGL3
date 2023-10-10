using System.ComponentModel.DataAnnotations;

namespace WebapplicationINSATGL3.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        
        [ConcurrencyCheck]
        public string Name { get; set; }
    }
}
