using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class SlideText
{
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Title { get; set; }
    [Required, MaxLength(200)]
    public string Description { get; set; }
    [Required]
    public string Image { get; set; }
}
