import { Http, Response } from "@angular/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Book } from "../book";
import 'rxjs/add/operator/map';

@Injectable()
export class DataService {

    private url: string = 'api/dataservice/';

    constructor(private http: Http) {

    }

    public books: Book[] = [];

    public loadBooks(): Observable<Book[]> {
        return this.http.get(this.url + 'books')
            .map((resp: Response) => resp.json())
    }
}