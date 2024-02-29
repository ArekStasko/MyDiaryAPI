namespace MyDiaryAPI.Services.Services.XmlService;

public interface IXmlService
{
    public Task<string> Export();
    public Task<bool> Import();
}