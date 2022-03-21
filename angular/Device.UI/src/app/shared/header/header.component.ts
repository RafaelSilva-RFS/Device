import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  encapsulation: ViewEncapsulation.None
})
export class HeaderComponent {

  isCollapsed = true;

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
