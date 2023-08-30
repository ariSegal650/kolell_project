import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './components/main/main.component';
import { SearchComponent } from './components/search/search.component';
import { CardLatestComponent } from './components/card-latest/card-latest.component';
import { SpeakersCardComponent } from './components/speakers-card/speakers-card.component';

const routes: Routes = [
  {path:"",component:MainComponent},
  {path: "search",component:SearchComponent},
  {path:"card",component:SpeakersCardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
