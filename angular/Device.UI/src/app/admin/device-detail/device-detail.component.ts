import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Device } from '../interfaces/device';
import { GetDevicesRequest } from '../interfaces/get-devices-request';
import { PagedDeviceResult } from '../interfaces/paged-device-result';
import { DeviceService } from '../services/devices.service';

@Component({
  selector: 'app-device-detail',
  templateUrl: './device-detail.component.html'
})
export class DeviceDetailComponent implements OnInit {

  constructor(private route: ActivatedRoute,
              private router: Router,
              private deviceService: DeviceService) { 
                this.router.routeReuseStrategy.shouldReuseRoute = () => false;
              }

  idDeviceParam: string;
  device: Device;
  relatedDevices: PagedDeviceResult;

  relatedDevicesListInput: GetDevicesRequest = {
    filter: "",
    sorting: "CreationTime Desc",
    status: "",
    deviceType: null,
    pageNumber: 1,
    maxResultCount: 5
  };

  ngOnInit(): void {
    this.route.params
      .subscribe(params => {
        this.idDeviceParam = params['id'];
      });

    this.getDevice();
  }

  getDevice() {
    this.deviceService.GetDeviceById(this.idDeviceParam)
      .subscribe(
        result => {
          this.device = result;

          this.relatedDevicesListInput.deviceType = result.type;

          this.deviceService.GetDevicesPaged(this.relatedDevicesListInput)
            .subscribe(
              relatedResult => {
                this.relatedDevices = relatedResult;
              }
            )

        }
      );
  }

}
