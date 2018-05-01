import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { DataService } from './shared/services/data.service';
import { BookComponent } from './book/book.component';
import { BookListComponent } from './book-list/book-list.component';


@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    BookListComponent
  ],
  imports: [
      BrowserModule,
      HttpClientModule
  ],
  providers: [
      DataService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
