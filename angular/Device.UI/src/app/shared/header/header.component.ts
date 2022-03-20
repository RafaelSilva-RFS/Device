import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent {

  nav: Nav[] = [
    {
      link: '/',
      name: 'HOME',
      exact: true
    },
    {
      link: '/devices',
      name: 'MY DEVICES',
      exact: false
    }
  ];

}

interface Nav {
  link: string,
  name: string,
  exact: boolean
}
