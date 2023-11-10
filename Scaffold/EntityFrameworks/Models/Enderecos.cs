using System;
using System.Collections.Generic;

namespace Scaffold.EntityFrameworks.Models;

public partial class Enderecos
{
    public int Id { get; set; }

    public int? EmpresaId { get; set; }

    public int? EstadoID { get; set; }

    public string? Cep { get; set; }

    public string? Logradouro { get; set; }

    public string? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Complemento { get; set; }

    public string? Cidade { get; set; }

    public bool? Ativo { get; set; }
}
