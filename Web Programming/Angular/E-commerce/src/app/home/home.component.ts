import { Component, OnInit } from '@angular/core';
import { trigger, state, animate, transition, style } from '@angular/animations';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  animations: [
    trigger('showFace', [
      state('true', style({ opacity: 1 })),
      state('false', style({ opacity: 0 })),
      transition('true => false', [
        animate('200ms ease-out')
      ]),
      transition('false => true', [
        animate('600ms ease-in')
      ])
    ]),
    trigger('showGram', [
      state('true', style({ opacity: 1 })),
      state('false', style({ opacity: 0 })),
      transition('true => false', [
        animate('300ms ease-out')
      ]),
      transition('false => true', [
        animate('400ms ease-in')
      ])
    ]),
    trigger('showTwit', [
      state('true', style({ opacity: 1 })),
      state('false', style({ opacity: 0 })),
      transition('true => false', [
        animate('500ms ease-out')
      ]),
      transition('false => true', [
        animate('200ms ease-in')
      ])
    ]),
  ]
})

export class HomeComponent implements OnInit {

  public flyIn;
  
  constructor() {
    this.flyIn = false;
  }
  
  ngOnInit() {
  }

  toggleFlyIn() {
    this.flyIn = !this.flyIn;
  }

  
}
