using Microsoft.AspNetCore.Mvc;
using ShoesCommerce.Models;

namespace ShoesCommerce.Components;

[ViewComponent(Name = "Header")]
public class HeaderViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = new List<HeaderViewModel> {
            new HeaderViewModel {
                LanguageCode = "tr-TR",
                LanguageName = "Türkçe"
            },
            new HeaderViewModel {
                LanguageCode = "en-US",
                LanguageName = "English"
            },
            new HeaderViewModel {
                LanguageCode = "ar-SA",
                LanguageName = "عربي"
            },
            new HeaderViewModel {
                LanguageCode = "ru",
                LanguageName = "Русский"
            }
        };

        return await Task.FromResult(View(model));
    }
}