import { TestBed, inject } from '@angular/core/testing';

import { SgMedsService } from './sg-meds.service';

describe('SgMedsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SgMedsService]
    });
  });

  it('should ...', inject([SgMedsService], (service: SgMedsService) => {
    expect(service).toBeTruthy();
  }));
});
