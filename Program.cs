using Newtonsoft.Json;
using tiendaCampus;
using tiendaCampus.Entities;
using tiendaCampus.View;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        if (Env.ValidarFile(Env.FileName)==false)
        {
            File.WriteAllText(Env.FileName,"");
        }else{
            Env.LoadDataProductos(Env.FileName);
        }
        Env.ImprimirData("dddd",Env.TiendaCampus.Categorias); 
        do{
            opcion=MenusView.MenuPrincipal();
            switch(opcion){
                case 1:
                    break;
                case 2:
                    Categoria.AddCategoria();
                    string json=JsonConvert.SerializeObject(Env.TiendaCampus,Formatting.Indented);
                    File.WriteAllText(Env.FileName,json);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }while(opcion!=3);
    }
}