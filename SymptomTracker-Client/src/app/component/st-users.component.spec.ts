import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StUsersComponent } from './st-users.component';

describe('StUsersComponent', () => {
  let component: StUsersComponent;
  let fixture: ComponentFixture<StUsersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StUsersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StUsersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
