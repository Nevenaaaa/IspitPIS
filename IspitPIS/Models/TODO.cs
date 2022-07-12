using System.ComponentModel.DataAnnotations;

namespace IspitPIS.Models
{
    public class TODO
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
    }
}
