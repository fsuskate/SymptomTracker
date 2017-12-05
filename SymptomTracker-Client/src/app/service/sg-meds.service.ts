import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Med } from '../model/med';

@Injectable()
export class SgMedsService {
  baseUrl: string;
  
    constructor(private httpClient:HttpClient) { 
      this.baseUrl = 'http://localhost:9488/api/meds';
    }
  
    getMeds() {
      return this
        .httpClient
        .get<Med[]>(this.baseUrl);
    }
}
