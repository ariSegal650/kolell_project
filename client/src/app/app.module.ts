import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainComponent } from './components/main/main.component';
import { TestComponent } from './components/test/test.component';
import { HeaderComponent } from './components/header/header.component';
import {MatIconModule} from '@angular/material/icon';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';
import { SearchComponent } from './components/search/search.component';
import { PaginatorModule } from 'primeng/paginator';
import { SplitButtonModule } from 'primeng/splitbutton';
import { CardLatestComponent } from './components/card-latest/card-latest.component';
import { CardModule } from 'primeng/card';
import { CarouselModule } from 'primeng/carousel';
import { SpeakersCardComponent } from './components/speakers-card/speakers-card.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    TestComponent,
    HeaderComponent,
    SearchComponent,
    CardLatestComponent,
    SpeakersCardComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ButtonModule,
    MatIconModule,
    PaginatorModule,
     BrowserAnimationsModule,
     SplitButtonModule,
     CardModule,
     CarouselModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
