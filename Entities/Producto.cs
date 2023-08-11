namespace tiendaCampus.Entities;
using Newtonsoft.Json;
public class Producto
{
    private string idProducto;
    private string nombreProducto;
    private int stock;
    private int stockMin;
    private int stockMax;
    private double valorVenta;
    private double valorCompra;
    private int idCategoria;

    public Producto()
    {
        if (!File.Exists(Env.FileName))
        {
            File.WriteAllText(Env.FileName,"");
        }
    }

    public string IdProducto 
    {
        get {return idProducto;}
        set{idProducto=value;}
    }
    public string NombreProducto
    {
        get {return nombreProducto;}
        set{nombreProducto=value;}
    }
    public int Stock
    {
        get {return stock;}
        set{stock=value;}
    }
    public int StockMin
    {
        get {return stockMin;}
        set{ stockMin=value;}
    }
    public int StockMax
    {
        get {return stockMax;}
        set{ stockMax=value;}
    }
    public double ValorVenta
    {
        get{return valorVenta;}
        set{ valorVenta=value;}
    }
    public double ValorCompra
    {
        get{return valorCompra;}
        set{ valorCompra=value;}
    }
    public int IdCategoria
    {
        get {return idCategoria;}
        set{ idCategoria=value;}
    }

    public void AddProducto(){
        Producto p = new Producto();
        Console.WriteLine("Ingrese Id producto: ");
        p.IdProducto =Console.ReadLine();
        Console.WriteLine("Ingrese Nombre del producto: ");
        p.NombreProducto=Console.ReadLine();
        Console.WriteLine("Ingrese Stock Actual: ");
        p.Stock=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Stock Minimo: ");
        p.StockMin=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Stock Maximo");
        p.StockMax=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Valor de Compra:");
        p.ValorCompra=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese Valor de Venta:");
        p.ValorVenta=double.Parse(Console.ReadLine());
        Env.TiendaCampus.Productos.Add(p);

    }
    
}