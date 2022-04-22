using System.ComponentModel.DataAnnotations;
namespace NongThanhNgan.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public List<News> News { get; set; }


    }
}
