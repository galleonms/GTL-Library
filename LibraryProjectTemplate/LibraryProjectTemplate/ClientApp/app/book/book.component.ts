import { Component, OnInit } from '@angular/core';
import { DataService } from "../shared/services/data.service";

@Component({
  selector: 'app-book',
  templateUrl: "book.component.html",
  styles: []
})

export class BookComponent {

  constructor(private data: DataService) { }

 

}
