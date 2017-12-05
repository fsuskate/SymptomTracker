import { Component, OnInit } from '@angular/core';
import { SgMedsService } from '../service/sg-meds.service';
import { Med } from '../model/med';

@Component({
  selector: 'sg-meds',
  templateUrl: './sg-meds.component.html',
  styleUrls: ['./sg-meds.component.css'],
  providers: [ SgMedsService ],
})
export class SgMedsComponent implements OnInit {

  meds: Med[];
  
  constructor(private medsService: SgMedsService) { }

  ngOnInit() {
    this.medsService
      .getMeds()
      .subscribe(data => {
        this.meds = data;
      });
  }
}
