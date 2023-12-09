using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("TipoTorneo")]
public class TipoTorneoModels : BaseModels
{

    [MaxLength(45)]
    public string Nombre { get; set; } = "";

    [MaxLength(45)]
    public string Descripcion { get; set; } = "";


    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Descripcion}";
    
}



