using System.ComponentModel.DataAnnotations;
namespace initiation.Data;
public class Todo{
    [Required]
    [StringLength(100, ErrorMessage ="Le nom est trop long")]
    public string Nom {get; set;}
}