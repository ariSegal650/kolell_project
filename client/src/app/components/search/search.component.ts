import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { video_parameters } from 'src/app/models/video_parameters';
import { DataService } from 'src/app/services/data.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  first: number = 0
  items: MenuItem[] | undefined;
  SerchBy: string = "הכי חדש"
  ListVideo: video_parameters[] = [];

  constructor(private route: ActivatedRoute, private dataService: DataService) {

  }
  ngOnInit(): void {
    const type = this.route.snapshot.paramMap.get('type') as string
    console.log(type);
    this.LoadVideos(type);

    this.InitializeItems();
  }
  onPageChange(event: any) {

    console.log(event);

  }
  InitializeItems() {
    this.items = [
      {
        label: "שם הרב(א-ת)",
        command: () => {
          this.SerchBy = "שם הרב(א-ת)"
        }
      },
      {
        label: "כותרת השיעור (א-ת) ",
        command: () => {
          this.SerchBy = "כותרת השיעור (א-ת) "
        }
      },
      {
        label: "אורך השיעור",
        command: () => {
          this.SerchBy = "אורך השיעור"
        }
      },
      {
        label: "מהישן לחדש",
        command: () => {
          this.SerchBy = "מהישן לחדש"
        }
      }];
  }

  LoadVideos(type:string) {
    if(type=="new"){
     this.dataService.GetLatestVideos().subscribe(v=>
      this.ListVideo=v as video_parameters[]
      );
    }
  }
}



