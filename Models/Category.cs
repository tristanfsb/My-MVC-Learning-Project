using System.ComponentModel.DataAnnotations;

namespace MVC;

public class Category
{
    [Key] // This is from DataAnnotations and it's recognized by EF as the primary key of the model/object/table - It's not necessary if the property name is the same in the database table
    public int Id { get; set; } 
    [Required] // This is other DataAnnotation that specify that the property is needed in the model, it's like a NOT NULL in SQL
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
}
