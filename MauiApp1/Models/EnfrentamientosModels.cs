using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Enfrentamientos")]
public class EnfrentamientosModels : BaseModels
{

    [MaxLength(30)]
    public string Primer_equipo { get; set; } = "";

    [MaxLength(30)]
    public string Segundo_equipo { get; set; } = "";

    [MaxLength(30)]
    public int Torneo_id { get; set; } = 0;

    [MaxLength(30)]
    public int equipo_id { get; set; } = 0;

    public override string ToString() =>
    $"Id:{Id} - {Primer_equipo} {Segundo_equipo} {Torneo_id} {equipo_id}";
    
}



