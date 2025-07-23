using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Taller.Models
{
    public class TaskItem
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required(ErrorMessage = "The 'Name' field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The 'Description' field is required.")]
        public string Description { get; set; }
    }
}
