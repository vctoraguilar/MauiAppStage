using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Cuenta")]
public class CuentaModels : BaseModels
{

    [MaxLength(30)]
    public string contra { get; set; } = "";

    [MaxLength(30)]
    public string email { get; set; } = "";

    [MaxLength(30)]
    public int usuario_id { get; set; } = 0;


    public override string ToString() =>
    $"Id:{Id} - {contra} {email} {usuario_id}";

}


