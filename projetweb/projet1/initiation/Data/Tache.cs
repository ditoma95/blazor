using System.ComponentModel.DataAnnotations;
namespace initiation.Data;
public class Tache{
    [Required]
    [StringLength(maximumLength:30, MinimumLength =3, ErrorMessage ="le nombre de caractère doit âtre compris en 3 a 30" )]
    public string Nom {get; set;}

    [Required]
    [StringLength(maximumLength:100, MinimumLength =10, ErrorMessage ="le nombre de caractère doit âtre compris en 3 a 30" )]
    public string Description {get; set;}

    public Boolean Realise = false;
}