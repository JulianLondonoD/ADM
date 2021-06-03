import { Component } from '@angular/core';
import * as moment from 'moment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  fechaCurrent : moment.Moment = moment();
  fechaBack : moment.Moment = moment().add(-1,"month");
  fechaNext : moment.Moment = moment().add(1,"month");

  title = 'AMDAngular';

  prevMonth() {
    this.fechaCurrent = this.fechaCurrent.add(-1,"month");
    this.fechaBack = this.fechaBack.add(-1,"month");
    this.fechaNext = this.fechaNext.add(-1,"month");
  }

  nextMonth() {
    this.fechaCurrent = this.fechaCurrent.add(1,"month");
    this.fechaBack = this.fechaBack.add(1,"month");
    this.fechaNext = this.fechaNext.add(1,"month");
  }
  
}
