using Parcialherramientas.Models;
namespace Parcialherramientas.ViewModels;


public class BookViewModel{
    public List<Book> Books{get;set;} = new List<Book>();

    public string? NameFilter{get;set;}

}