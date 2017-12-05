import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Symptom } from '../model/symptom'

@Injectable()
export class SgSymptomsService {
  baseUrl: string;
  
  constructor(private httpClient:HttpClient) { 
    this.baseUrl = 'http://localhost:9488/api/symptoms';
  }

  getSymptoms() {
    return this
      .httpClient
      .get<Symptom[]>(this.baseUrl);
  }
}
