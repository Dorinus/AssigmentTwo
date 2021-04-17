using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    [Required, MinLength(1)]
    public string FirstName { get; set; }
    [Required, MinLength(2)]
    public string LastName { get; set; }
    [Required, MinLength(4)]
    public string HairColor { get; set; }
    [Required, MinLength(4)]
    public string EyeColor { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1} and smaller than {125}")]
    public int Age { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {0.1} and smaller than {125}")]
    public float Weight { get; set; }
   [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {30} and smaller than {125}")]
    public int Height { get; set; }
    [Range(typeof(char), "F", "M", ErrorMessage = "Please enter F or M")]
    public string Sex { get; set; }
}


}