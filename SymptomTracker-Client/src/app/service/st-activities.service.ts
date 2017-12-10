import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Activity } from '../model/activity';

@Injectable()
export class StActivitiesService {
  baseUrl: string;

  constructor(private httpClient:HttpClient) { 
    this.baseUrl = "http://localhost:9488/api/activities";
  }

  getActivities() {
    return this
      .httpClient
      .get<Activity[]>(this.baseUrl)
  }
}
