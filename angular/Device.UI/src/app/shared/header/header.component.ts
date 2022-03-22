import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Router } from '@angular/router';
import { LocalStorageUtils } from 'src/app/utils/localstorage';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  encapsulation: ViewEncapsulation.None
})
export class HeaderComponent {

  localStorageUtils = new LocalStorageUtils();
  isCollapsed = true;

  constructor(private router: Router) {  }

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

  logout() {
    this.localStorageUtils.limparDadosLocaisUsuario();
    this.router.navigate(['/account/login']);
  }
}

interface Nav {
  link: string,
  name: string,
  exact: boolean
}
