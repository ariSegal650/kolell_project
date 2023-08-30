import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit{

  channels:any[]=[];
  speakers:any[]=[];
  constructor(private data:DataService) {
  
  }
  ngOnInit(): void {
    this.data.getChannels().subscribe(Data => {
      this.channels = Data;
    });
    this.data.getspeakers().subscribe(Data => {
      this.speakers = Data;
    });
   
  }
}
