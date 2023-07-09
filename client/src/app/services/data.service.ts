import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

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
}
