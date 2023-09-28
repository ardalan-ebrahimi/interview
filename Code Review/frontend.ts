import { Component, OnInit } from '@angular/core';
import { UserService } from './user.service';
import { User } from './User';

@Component({
  selector: 'app-user',
  template: `
    <div *ngIf="{
      users: users,
      Roles: userService.Roles$ |async
    } data">
      <h2>User List</h2>
      <ul>
        <li *ngFor="let user of data.users">{{ user.name }}</li>
      </ul>
    </div>
    <div>
      <h2>Add User</h2>
      <input [(ngModel)]="newUserName" placeholder="New User Name" />
      <button (click)="addUser()">Add</button>
    </div>
  `,
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  users: User[];
  newUserName: string = ''; // New user name input

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    // Fetch users on component initialization
    this.userService.getUsers().subscribe(users => {
      this.users = users;
    });
  }

  addUser(): void {
    // Add a new user
    if (this.newUserName.trim() !== '') {
      const newUser: User = { name: this.newUserName };
      this.userService.addUser(newUser).subscribe(user => {
        this.users.push(user);
        this.newUserName = ''; // Clear the input field after adding
      });
    }
  }
}
