﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiApp1.Models;

[Table("Equipos")]
public class EquiposModels : BaseModels
{

    [MaxLength(30)]
    public string Nombre { get; set; } = "";

    [MaxLength(30)]
    public string descripcion { get; set; } = "";

    public override string ToString() =>
    $"Id:{Id} - {Nombre} {descripcion}";

}



