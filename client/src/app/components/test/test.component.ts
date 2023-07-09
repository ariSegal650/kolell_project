import { Component } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent {

  showSubtitles: boolean = false;

  openSubtitles() {
    this.showSubtitles = true;
  }

  closeSubtitles() {
    this.showSubtitles = false;
  }
}
