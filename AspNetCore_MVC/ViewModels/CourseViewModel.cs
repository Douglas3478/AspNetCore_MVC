    namespace AspNetCore_MVC.ViewModels;

public class CourseViewModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = null!;
    public string? ImageName { get; set; }
    public string? Author { get; set; }
    public bool IsBestSeller { get; set; }
    public int Hours { get; set; }
    public string? OriginalPrice { get; set; }
    public string? DiscountPrice { get; set; } 
    public decimal LikesInProcent { get; set; }
    public decimal LikesInNumber { get; set; }
}
