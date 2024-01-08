using Domain.Models;

namespace Infrastructure.Services;

public static class CategoryService
{
    public static List<Category> categories = new List<Category>();
    public static void CreateCategory(Category Category)
    {
        categories.Add(Category);
    }
    public static List<Category> Getcategories()
    {
        return categories;
    }
    public static Category GetCategoryById(int id)
    {
        var category = categories.FirstOrDefault(e => e.Id == id);
        return category;
    }
    public static Category GetCategoryByName(string name)
    {
        var category = categories.FirstOrDefault(e => e.Name == name);
        return category;
    }
    public static Category GetCategoryByData(DateTime date)
    {
        var category = categories.FirstOrDefault(e => e.CreatedAt == date);
        return category;
    }
    public static void DeleteCategory(int id)
    {
        var category = categories.FirstOrDefault(e => e.Id == id);
        categories.Remove(category);
    }   
}
