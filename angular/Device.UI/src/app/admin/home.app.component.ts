import { Component } from '@angular/core';

@Component({
  selector: 'home-app-root',
  template: `<app-header></app-header>
              <section class="py-4">
                <router-outlet></router-outlet>
              </section>            
            <app-footer></app-footer>`
})
export class HomeAppComponent { }