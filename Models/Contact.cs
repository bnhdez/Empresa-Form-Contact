using System;
using System.Collections.Generic;

namespace Empresa_Form_Contact.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? Mensaje { get; set; }
}
