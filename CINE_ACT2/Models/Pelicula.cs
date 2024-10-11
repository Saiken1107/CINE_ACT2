using System;
using System.Collections.Generic;

namespace CINE_ACT2.Models;

public partial class Pelicula
{
    public int PeliculaId { get; set; }

    public string? Titulo { get; set; }

    public string? Director { get; set; }

    public int? Año { get; set; }
}
