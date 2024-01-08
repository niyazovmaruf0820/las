namespace Domain.Models;
using Domain.Models;
public class Category
{
    public int Id{get; set;}
    public string Name{get; set;}
    public DateTime CreatedAt{get; set;}
    public  List<Post> posts{get; set; } = new List<Post>();
}
