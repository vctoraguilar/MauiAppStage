using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Usuarios")]
public class UsuariosModels : BaseModels
{

    [MaxLength(50)]
    public string Nombre { get; set; } = "";

    [MaxLength(50)]
    public string Apellido { get; set; } = "";

    [MaxLength(50)]
    public string email { get; set; } = "";

    [MaxLength(100)]
    public string direccion { get; set; } = "";

    [MaxLength(30)]
    public int organizador_id { get; set; } = 0;

    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Apellido} {email} {direccion} {organizador_id} ";
    
}


