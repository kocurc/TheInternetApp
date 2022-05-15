import { Selector } from 'testcafe';

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

test('Main header value', async testController => {
    await testController.expect(Selector('.heading').innerText).eql('Welcome to the-internet');
})