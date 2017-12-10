import { TestBed, inject } from '@angular/core/testing';

import { StActivitiesService } from './st-activities.service';

describe('StActivitiesService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StActivitiesService]
    });
  });

  it('should ...', inject([StActivitiesService], (service: StActivitiesService) => {
    expect(service).toBeTruthy();
  }));
});
