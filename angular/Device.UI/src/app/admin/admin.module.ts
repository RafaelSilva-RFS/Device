import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { ReactiveFormsModule } from '@angular/forms';
import { NgChartsModule } from 'ng2-charts';


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
import { DeviceDetailChartComponent } from './device-detail-chart/device-detail-chart.component';
import { HomeAppComponent } from "./home.app.component";
import { FooterComponent } from "../shared/footer/footer.component";
import { HeaderComponent } from "../shared/header/header.component";

@NgModule({
    imports: [
        CommonModule,
        AdminRoutingModule,
        PaginationModule,
        HttpClientModule,
        ReactiveFormsModule,
        NgChartsModule
    ],
    providers: [
        DeviceService
    ],
    declarations: [
        HomeAppComponent,
        FooterComponent,
        HeaderComponent,
        DashboardComponent,
        MyDevicesComponent,
        CardDashboardComponent,
        DeviceDetailComponent,
        DeviceDetailRowComponent,
        MyDevicesCtaComponent,
        StatusPipe,
        DeviceIcon,
        DeviceDetailChartComponent
    ],
    exports: [
        HomeAppComponent,
        FooterComponent,
        HeaderComponent,
        DashboardComponent,
        MyDevicesComponent,
        CardDashboardComponent,
        DeviceDetailComponent,
        DeviceDetailRowComponent,
        MyDevicesCtaComponent,
        DeviceDetailChartComponent,
        StatusPipe,
        DeviceIcon
    ]
})
export class AdminModule{}