using Core.Entities;

namespace WebUI.ViewModels;

public class HomeVM
{
    public IEnumerable<SlideItem> SlideItems { get; set; }
    public SlideText SlideTexts { get; set; }
}
