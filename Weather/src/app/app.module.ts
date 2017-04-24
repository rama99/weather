import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MdButtonModule, MdCheckboxModule, MdSelectModule } from '@angular/material';

import 'hammerjs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { SearchComponent } from './search-component';

import { AppService } from './app.service';

@NgModule({
    imports: [ BrowserModule,
        BrowserAnimationsModule,
        FormsModule,
        ReactiveFormsModule,
        HttpModule,
        MdButtonModule,
        MdCheckboxModule,
        MdSelectModule
        ],
    declarations: [AppComponent, SearchComponent],
    exports: [],
    providers: [AppService],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
