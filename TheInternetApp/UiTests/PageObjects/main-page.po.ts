import { Selector } from 'testcafe';

class MainPageObject {
    public mainHeader = Selector('.heading');
    public subheader = Selector('h2');
    public abTestingLink = Selector('#content > ul > li:nth-child(1) > a');
}

export const mainPageObject = new MainPageObject();
