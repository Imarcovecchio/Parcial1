using Parcialherramientas.Utils;
namespace Parcialherramientas.Models;

public class Book{
    public int? Id { get; set; }
    public string Nombre{get;set;}
    public string Editorial { get; set; }
    public int Año { get; set; }
    public GeneroType Genero { get; set; } 

    public bool EstaReservado {get; set;} = false;

    //public int BookId{get;set;}

    public virtual Autor Autor {get; set;}
}
