import { Component, OnInit } from '@angular/core';
import { Med } from '../model/med';
import { SgMedsService } from '../service/sg-meds.service';


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
