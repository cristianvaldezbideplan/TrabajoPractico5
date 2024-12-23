﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.mvvm.Models;

public class Usuarios
{
    public int? Id { get; set; }
    public string? Usuario { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? Domicilio { get; set; }
    public int IdRol { get; set; }
    public DateTime Fecha { get; set; }
    public string? Activo { get; set; }

}
