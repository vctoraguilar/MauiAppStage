using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Organizadores")]
public class OrganizadoresModels : BaseModels
{

    [MaxLength(30)]
    public int usuario_id { get; set; } = 0;

    
    public override string ToString() =>
    $"Id:{Id} - {usuario_id} ";
    
}
