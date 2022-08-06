using OpenQA.Selenium;
using TheInternetApp.PageObjects.Base;

namespace TheInternetApp.PageObjects.Pages.Hovers;

public class HoversPageObject : BasePageObject
{
    #region PageElementsLocators

    private readonly By? _userNameHeadersLocator;
    private readonly By? _userViewLinksLocator;
    private readonly By? _userImagesLocator;
    private readonly By? _mainHeaderLocator;

    #endregion

    #region PageElements

    public IReadOnlyCollection<IWebElement> UserImages => WebDriver?.FindElements(_userImagesLocator) ?? throw new ArgumentNullException(nameof(WebDriver));

    public IReadOnlyCollection<IWebElement> UserViewsLinks => WebDriver?.FindElements(_userViewLinksLocator) ?? throw new ArgumentNullException(nameof(WebDriver));


    public IReadOnlyCollection<IWebElement> UserNameHeaders => WebDriver?.FindElements(_userNameHeadersLocator) ?? throw new ArgumentNullException(nameof(WebDriver));

    public IWebElement MainHeader => WebDriver?.FindElement(_mainHeaderLocator) ?? throw new ArgumentNullException(nameof(WebDriver));

    #endregion

    public HoversPageObject() { }

    public HoversPageObject(IWebDriver webDriver) : base(webDriver)
    {
        _userImagesLocator = By.CssSelector(".example > div > img");
        _userNameHeadersLocator = By.TagName("h5");
        _userViewLinksLocator = By.XPath("//a[contains(., 'View profile')]");
        _mainHeaderLocator = By.TagName("h3");
    }

    public IWebElement this[int index]
    {
        get
        {
            if (index < 0 || index >= UserImages.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return UserImages.ElementAt(index);
        }
    }

    public string GetUserName(int index)
    {
        if (!UserNameHeaders.ElementAt(index).Displayed)
        {
            throw new InvalidElementStateException(
                $"User name header of index: {index} should be visible before attempting to read the name.");
        }

        return UserNameHeaders.ElementAt(index).Text[(UserNameHeaders.ElementAt(index).Text.IndexOf(' ') + 1)..];
    }

    public override string ToString()
    {

        var allPageObjects = $"User image of index 0: {UserImages.ElementAt(0)}.\n" +
                             $"User image of index 1: {UserImages.ElementAt(1)}.\n" +
                             $"User image of index 2: {UserImages.ElementAt(2)}.\n" +
                             $"User view link of index 0: {UserViewsLinks.ElementAt(0)}.\n" +
                             $"User view link of index 1: {UserViewsLinks.ElementAt(1)}.\n" +
                             $"User view link of index 2: {UserViewsLinks.ElementAt(2)}.\n" +
                             $"User name header of index 0: {UserNameHeaders.ElementAt(0)}.\n" +
                             $"User name header of index 1: {UserNameHeaders.ElementAt(1)}.\n" +
                             $"User name header of index 2: {UserNameHeaders.ElementAt(2)}.\n" +
                             $"Main header: {MainHeader}.";


        return allPageObjects;
    }
}