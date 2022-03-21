import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent } from './dashboard/dashboard.component';
import { DeviceDetailComponent } from './device-detail/device-detail.component';
import { MyDevicesComponent } from './my-devices/my-devices.component';

const adminRouterConfig: Routes = [
    { path: '', component: DashboardComponent },
    { path: 'devices', component: MyDevicesComponent },
    { path: 'devices/detail/:id', component: DeviceDetailComponent }
];

@NgModule({
    imports: [
        RouterModule.forChild(adminRouterConfig)
    ],
    exports: [RouterModule]
})
export class AdminRoutingModule { }