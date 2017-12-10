import { TestBed, inject } from '@angular/core/testing';

import { StUsersService } from './st-users.service';

describe('StUsersService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StUsersService]
    });
  });

  it('should ...', inject([StUsersService], (service: StUsersService) => {
    expect(service).toBeTruthy();
  }));
});
