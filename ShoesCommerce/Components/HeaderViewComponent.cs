using Microsoft.AspNetCore.Mvc;
using ShoesCommerce.Models;

namespace ShoesCommerce.Components;

public class HeaderViewComponent : ViewComponent
{
    private readonly IConfiguration _configuration;
    public HeaderViewComponent(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var availableLanguages = new List<Language> {
            new Language {
                ShortCode = "tr",
                Code = "tr-TR",
                Name = "Türkçe"
            },
            new Language {
                ShortCode= "en",
                Code = "en-US",
                Name = "English"
            },
            new Language {
                ShortCode = "arsa",
                Code = "ar-SA",
                Name = "عربي"
            },
            new Language {
                ShortCode = "ru",
                Code = "ru",
                Name = "Русский"
            }
        };
        var availableCurrencies = new List<Currency> {
            new Currency {
                Symbol = "$",
                Code = "USD",
                Name = "USD"
            },
            new Currency {
                Symbol = "₺",
                Code = "TRY",
                Name = "TL"
            }
        };

        var model = new HeaderViewModel
        {
            PhoneNumber = _configuration.GetSection("Shoes")["Phone"] ?? "----",
            Languages = availableLanguages,
            Currencies = availableCurrencies
        };

        return await Task.FromResult(View(model));
    }
}