import { Selector, t } from 'testcafe';
import  mainPageDictionary from '../Dictionaries/main-page-dictionary'
import { mainPageObject } from '../PageObjects/main-page.po';

fixture('Tests related to main page').page('http://127.0.0.1:7080/')
    .before(async testController => {
        // runs code before fixture - setup
    })
    .beforeEach(async testController => {
        await testController.setTestSpeed(1);
        await testController.setPageLoadTimeout(10000);
    })
    .after(async testController => {
        // runs code after fixture is finished - cleaning
    })
    .afterEach(async testController => {
        // runs code afer each test
    });

test('Main header value', async testController => {
    await testController.expect(mainPageObject.mainHeader.innerText).eql(mainPageDictionary.headers.mainHeader);
});

test('Subheader value', async testController => {
    await testController.wait(1000);
    await testController.expect(Selector('h2').innerText).eql(mainPageDictionary.headers.subheader);
});

test.skip('Skip test', async testController => {
    await testController.wait(1000);
});

test.skip('Take screenshot', async testController => {
    await testController.takeScreenshot({ path: "../Screenshots/", fullPage: true});
    await t.takeElementScreenshot(mainPageObject.mainHeader);
    await testController.wait(1000);
});
