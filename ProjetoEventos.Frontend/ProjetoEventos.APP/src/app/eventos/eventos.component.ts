import { HttpClient } from '@angular/common/http';
import { Component, NO_ERRORS_SCHEMA, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private htttp: HttpClient) { }

  public eventos: any;

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.htttp.get("https://localhost:7201/api/Eventos").subscribe(
      response => this.eventos = response,
      error => console.log(error)
    )
  }
}
