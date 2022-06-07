import  mainPageDictionary from '../Dictionaries/main-page-dictionary'
import { mainPageObject } from '../PageObjects/main-page.po';
import { ClientFunction } from 'testcafe';

fixture('Tests related to main page').page('http://127.0.0.1:7080/')
    .before(async testController => {
        // runs code before fixture - setup
    })
    .beforeEach(async testController => {
        await testController.setTestSpeed(1);
    })
    .after(async testController => {
        // runs code after fixture is finished - cleaning
    })
    .afterEach(async testController => {
        // runs code afer each test
    });

test('Fork me on Github image when clicked directs me to the Github source repository', async testController => {

});

test('Main header value', async testController => {
    await testController.expect(mainPageObject.mainHeader.innerText).eql(mainPageDictionary.headers.mainHeader);
});

test('Subheader value', async testController => {
    await testController.wait(1000);
    await testController.expect(mainPageObject.subheader.innerText).eql(mainPageDictionary.headers.subheader);
});

test('A/B Testing link points to abtest page', async testController => {
    await testController.click(mainPageObject.abTestingLink);
    await mainPageObject.assertUrlContains('abtest');
});
