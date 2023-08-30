import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http:HttpClient) { }

  GetLatestVideos(){
   return this.http.get("http://localhost:7707/api/Data/GetLastVideos")
  }
  GetAllChannles(){
   return this.http.get("http://localhost:7707/api/Data/GetAllChannles")

  }
  getChannels(): Observable<any[]> {
    return this.http.get<any[]>('assets/channels.json');
  }
  getspeakers(): Observable<any[]> {
    return this.http.get<any[]>('assets/speakers.json');
  }
}
