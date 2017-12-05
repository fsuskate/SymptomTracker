import { SymptomTrackerClientPage } from './app.po';

describe('symptom-tracker-client App', () => {
  let page: SymptomTrackerClientPage;

  beforeEach(() => {
    page = new SymptomTrackerClientPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
