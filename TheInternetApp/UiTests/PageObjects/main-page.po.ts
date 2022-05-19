import { Selector } from 'testcafe';

class MainPageObject {
    public mainHeader = Selector('.heading');
    public subheader = Selector('h2');
}

export const mainPageObject = new MainPageObject();
