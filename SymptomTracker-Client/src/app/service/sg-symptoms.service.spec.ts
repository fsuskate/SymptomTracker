import { TestBed, inject } from '@angular/core/testing';

import { SgSymptomsService } from './sg-symptoms.service';

describe('SgSymptomsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SgSymptomsService]
    });
  });

  it('should ...', inject([SgSymptomsService], (service: SgSymptomsService) => {
    expect(service).toBeTruthy();
  }));
});
