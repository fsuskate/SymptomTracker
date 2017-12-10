import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../model/user'

@Injectable()
export class StUsersService {
  baseUrl: string;
  
  constructor(private httpClient:HttpClient) { 
    this.baseUrl = 'http://localhost:9488/api/users';
  }

  getUsers() {
    return this
      .httpClient
      .get<User[]>(this.baseUrl);
  }
}
