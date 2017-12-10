import { Component, OnInit } from '@angular/core';
import { StActivitiesService } from '../service/st-activities.service';
import { Activity } from '../model/activity';

@Component({
  selector: 'st-activities',
  templateUrl: './st-activities.component.html',
  styleUrls: ['./st-activities.component.css']
})
export class StActivitiesComponent implements OnInit {
  activities: Activity[];

  constructor(private activityService: StActivitiesService) { }

  ngOnInit() {
    this
      .activityService
      .getActivities()
      .subscribe(data => this.activities = data);
  }

}
