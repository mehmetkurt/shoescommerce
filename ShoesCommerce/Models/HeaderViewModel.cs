namespace ShoesCommerce.Models;

public class HeaderViewModel
{
    public string PhoneNumber { get; set; }
    public List<Language> Languages { get; set; }
    public List<Currency> Currencies { get; set; }
}

public class Language
{
    public string ShortCode { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
}

public class Currency
{
    public string Symbol { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
}