import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StActivitiesComponent } from './st-activities.component';

describe('StActivitiesComponent', () => {
  let component: StActivitiesComponent;
  let fixture: ComponentFixture<StActivitiesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StActivitiesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StActivitiesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
