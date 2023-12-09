using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("ProgramarFecha")]
public class ProgramarFechaModels : BaseModels
{

    [MaxLength(30)]
    public string fecha_programada { get; set; } = "";

    [MaxLength(30)]
    public int inscripcion_equipo_id { get; set; } = 0;

    [MaxLength(30)]
    public int organizador_id { get; set; } = 0;


    public override string ToString() =>
    $"Id:{Id} - {fecha_programada} {inscripcion_equipo_id} {organizador_id}";

}




