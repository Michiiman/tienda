namespace tiendaCampus.View;

public static class MenusView{
    
    public static int MenuPrincipal(){
        Console.Clear();
        Console.WriteLine("1.Registro de productos");
        Console.WriteLine("2.Registro de categorias");
        Console.WriteLine("3.Salir.");
        Console.WriteLine("-------------------------");
        Console.Write("Digite la opcion: ");
        return int.Parse(Console.ReadLine());

    }

}