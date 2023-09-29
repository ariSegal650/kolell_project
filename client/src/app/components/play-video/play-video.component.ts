import { Component, OnInit } from '@angular/core';
import { channel } from 'src/app/models/channel';
import { video_parameters } from 'src/app/models/video_parameters';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-play-video',
  templateUrl: './play-video.component.html',
  styleUrls: ['./play-video.component.css']
})
export class PlayVideoComponent implements OnInit {
  item: video_parameters;
  listSuggestions:video_parameters[];
  constructor(private _dataService: DataService) {

  } 
  ngOnInit(): void {
    this._dataService.currentItem.subscribe(v => this.item = v);
    console.log(this.item);  
    this._dataService.GetVideosByChannel(new channel(this.item.channel_id)).subscribe(_list=>this.listSuggestions=_list);
    console.log(this.listSuggestions);
    
  }

}
