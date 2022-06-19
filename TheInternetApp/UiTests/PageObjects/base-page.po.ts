import { ClientFunction, t } from 'testcafe';


class BasePageObject {
    async assertUrlContains(url: string): Promise<void> {
        const getUrl = ClientFunction(() => document.location.href);

        await t.expect(getUrl()).contains(url);
    }
}

export default BasePageObject;
