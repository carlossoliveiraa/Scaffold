using System;
using System.Collections.Generic;

namespace Scaffold.EntityFrameworks.Models;

public partial class Empresas
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Cnpj { get; set; }

    public string? Cpf { get; set; }

    public string? InscricaoEstadual { get; set; }

    public DateTime? DataAbertura { get; set; }

    public string? Site { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public bool? Ativo { get; set; }
}
