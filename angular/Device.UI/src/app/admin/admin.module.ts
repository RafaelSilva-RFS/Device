import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PaginationModule } from 'ngx-bootstrap/pagination';


import { DashboardComponent } from './dashboard/dashboard.component';
import { AdminRoutingModule } from "./admin.route";
import { MyDevicesComponent } from "./my-devices/my-devices.component";

@NgModule({
    declarations: [
        DashboardComponent,
        MyDevicesComponent

    ],
    imports: [
        CommonModule,
        AdminRoutingModule,
        PaginationModule
    ],
    exports: [
        DashboardComponent,
        MyDevicesComponent
    ]
})
export class AdminModule{}