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
        CardDashboardComponent

    ],
    exports: [
        DashboardComponent,
        MyDevicesComponent,
        CardDashboardComponent
    ]
})
export class AdminModule{}