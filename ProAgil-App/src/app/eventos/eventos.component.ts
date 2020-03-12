import { Component, OnInit } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { error } from '@angular/compiler/src/util';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  events: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEvents();
  }

  getEvents(){
    this.http.get('http://localhost:5000/WeatherForecast').subscribe(response => { 
      this.events = response 
    }, error => {
      console.log(error);
    }

    );
  }

}
