﻿using AppFakeStore.mvvm.Models;
using AppFakeStore.mvvm.ViewModels;
using AppFakeStore.mvvm.Views;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Text;

namespace AppFakeStore;

public class ApiService
{
    ////Local Host de Windows.
    private static readonly string BASE_URL = "https://localhost:7028/api/";

    //Local host del ITES. Android
    //private static readonly string BASE_URL = "https://172.23.2.197:7028/api/";

    //Local host de mi casa. Android
    //private static readonly string BASE_URL = "https://192.168.1.102:7028/api/";

    static HttpClient httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(60) };

    public static async Task<List<Producto>> GetProductos()
    {
        string FINAL_URL = BASE_URL + "Productos";

        try
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, FINAL_URL);
            // inyectamos token JWT obtenido de API al realizar Login
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Transport.Token);

            // var response = await httpClient.GetAsync(FINAL_URL);
            var response = await httpClient.SendAsync(requestMessage);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(jsonData))
                {
                    // Inside the ApiService class
                    var responseObject = JsonSerializer.Deserialize<List<Producto>>(jsonData,
                        new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true
                        });
                    return responseObject!;
                }
                else
                {
                    Exception exception = new Exception("Resource Not Found");
                    throw new Exception(exception.Message);
                }
            }
            else
            {
                Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                throw new Exception(exception.Message);
            }
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    public static async Task<List<Producto>> GetProductosAsync()
    {
        string FINAL_URL = BASE_URL + "Productos";

        try
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, FINAL_URL);
            // inyectamos token JWT obtenido de API al realizar Login
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Transport.Token);

            // var response = await httpClient.GetAsync(FINAL_URL);
            var response = await httpClient.SendAsync(requestMessage);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(jsonData))
                {
                    // Inside the ApiService class
                    var responseObject = JsonSerializer.Deserialize<List<Producto>>(jsonData,
                        new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true
                        });
                    return responseObject!;
                }
                else
                {
                    Exception exception = new Exception("Resource Not Found");
                    throw new Exception(exception.Message);
                }
            }
            else
            {
                Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                throw new Exception(exception.Message);
            }
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

    // validar login de usuario

    public async Task<LoginResponseDto> ValidarLogin(string _email, string _password)
    {
        string FINAL_URL = BASE_URL + "Autenticacion/Validar";

        var loginParams = new StringContent(
                        JsonSerializer.Serialize(
                            new
                            {
                                email = _email,
                                password = _password,
                                //password = Encriptar.GetSHA256(_password),

                            }),
                            Encoding.UTF8, "application/json"
                        );
        try
        {
            var result = await httpClient.PostAsync(FINAL_URL, loginParams).ConfigureAwait(false);

            var json = await result.Content.ReadAsStringAsync();

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var responseLogin = JsonSerializer.Deserialize<LoginResponseDto>(json,
                    new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true
                    });

                return responseLogin;
            }
            else
            {
                return null;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public static async Task<bool> AgregarProducto(Producto _producto)
    {
        // metodo body-json
        string FINAL_URL = BASE_URL + "productos";

        try
        {
            var content = new StringContent(
                    JsonSerializer.Serialize(_producto),
                    Encoding.UTF8, "application/json"
                );

            var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);


            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static async Task<bool> AgregarProductoConImagen(Producto _producto)
    {
        // metodo con form-data
        string FINAL_URL = BASE_URL + "productos/CrearConImagen";

        try
        {

            // check if the image is null
            if (_producto.Imagen == null)
            {
                throw new Exception("Imagen no puede ser nula");
            }

            var content = new MultipartFormDataContent();
            content.Add(new StringContent(_producto.NumeroProducto), "numero");
            content.Add(new StringContent(_producto.NombreProducto), "nombre");
            content.Add(new StringContent(_producto.Descripcion), "descripcion");
            content.Add(new StringContent(_producto.Medidas), "Medidas");
            content.Add(new StringContent(_producto.Stock.ToString()), "stock");
            content.Add(new StringContent(_producto.Precio.ToString()), "precio");
            content.Add(new StringContent(_producto.Cantidad.ToString()), "cantidad");
            content.Add(new StringContent(_producto.Peso.ToString()), "Peso");
            content.Add(new StringContent(_producto.Categoria.ToString()), "categoria");
            content.Add(new StreamContent(await _producto.Imagen.OpenReadAsync()), "imagen", _producto.RutaImagen);

            var result = await httpClient.PostAsync(FINAL_URL, content).ConfigureAwait(false);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }


    }
    public static async Task<Producto> GetProductoPorId(int id)
    {
        // string FINAL_URL = BASE_URL + "Productos/ObtenerPorId/"+id;

        string URL = "https://localhost:7028/api/Productos/ObtenerPorId/" + id;

        try
        {
            var response = await httpClient.GetAsync(URL);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(jsonData))
                {
                    // Inside the ApiService class
                    var responseObject = JsonSerializer.Deserialize<Producto>(jsonData,
                        new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                            WriteIndented = true
                        });
                    return responseObject!;
                }
                else
                {
                    Exception exception = new Exception("Resource Not Found");
                    throw new Exception(exception.Message);
                }
            }
            else
            {
                Exception exception = new Exception("Request failed with status code " + response.StatusCode);
                throw new Exception(exception.Message);
            }
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }
    }

}
