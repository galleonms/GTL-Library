import { Component, OnInit } from '@angular/core';
import { DataService } from "../shared/services/data.service";
import { Book } from "../shared/book";

@Component({
  selector: 'app-book-list',
  templateUrl: "book-list.component.html",
  styles: []
})

export class BookListComponent implements OnInit {
    
    constructor(private data: DataService) {
        this.books = data.books;
    }

    public books: Book[];

    ngOnInit(): void {
        this.data.loadBooks()
            .subscribe(() => this.books = this.data.books);
    }
}
