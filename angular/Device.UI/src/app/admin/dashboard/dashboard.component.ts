import { Component, OnInit } from '@angular/core';
import { CardDashboard } from '../interfaces/card-dashboard';
import { DeviceService } from '../services/devices.service';
import { Observable } from 'rxjs';
import { FileSizePipe } from '../pipes/filesize.pipe';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  providers: [
    FileSizePipe
  ]
})
export class DashboardComponent implements OnInit {

  constructor(private deviceService: DeviceService,
              private fileSizePipe: FileSizePipe) { }

  totalDevicesCard: CardDashboard;
  totalDevicesUsageCard: CardDashboard;

  ngOnInit(): void {

    this.deviceService.getTotalDevice$.subscribe(result => {
      this.totalDevicesCard = {
        Title: "Total devices",
        Icon: "fa-computer",
        Value: result
      };
    });

    this.deviceService.getTotalDevicesUsage$.subscribe(result => {
      this.totalDevicesUsageCard = {
        Title: "Total Usage",
        Icon: "fa-chart-line",
        Value: this.fileSizePipe.transform(result)
      };
    });

  }

}
