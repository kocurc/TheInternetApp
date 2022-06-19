import { Selector } from 'testcafe';
import ForkMeOnGithubImageComponent from '../Components/fork-me-on-github-image.component';
import BasePageObject from './base-page.po';

class MainPageObject extends BasePageObject {
    public mainHeader: Selector = Selector('.heading');
    public subheader: Selector = Selector('h2');
    public abTestingLink: Selector = Selector('#content > ul > li:nth-child(1) > a');
    public forkMeOnGithubImageComponent: ForkMeOnGithubImageComponent = new ForkMeOnGithubImageComponent();
}

export const mainPageObject = new MainPageObject();
