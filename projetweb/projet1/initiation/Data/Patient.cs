using System.ComponentModel.DataAnnotations;

namespace initiation.Data;
public class Patient
{
    public int ID { get; set; }

    [Required]
    [StringLength(maximumLength:30, MinimumLength =3, ErrorMessage ="le nombre de caractère doit âtre compris en 3 a 30" )]
    public string Nom { get; set; }

    [Required]
    [StringLength(maximumLength:30, MinimumLength =3, ErrorMessage ="le nombre de caractère doit âtre compris en 3 a 30" )]
    public string Prenom { get; set; }

    public int Age { get; set; }

    
}
