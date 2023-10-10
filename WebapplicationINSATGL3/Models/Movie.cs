using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebapplicationINSATGL3.Models
{
    //Faire une recherche par Index pour plus d'efficacité
    //PAr convention, les clés étrangères possèdent des Index
    [Index(nameof(Name))]
    public class Movie
    {
        public  int Id { get; set; }
        [ConcurrencyCheck]
        public string Name { get; set; }
       
    }
}
