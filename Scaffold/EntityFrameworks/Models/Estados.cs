using System;
using System.Collections.Generic;

namespace Scaffold.EntityFrameworks.Models;

public partial class Estados
{
    public int Id { get; set; }

    public string? UF { get; set; }

    public string? Sigla { get; set; }

    public string? Regiao { get; set; }
}
