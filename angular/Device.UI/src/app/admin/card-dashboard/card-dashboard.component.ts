import { Component, Input, OnInit } from '@angular/core';
import { CardDashboard } from '../interfaces/card-dashboard';

@Component({
  selector: 'app-card-dashboard',
  templateUrl: './card-dashboard.component.html'
})
export class CardDashboardComponent {

  @Input() 
  cardDashboard: CardDashboard;
  
}
