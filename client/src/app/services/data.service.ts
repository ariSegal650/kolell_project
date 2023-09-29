import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, map, of, scheduled, tap } from 'rxjs';
import { video_parameters } from '../models/video_parameters';
import { speakers } from '../models/speakers';
import { channel } from '../models/channel';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private listItems: speakers[][] | null = null;
  private list_LatestVideos: video_parameters[] | null = null;
  private baseUrl: string = "http://localhost:7707/api/";

  constructor(private http: HttpClient) { }

   GetSpeakersComponenet(): Observable<any[]>{

    if (this.listItems) {
      return of(this.listItems);
    } 
    else {
      return this.http.get<speakers[][]>(this.baseUrl + "Data/GetAllSpeakers").pipe(
        tap((items) => {
          this.listItems = items;
        }),
      );
    }
  }

  GetLatestVideos(): Observable<any[]> {

    if (this.list_LatestVideos) {
      return of(this.list_LatestVideos);
    } 
    else {
      return this.http.get<video_parameters[]>(this.baseUrl + "Data/GetLastVideos").pipe(
        tap((items) => {
          this.list_LatestVideos = items;
        }),
      );
    }
  }
  GetAllChannles() {
    return this.http.get(this.baseUrl + "Data/GetAllChannles")

  }
  getChannels(): Observable<any[]> {
    return this.http.get<any[]>('assets/channels.json');
  }
  getspeakers(): Observable<any[]> {
    return this.http.get<any[]>('assets/speakers.json');
  }
  GetVideosByChannel(parameters:channel):Observable<any[]>{
    return this.http.post<video_parameters[]>(this.baseUrl + "Data/GetVideosByChannel",parameters);
  }

  private itemSource = new BehaviorSubject<video_parameters>(new video_parameters());
  currentItem = this.itemSource.asObservable();

  updateCurrentVideo(newItem: video_parameters) {
    this.itemSource.next(newItem);
  }
}
