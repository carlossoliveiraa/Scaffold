using System;
using System.Collections.Generic;

namespace Scaffold.EntityFrameworks.Models;

public partial class Livros
{
    public int LivroID { get; set; }

    public string? TituloLivro { get; set; }

    public int? AutorID { get; set; }

    public virtual Autores? Autor { get; set; }
}
