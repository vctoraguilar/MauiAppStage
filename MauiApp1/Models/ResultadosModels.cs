using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Resultados")]
public class ResultadosModels : BaseModels
{

    [MaxLength(45)]
    public string enfrentamiento_id { get; set; } = "";

    [MaxLength(45)]
    public string equipo_ganador { get; set; } = "";

    [MaxLength(45)]
    public string equipo_perdedor { get; set; } = "";

    public override string ToString() =>
    $"Id:{Id} - {enfrentamiento_id} {equipo_ganador} {equipo_perdedor}";
    
}


