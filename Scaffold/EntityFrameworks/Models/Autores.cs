using System;
using System.Collections.Generic;

namespace Scaffold.EntityFrameworks.Models;

public partial class Autores
{
    public int AutorID { get; set; }

    public string? NomeAutor { get; set; }

    public virtual ICollection<Livros> Livros { get; set; } = new List<Livros>();
}
