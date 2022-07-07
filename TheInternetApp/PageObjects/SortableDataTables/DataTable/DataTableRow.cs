using OpenQA.Selenium;

namespace TheInternetApp.PageObjects.SortableDataTables.DataTable;

public class DataTableRow
{
    public string LastName { get; init; } = null!;
    public string FirstName { get; init; } = null!;
    public string Email { get; init; } = null!;
    public string Due { get; init; } = null!;
    public string WebSite { get; init; } = null!;
    public IReadOnlyCollection<IWebElement> Actions { get; init; } = null!;
}
