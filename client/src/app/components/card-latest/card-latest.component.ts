import { Component, Input, OnInit } from '@angular/core';
import { video_parameters } from 'src/app/models/video_parameters';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-card-latest',
  templateUrl: './card-latest.component.html',
  styleUrls: ['./card-latest.component.css']
})
export class CardLatestComponent implements OnInit {
  
  list_LatestVideos: video_parameters[] = [];
  responsiveOptions: any[] | undefined;
  constructor(private _DataService: DataService) { }
  ngOnInit(): void {
    // this._DataService.GetLatestVideos().subscribe({
    //   next: (value) => {

    //     console.log(this.list_LatestVideos);
    //     this.list_LatestVideos = value as video_parameters[]
    //   },
    // })

    this.responsiveOptions = [
      {
        breakpoint: '1199px',
        numVisible: 4,
        numScroll: 4
      },
      {
        breakpoint: '991px',
        numVisible: 3,
        numScroll: 3
      },
      {
        breakpoint: '767px',
        numVisible: 2,
        numScroll: 2
      },
      {
        breakpoint: '570px',
        numVisible: 1,
        numScroll: 1
      }
    ];
  }




}

