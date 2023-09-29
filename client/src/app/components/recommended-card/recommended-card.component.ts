import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-recommended-card',
  templateUrl: './recommended-card.component.html',
  styleUrls: ['./recommended-card.component.css']
})
export class RecommendedCardComponent implements OnInit{
  list_recommended:any[]=[];
  responsiveOptions: any[] | undefined;

  ngOnInit(): void {
    this.list_recommended=[
      {
        name:"תניא ",
        img:""
      },
      {
        name:"תניא ",
        img:""
      },
      {
        name:"תניא ",
        img:""
      },
      {
        name:"תניא ",
        img:""
      },
      {
        name:"תניא ",
        img:""
      }
    ];
    // this.responsiveOptions = [
    //   {
    //     breakpoint: '1199px',
    //     numVisible: 4,
    //     numScroll: 4
    //   },
    //   {
    //     breakpoint: '760px',
    //     numVisible: 0,
    //     numScroll: 0
    //   },
    //   {
    //     breakpoint: '767px',
    //     numVisible: 2,
    //     numScroll: 2
    //   },
    //   {
    //     breakpoint: '570px',
    //     numVisible: 1,
    //     numScroll: 1
    //   }
    // ];
    
  }
}
