import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { speakers } from 'src/app/models/speakers';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-speakers-card',
  templateUrl: './speakers-card.component.html',
  styleUrls: ['./speakers-card.component.css']
})
export class SpeakersCardComponent implements OnInit {
  listSpekers: speakers[][] = [];

  constructor(private dataService: DataService) {
    
  }
  responsiveOptions: any[] | undefined;
  lastpage: number = 0;

  ngOnInit(): void {
    this.dataService.GetSpeakersComponenet().subscribe((items) => {
      this.listSpekers = items;
      this.lastpage = this.listSpekers?.length / 2
    });

    this.responsiveOptions = [
      {
        breakpoint: '1350px',
        numVisible: 3,
        numScroll: 3
      },
      {
        breakpoint: '1020px',
        numVisible: 2,
        numScroll: 2
      },
      {
        breakpoint: '750px',
        numVisible: 2,
        numScroll: 2
      },
      {
        breakpoint: '620px',
        numVisible: 1,
        numScroll: 1
      }
    ];
  }

 
}
