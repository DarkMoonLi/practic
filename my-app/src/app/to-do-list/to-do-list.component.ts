import { Component, OnInit } from '@angular/core';

class ToDoItem{
  name: string;
  done: boolean;
  constructor(name: string) {
    this.name = name;
    this.done = false;
  }
}

@Component({
  selector: 'app-to-do-list',
  templateUrl: './to-do-list.component.html',
  styleUrls: ['./to-do-list.component.css']
})
export class ToDoListComponent implements OnInit {

  newToDo = '';
  todos: ToDoItem[] = [];

  constructor() { }

  ngOnInit(): void {
  }

  addTodoHanler(){
    this.todos.push(
      new ToDoItem(this.newToDo)
    );
    this.newToDo = '';
  }

}
