import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SgMedsComponent } from './sg-meds.component';

describe('SgMedsComponent', () => {
  let component: SgMedsComponent;
  let fixture: ComponentFixture<SgMedsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SgMedsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SgMedsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
