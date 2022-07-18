using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;
using TheInternetApp.PageObjects.Pages.SortableDataTables.Interfaces;

namespace TheInternetApp.PageObjects.Pages.SortableDataTables;

public class HorizontalSliderObject : BasePageObject
{
    public IDataTable Example1DataTable { get; init; }
    public IDataTable Example2DataTable { get; init; }

    public HorizontalSliderObject(IWebDriver webDriver) : base(webDriver)
    {
        Example1DataTable = new DataTable.DataTable("table1", WebDriver);
        Example2DataTable = new DataTable.DataTable("table2", WebDriver);
    }
}
