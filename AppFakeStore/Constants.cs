namespace AppFakeStore;

public static class Constants
{   
    //Variables contantes para conectarse de forma mas rapida y menos codigo.
    public static string AppName = "StoreNego";
    public static string ApiUrl = "https://localhost:7028/api/";
    public static string ApiUrlProductos = ApiUrl + "Productos";
    public static string ApiUrlUsuarios = ApiUrl + "Usuarios";
    public static string ApiUrlLogin = ApiUrl + "/Autenticacion/ValidarCredencial";
    public static string ApiUrlRegistro = ApiUrl + "Registro";
    public static string ApiUrlCarrito = ApiUrl + "CarritoCompras";


    public static string ApiUrlCarritoDetalle = ApiUrl + "carritodetalle";
    public static string ApiUrlCarritoDetalleProducto = ApiUrl + "carritodetalleproducto";
    public static string ApiUrlCarritoDetalleProductoCantidad = ApiUrl + "carritodetalleproductocantidad";
    public static string ApiUrlCarritoDetalleProductoPrecio = ApiUrl + "carritodetalleproductoprecio";
    public static string ApiUrlCarritoDetalleProductoTotal = ApiUrl + "carritodetalleproductototal";
    public static string ApiUrlCarritoDetalleProductoGrabar = ApiUrl + "carritodetalleproductograbar";
    public static string ApiUrlCarritoDetalleProductoEliminar = ApiUrl + "carritodetalleproductoeliminar";
    public static string ApiUrlCarritoDetalleProductoCancelar = ApiUrl + "carritodetalleproductocancelar";
    public static string ApiUrlCarritoDetalleProductoCancelarTodos = ApiUrl + "carritodetalleproductocancelartodos";
    public static string ApiUrlCarritoDetalleProductoGrabarTodos = ApiUrl + "carritodetalleproductograbartodos";
    public static string ApiUrlCarritoDetalleProductoTotalCarrito = ApiUrl + "carritodetalleproductototalcarrito";
    public static string ApiUrlCarritoDetalleProductoTotalCarritoGrabar = ApiUrl + "carritodetalleproductototalcarritograbar";
    public static string ApiUrlCarritoDetalleProductoTotalCarritoCancelar = ApiUrl + "carritodetalleproductototalcarritocancelar";
    public static string ApiUrlCarritoDetalleProductoTotalCarritoCancelarTodos = ApiUrl + "carritodetalleproductototalcarritocancelartodos";
    public static string ApiUrlCarritoDetalleProductoTotalCarritoGrabarTodos = ApiUrl + "carritodetalleproductototal";
}
