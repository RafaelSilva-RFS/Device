import { Component, OnInit } from '@angular/core';
import { CardDashboard } from '../interfaces/card-dashboard';
import { DeviceService } from '../services/devices.service';
import { Observable } from 'rxjs';
import { FileSizePipe } from '../pipes/filesize.pipe';
import { CountDevicesRequest } from '../interfaces/count-devices-request';
import { GetDevicesRequest } from '../interfaces/get-devices-request';
import { Device } from '../interfaces/device';

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
  totalAvailableDevicesCard: CardDashboard;

  countAvaiableDevicesInput: CountDevicesRequest = {
    deviceType: "",
    filter: "",
    status: "0"
  };

  lastDevices: Device[];
  lastDevicesInput: GetDevicesRequest = {
    filter: "",
    sorting: "CreationTime Desc",
    status: "",
    deviceType: "",
    pageNumber: 1,
    maxResultCount: 3
  };


  offlineDevices: Device[];
  offlineDevicesInput: GetDevicesRequest = {
    filter: "",
    sorting: "CreationTime Desc",
    status: "1",
    deviceType: "",
    pageNumber: 1,
    maxResultCount: 3
  };



  ngOnInit(): void {

    this.deviceService.getTotalDevice$
      .subscribe(result => {
        this.totalDevicesCard = {
          Title: "Total devices",
          Icon: "fa-computer",
          Value: result
        };
      });

    this.deviceService.getTotalDevicesUsage$
      .subscribe(result => {
        this.totalDevicesUsageCard = {
          Title: "Total Usage",
          Icon: "fa-chart-line",
          Value: this.fileSizePipe.transform(result)
        };
      });

    this.deviceService.CountDevices(this.countAvaiableDevicesInput)
      .subscribe(
        result => {
          this.totalAvailableDevicesCard = {
            Title: "Available devices",
            Icon: "fa-house-laptop",
            Value: result
          }
        }
      );

    this.deviceService.GetDevicesPaged(this.lastDevicesInput)
      .subscribe(
        result => {
          this.lastDevices = result.items;
        }
      );

    this.deviceService.GetDevicesPaged(this.offlineDevicesInput)
      .subscribe(
        result => {
          this.offlineDevices = result.items;
        }
      );

  }

}
