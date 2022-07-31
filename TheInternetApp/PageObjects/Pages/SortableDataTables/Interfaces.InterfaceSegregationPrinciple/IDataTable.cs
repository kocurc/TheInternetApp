using OpenQA.Selenium;
using TheInternetApp.PageObjects.Pages.SortableDataTables.DataTable;

namespace TheInternetApp.PageObjects.Pages.SortableDataTables.Interfaces.InterfaceSegregationPrinciple;

public interface IDataTable
{
    public IWebElement GetColumnCellValue(string columnName, int rowIndex);
    public IWebElement GetColumnCellValue(int columnIndex, int rowIndex);
    public IEnumerable<IWebElement> GetColumnValues(int columnIndex);
    public IEnumerable<IWebElement> GetColumnValues(string columnName);
    public DataTableRow GetRow(int rowIndex);
}
