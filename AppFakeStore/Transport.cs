using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore;

public static class Transport
{
    public static int IdUsuario { get; set; }
    public static string NombreUsuario { get; set; } = string.Empty;
    public static string EmailUsuario { get; set; } = string.Empty;
    public static int RolUsuario { get; set; }
    public static string Token { get; set; } = string.Empty;
}
