import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PaginationModule } from 'ngx-bootstrap/pagination';


import { DashboardComponent } from './dashboard/dashboard.component';
import { AdminRoutingModule } from "./admin.route";
import { MyDevicesComponent } from "./my-devices/my-devices.component";
import { HttpClientModule } from "@angular/common/http";
import { DeviceService } from "./services/devices.service";
import { CardDashboardComponent } from './card-dashboard/card-dashboard.component';
import { DeviceDetailComponent } from './device-detail/device-detail.component';
import { DeviceDetailRowComponent } from './device-detail-row/device-detail-row.component';
import { MyDevicesCtaComponent } from './my-devices-cta/my-devices-cta.component';
import { StatusPipe } from "./pipes/status.pipe";
import { DeviceIcon } from "./pipes/deviceicon.pipe";

@NgModule({
    imports: [
        CommonModule,
        AdminRoutingModule,
        PaginationModule,
        HttpClientModule
    ],
    providers: [
        DeviceService
    ],
    declarations: [
        DashboardComponent,
        MyDevicesComponent,
        CardDashboardComponent,
        DeviceDetailComponent,
        DeviceDetailRowComponent,
        MyDevicesCtaComponent,
        StatusPipe,
        DeviceIcon
    ],
    exports: [
        DashboardComponent,
        MyDevicesComponent,
        CardDashboardComponent,
        DeviceDetailComponent,
        DeviceDetailRowComponent,
        MyDevicesCtaComponent,
        StatusPipe,
        DeviceIcon
    ]
})
export class AdminModule{}