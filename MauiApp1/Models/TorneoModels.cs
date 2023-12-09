using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Torneo")]
public class TorneoModels : BaseModels
{

    [MaxLength(50)]
    public string Nombre { get; set; } = "";

    [MaxLength(100)]
    public string Descripcion { get; set; } = "";

    [MaxLength(30)]
    public int Organizador_id { get; set; } = 0;

    [MaxLength(30)]
    public string fecha_inicio { get; set; } = "";

    [MaxLength(30)]
    public string fecha_fin { get; set; } = "";

    [MaxLength(30)]
    public int tipo_torneo_id { get; set; } = 0;

    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Descripcion} {Organizador_id} {fecha_inicio} {fecha_fin} {tipo_torneo_id} ";
    
}

public abstract class BaseModels

{

    public int Id { get; set; }

}


