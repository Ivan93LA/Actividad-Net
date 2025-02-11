var sale = new Sale();
var beer = new Beer();

Some(sale);
Some(beer);

void Some (Isave save)
{
    save.Save();
}

interface Isale
{ 
   decimal Total { get; set; }
}


interface Isave
{
    public void save();
}

public class Sale : Isale, Isave
{
   public decimal Total { get; set; }
    public void save()
    {
        Console.WriteLine("Se guardó en la bbdd");
    }

}
//Para categorizar las clases
public class Beer : Isave
{
    public void Save()
    {
        Console.WriteLine("Se guardó en el Servicio");
    }

}