webpackJsonp(["main"],{

/***/ "./ClientApp/$$_lazy_route_resource lazy recursive":
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncatched exception popping up in devtools
	return Promise.resolve().then(function() {
		throw new Error("Cannot find module '" + req + "'.");
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./ClientApp/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./ClientApp/app/app.component.html":
/***/ (function(module, exports) {

module.exports = "<h1>Hello from Mod {{title}}</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\">\r\n        <app-book-list> </app-book-list>\r\n    </div>\r\n</div>\r\n"

/***/ }),

/***/ "./ClientApp/app/app.component.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'Online Library';
    }
    AppComponent = __decorate([
        core_1.Component({
            selector: 'app-library',
            template: __webpack_require__("./ClientApp/app/app.component.html"),
            styles: []
        })
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;


/***/ }),

/***/ "./ClientApp/app/app.module.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var platform_browser_1 = __webpack_require__("./node_modules/@angular/platform-browser/esm5/platform-browser.js");
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var http_1 = __webpack_require__("./node_modules/@angular/common/esm5/http.js");
var app_component_1 = __webpack_require__("./ClientApp/app/app.component.ts");
var data_service_1 = __webpack_require__("./ClientApp/app/services/data.service.ts");
var book_component_1 = __webpack_require__("./ClientApp/app/book/book.component.ts");
var book_list_component_1 = __webpack_require__("./ClientApp/app/book-list/book-list.component.ts");
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            declarations: [
                app_component_1.AppComponent,
                book_component_1.BookComponent,
                book_list_component_1.BookListComponent
            ],
            imports: [
                platform_browser_1.BrowserModule,
                http_1.HttpClientModule
            ],
            providers: [
                data_service_1.DataService
            ],
            bootstrap: [app_component_1.AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;


/***/ }),

/***/ "./ClientApp/app/book-list/book-list.component.html":
/***/ (function(module, exports) {

module.exports = "<h1> Hello from the book list! </h1>\r\n<div class=\"row\">\r\n    <ul>\r\n        <li *ngFor = \"let b of books\">{{b.title}}, {{b.description}}</li>\r\n    </ul>\r\n</div>"

/***/ }),

/***/ "./ClientApp/app/book-list/book-list.component.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var data_service_1 = __webpack_require__("./ClientApp/app/services/data.service.ts");
var BookListComponent = /** @class */ (function () {
    function BookListComponent(data) {
        this.data = data;
        this.books = [];
        this.books = data.books;
    }
    BookListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.data.loadBooks()
            .subscribe(function (success) {
            if (success) {
                _this.books = _this.data.books;
            }
        });
    };
    BookListComponent = __decorate([
        core_1.Component({
            selector: 'app-book-list',
            template: __webpack_require__("./ClientApp/app/book-list/book-list.component.html"),
            styles: []
        }),
        __metadata("design:paramtypes", [data_service_1.DataService])
    ], BookListComponent);
    return BookListComponent;
}());
exports.BookListComponent = BookListComponent;


/***/ }),

/***/ "./ClientApp/app/book/book.component.html":
/***/ (function(module, exports) {

module.exports = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n</head>\r\n<body>\r\n    <h1> book works!</h1>\r\n</body>\r\n</html>"

/***/ }),

/***/ "./ClientApp/app/book/book.component.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var data_service_1 = __webpack_require__("./ClientApp/app/services/data.service.ts");
var BookComponent = /** @class */ (function () {
    function BookComponent(data) {
        this.data = data;
    }
    BookComponent = __decorate([
        core_1.Component({
            selector: 'app-book',
            template: __webpack_require__("./ClientApp/app/book/book.component.html"),
            styles: []
        }),
        __metadata("design:paramtypes", [data_service_1.DataService])
    ], BookComponent);
    return BookComponent;
}());
exports.BookComponent = BookComponent;


/***/ }),

/***/ "./ClientApp/app/services/data.service.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var http_1 = __webpack_require__("./node_modules/@angular/common/esm5/http.js");
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
__webpack_require__("./node_modules/rxjs/_esm5/add/operator/map.js");
var DataService = /** @class */ (function () {
    function DataService(http) {
        this.http = http;
        this.books = [];
    }
    DataService.prototype.loadBooks = function () {
        var _this = this;
        return this.http.get("api/books")
            .map(function (data) {
            _this.books = data;
            return true;
        });
    };
    DataService = __decorate([
        core_1.Injectable(),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], DataService);
    return DataService;
}());
exports.DataService = DataService;


/***/ }),

/***/ "./ClientApp/environments/environment.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
Object.defineProperty(exports, "__esModule", { value: true });
exports.environment = {
    production: false
};


/***/ }),

/***/ "./ClientApp/main.ts":
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = __webpack_require__("./node_modules/@angular/core/esm5/core.js");
var platform_browser_dynamic_1 = __webpack_require__("./node_modules/@angular/platform-browser-dynamic/esm5/platform-browser-dynamic.js");
var app_module_1 = __webpack_require__("./ClientApp/app/app.module.ts");
var environment_1 = __webpack_require__("./ClientApp/environments/environment.ts");
if (environment_1.environment.production) {
    core_1.enableProdMode();
}
platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_module_1.AppModule)
    .catch(function (err) { return console.log(err); });


/***/ }),

/***/ 0:
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__("./ClientApp/main.ts");


/***/ })

},[0]);
//# sourceMappingURL=main.bundle.js.map