import { Component, OnInit } from '@angular/core';
import { SgSymptomsService } from '../service/sg-symptoms.service';
import { Symptom } from '../model/symptom';

@Component({
  selector: 'sg-symptoms',
  templateUrl: './sg-symptoms.component.html',
  styleUrls: ['./sg-symptoms.component.css']
})
export class SgSymptomsComponent implements OnInit {
  symptoms: Symptom[];

  constructor(private symptomService: SgSymptomsService) { }

  ngOnInit() {
    this
      .symptomService
      .getSymptoms()
      .subscribe(data => {
        this.symptoms = data;
      })
  }
}
