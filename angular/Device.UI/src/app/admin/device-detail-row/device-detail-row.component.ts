import { Component, Input } from '@angular/core';
import { Device } from '../interfaces/device';
import { StatusPipe } from '../pipes/status.pipe';

@Component({
  selector: 'app-device-detail-row',
  templateUrl: './device-detail-row.component.html'
})
export class DeviceDetailRowComponent {

  constructor() { }

  @Input() 
  device: Device;

  @Input('size') 
  size: string;

}
