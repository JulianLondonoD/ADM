import { Component, OnInit, Input, SimpleChange } from '@angular/core';
import * as moment from 'moment';
import * as business from '../../business/calendarioBusiness';

@Component({
  selector: 'app-calendario',
  templateUrl: './calendario.component.html',
  styleUrls: ['./calendario.component.css']
})
export class CalendarioComponent implements OnInit {

  @Input() fecha: moment.Moment = moment();

  calendario : moment.Moment[][] = [];

  dias : string[] = ['do', 'lu', 'ma', 'mi', 'ju', 'vi', 'sa'];

  constructor() { }

  ngOnInit(): void {
    
  }

  ngDoCheck() {
    this.calendario = business.buildCalendar(this.fecha);
  }



}
