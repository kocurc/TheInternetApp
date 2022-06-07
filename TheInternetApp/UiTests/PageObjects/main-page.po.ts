import { ClientFunction, Selector, t } from 'testcafe';
import ForkMeOnGithubImageComponent from '../Components/fork-me-on-github-image.component';

class MainPageObject {
    public mainHeader = Selector('.heading');
    public subheader = Selector('h2');
    public abTestingLink = Selector('#content > ul > li:nth-child(1) > a');
    public forkMeOnGithubImageComponent = new ForkMeOnGithubImageComponent();

    async assertUrlContains(url: string) {
        const getUrl = ClientFunction(() => document.location.href);

        await t.expect(getUrl()).contains(url);
    }
}

export const mainPageObject = new MainPageObject();
