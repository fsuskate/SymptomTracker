import { Component, OnInit } from '@angular/core';
import { User } from 'app/model/user';
import { StUsersService } from '../service/st-users.service';

@Component({
  selector: 'st-users',
  templateUrl: './st-users.component.html',
  styleUrls: ['./st-users.component.css']
})
export class StUsersComponent implements OnInit {
  users: User[];
  
  constructor(private userService: StUsersService) { }

  ngOnInit() {
    this
      .userService
        .getUsers()
        .subscribe(data => {
          this.users = data;
      })
  }
}
