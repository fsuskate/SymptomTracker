import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SgSymptomsComponent } from './sg-symptoms.component';

describe('SgSymptomsComponent', () => {
  let component: SgSymptomsComponent;
  let fixture: ComponentFixture<SgSymptomsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SgSymptomsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SgSymptomsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
