import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';
import { Device } from '../interfaces/device';
import { GetDevicesRequest } from '../interfaces/get-devices-request';
import { PagedDeviceResult } from '../interfaces/paged-device-result';
import { DeviceService } from '../services/devices.service';

@Component({
  selector: 'app-my-devices',
  templateUrl: './my-devices.component.html',
  encapsulation: ViewEncapsulation.None
})
export class MyDevicesComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private deviceService: DeviceService) { }

  searchForm: FormGroup;

  devicesTotal: number;
  devicesList: Device[];
  devicesListInput: GetDevicesRequest = {
    filter: "",
    sorting: "CreationTime Desc",
    status: "",
    deviceType: null,
    pageNumber: 1,
    maxResultCount: 5
  };

  ngOnInit(): void {
    this.getPagedDevices();

    this.searchForm = this.fb.group({
      filter: [''],
      deviceType: [''],
      sorting: [''],
      status: ['']
    });
  }

  searchDevices() {
    this.devicesListInput = Object.assign({}, this.devicesListInput, this.searchForm.value);        
    this.getPagedDevices();
  }

  pageChanged(event: PageChangedEvent): void {
    this.devicesListInput.pageNumber = event.page;
    this.getPagedDevices();
  }

  getPagedDevices() {
    this.deviceService.GetDevicesPaged(this.devicesListInput)
      .subscribe(
        result => {
          this.devicesTotal = result.totalCount;
          this.devicesList = result.items;
        }
      );
  }
}
