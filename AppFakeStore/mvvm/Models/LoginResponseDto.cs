﻿namespace AppFakeStore.mvvm.Models;

public class LoginResponseDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public int IdRol { get; set; }
    public bool Autenticado { get; set; }
    public string Token { get; set; }
}
