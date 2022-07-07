using OpenQA.Selenium;
using TheInternetApp.PageObjects.SortableDataTables.DataTable;

namespace TheInternetApp.PageObjects.SortableDataTables.Interfaces;

public interface IDataTable
{
    public IWebElement GetColumnHeaderCell(int columnIndex);
    public IWebElement GetColumnCellValue(string columnName, int rowIndex);
    public IWebElement GetColumnCellValue(int columnIndex, int rowIndex);
    public IEnumerable<IWebElement> GetColumnValues(int columnIndex);
    public IEnumerable<IWebElement> GetColumnValues(string columnName);
    public DataTableRow GetRow(int rowIndex);
    public IEnumerable<IWebElement> GetHeaders();
}
