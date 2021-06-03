import { Component, Input, OnInit } from '@angular/core';
import * as moment from 'moment';

@Component({
  selector: 'app-calendarioheader',
  templateUrl: './calendarioheader.component.html',
  styleUrls: ['./calendarioheader.component.css']
})
export class CalendarioheaderComponent implements OnInit {

  @Input() fecha: moment.Moment = moment();

  constructor() { }

  ngOnInit(): void {
  }

  currMonthName() {
    return this.fecha.format("MMMM");
  }

  currYear() {
    return this.fecha.format("YYYY");
  }

  prevMonth() {
    return this.fecha.clone().subtract(1, "month");
  }

  nextMonth() {
    return this.fecha.clone().add(1, "month");
  }

  thisMonth() {
    return this.fecha.isSame(new Date(), "month");
  }

}
