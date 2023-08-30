import { Component, OnInit } from '@angular/core';
import { speakers } from 'src/app/models/speakers';

@Component({
  selector: 'app-speakers-card',
  templateUrl: './speakers-card.component.html',
  styleUrls: ['./speakers-card.component.css']
})
export class SpeakersCardComponent implements OnInit {
  listSpekers: speakers[][] = [];
  responsiveOptions: any[] | undefined;

  ngOnInit(): void {
   this.initializeSpeakers();
   
   this.responsiveOptions = [
    {
      breakpoint: '10px',
      numVisible: 3,
      numScroll: 3
    },
    {
      breakpoint: '10px',
      numVisible: 2,
      numScroll: 2
    },
    {
      breakpoint: '7px',
      numVisible: 2,
      numScroll: 2
    },
    {
      breakpoint: '5px',
      numVisible: 1,
      numScroll: 1
    }
  ];
  }

  initializeSpeakers() {
    this.listSpekers = [
      [{
        img: "../../../assets/images.png",
        number_views: 55,
        full_name: "r miilec",
        channel_id: 589
      },
      {
        img: "../../../assets/images.png",
        number_views: 556,
        full_name: "r miilec",
        channel_id: 589
      }],
      [{
        img: "../../../assets/images.png",
        number_views: 557,
        full_name: "r miilec",
        channel_id: 589
      },
      {
        img: "../../../assets/images.png",
        number_views: 558,
        full_name: "r miilec",
        channel_id: 589
      }],
      [{
        img: "../../../assets/images.png",
        number_views: 55,
        full_name: "r miilec",
        channel_id: 589
      },
      {
        img: "../../../assets/images.png",
        number_views: 556,
        full_name: "r miilec",
        channel_id: 589
      }],
      [{
        img: "../../../assets/images.png",
        number_views: 557,
        full_name: "r miilec",
        channel_id: 589
      },
      {
        img: "../../../assets/images.png",
        number_views: 558,
        full_name: "r miilec",
        channel_id: 589
      }],
      [{
        img: "../../../assets/images.png",
        number_views: 557,
        full_name: "r miilec",
        channel_id: 589
      },
      {
        img: "../../../assets/images.png",
        number_views: 558,
        full_name: "r miilec",
        channel_id: 589
      }],
      [{
        img: "../../../assets/images.png",
        number_views: 557,
        full_name: "r miilec",
        channel_id: 589
      },
      {
        img: "../../../assets/images.png",
        number_views: 558,
        full_name: "r miilec",
        channel_id: 589
      }]
    ]
  }
}
