import { Component, OnInit } from '@angular/core';
import { Recommended } from 'src/app/models/recommended';
import { speakers } from 'src/app/models/speakers';
import { video_parameters } from 'src/app/models/video_parameters';
import { DataService } from 'src/app/services/data.service';
import { trigger, style, animate, transition } from '@angular/animations';


@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  //hidden right button in latestvideosection
  left_button = false
  right_button =true;
  scrollPosition = 0;

  left_button_sp=false;
  scrollPosition_speakers = 0;

  list_LatestVideos: video_parameters[] = [];
  listSpekers: speakers[][] = [];
  listRecommended: Recommended[] = [];
  constructor(private _DataService: DataService) {

  }
  ngOnInit(): void {
    this.initializeRecommended();
    
  }

  scrollLeft() {
    this.scrollPosition += 440; // Adjust the scroll amount based on your card width
    const scrollContainer = document.querySelector('.latest .scroll') as HTMLElement;
    const maxScrollPosition = scrollContainer.scrollWidth - this.scrollPosition;
console.log(maxScrollPosition,this.scrollPosition,scrollContainer.scrollWidth);

    if (maxScrollPosition <= scrollContainer.scrollWidth / 2) {
      //this.scrollPosition = Math.max(this.scrollPosition, 0);
      this.right_button=false;
    }
    this.animateScroll("latest");
  }
  scrollRight() {
    this.scrollPosition -= 420;
    this.scrollPosition = Math.max(this.scrollPosition, 0);
    this.right_button=true;
    
    this.animateScroll("latest"); // Call the animation method after updating the scroll position
  }
  animateScroll(section:string) {

    if(section=="latest"){
      this.scrollPosition > 0 ? this.left_button = true : this.left_button = false
  
      const scrollElement = document.querySelector('.latest .scroll') as HTMLElement;
      scrollElement.style.transform = `translateX(${this.scrollPosition}px)`;
    }
    else if(section=="speakers"){
      this.scrollPosition_speakers > 0 ? this.left_button_sp = true : this.left_button_sp = false
  
      const scrollElement = document.querySelector('.speakers .scroll') as HTMLElement;
      scrollElement.style.transform = `translateX(${this.scrollPosition_speakers}px)`;
    }
  }

  scrollLeft_speakers(){
    this.scrollPosition_speakers += 220; // Adjust the scroll amount based on your card width
    const scrollContainer = document.querySelector('.speakers .scroll') as HTMLElement;
    const maxScrollPosition = scrollContainer.scrollWidth - this.scrollPosition_speakers;

    if (maxScrollPosition <= scrollContainer.scrollWidth / 2) {
      this.scrollPosition_speakers = 0;
    }
    this.animateScroll("speakers");
  }
  scrollRight_speakers() {
    this.scrollPosition_speakers -= 420;
    this.scrollPosition_speakers = Math.max(this.scrollPosition_speakers, 0);
    this.animateScroll("speakers"); // Call the animation method after updating the scroll position
  }

  initializeRecommended() {
    this.listRecommended =
      [
        {
          img: "../../../assets/shutterstock.jpg",
          name: "תניא",
          id: 3,
        },
        {
          img: "../../../assets/shutterstock.jpg",
          name: "תניא",
          id: 3,
        },
        {
          img: "../../../assets/shutterstock.jpg",
          name: "תניא",
          id: 3,
        },
        {
          img: "../../../assets/shutterstock.jpg",
          name: "תניא",
          id: 3,
        },


      ]
  }
  
}
