using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("InscripcionEquipos")]
public class InscripcionEquiposModels : BaseModels
{

    [MaxLength(30)]
    public string torneo_id { get; set; } = "";

    [MaxLength(30)]
    public string equipo_id { get; set; } = "";

    [MaxLength(30)]
    public string programar_fecha { get; set; } = "";

    public override string ToString() =>
    $"Id:{Id} - {torneo_id} {equipo_id} {programar_fecha}";
    
}



