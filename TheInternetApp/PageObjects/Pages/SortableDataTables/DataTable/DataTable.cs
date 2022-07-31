using OpenQA.Selenium;
using TheInternetApp.PageObjects.Pages.SortableDataTables.Interfaces;

namespace TheInternetApp.PageObjects.Pages.SortableDataTables.DataTable;

public class DataTable : IDataTable
{
    public IWebDriver? WebDriver { get; init; }
    public string TableId { get; init; }

    public DataTable(string tableId, IWebDriver? webDriver)
    {
        WebDriver = webDriver;
        TableId = tableId;
    }

    public IWebElement GetColumnHeaderCell(int columnIndex)
    {
        IWebElement columnHeaderCell;

        try
        {
            columnHeaderCell = WebDriver.FindElement(By.CssSelector($"#{TableId} > thead > tr > th:nth-child({columnIndex + 1})"));
        }
        catch (NoSuchElementException noSuchElementException)
        {
            throw new NoSuchElementException($"Table header cell with index: {columnIndex} has not been found.",
                noSuchElementException);
        }

        return columnHeaderCell;
    }

    public IWebElement GetColumnCellValue(string columnName, int rowIndex)
    {
        throw new NotImplementedException();
    }

    public IWebElement GetColumnCellValue(int columnIndex, int rowIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IWebElement> GetColumnValues(int columnIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IWebElement> GetColumnValues(string columnName)
    {
        throw new NotImplementedException();
    }

    public DataTableRow GetRow(int rowIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IWebElement> GetHeaders()
    {
        throw new NotImplementedException();
    }
}
