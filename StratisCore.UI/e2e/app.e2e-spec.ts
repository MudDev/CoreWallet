import { AngularElectronPage } from './app.po';
import { browser, element, by } from 'protractor';

describe('stratis-core App', () => {
  let page: AngularElectronPage;

  beforeEach(() => {
    page = new AngularElectronPage();
  });

  it('Page title should be City Core', () => {
    page.navigateTo('/');
    expect(page.getTitle()).toEqual('City Core');
  });
});
