using OpenQA.Selenium;

namespace TheInternetApp.PageObjects.Pages.SortableDataTables.Interfaces.InterfaceSegregationPrinciple
{
    public interface IHeader
    {
        public IWebElement? GetColumnHeaderCell(int columnIndex);
        public IEnumerable<IWebElement> GetHeaders();
    }
}
