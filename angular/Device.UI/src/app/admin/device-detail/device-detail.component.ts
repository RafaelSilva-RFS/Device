import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-device-detail',
  templateUrl: './device-detail.component.html'
})
export class DeviceDetailComponent implements OnInit {

  constructor(private route: ActivatedRoute) { }

  teste: any;

  ngOnInit(): void {
    this.route.params
      .subscribe(params => {
        this.teste = params['id'];
      });
  }

}
