using Domain.Models;
using Infrastructure.Services;

Category transport = new Category();
transport.Id = 1;
transport.Name = "Transport";
transport.CreatedAt = DateTime.UtcNow;

var post1 = new Post();
post1.Id = 1;
post1.Title = "Buses";
post1.Description = "Are very sefity.";
post1.CreatedAt = DateTime.UtcNow;
post1.CategoryId = 1;

var post2 = new Post();
post2.Id = 2;
post2.Title = "AirPlanes";
post2.Description = "Are very expensive,but very fast.";
post2.CreatedAt = DateTime.UtcNow;
post2.CategoryId = 1;

var post3 = new Post();
post3.Id = 3;
post3.Title = "Trains";
post3.Description = "Are cheaper than airplanes,but very slow.";
post3.CreatedAt = DateTime.UtcNow;
post3.CategoryId = 1;

transport.posts.Add(post1);
transport.posts.Add(post2);
transport.posts.Add(post3);

CategoryService.CreateCategory(transport);

foreach (var category in CategoryService.Getcategories())
{
    System.Console.WriteLine("---------------------------Categories:---------------------------");
    System.Console.WriteLine(category.Id);
    System.Console.WriteLine(category.Name);
    System.Console.WriteLine(category.CreatedAt);
    System.Console.WriteLine();
    System.Console.WriteLine("--------------------------Posts:---------------------------- ");
    foreach (var post in transport.posts)
    {
        System.Console.WriteLine(post.Id);
        System.Console.WriteLine(post.Title);
        System.Console.WriteLine(post.CreatedAt);
        System.Console.WriteLine("---------------------------");
    }
}
