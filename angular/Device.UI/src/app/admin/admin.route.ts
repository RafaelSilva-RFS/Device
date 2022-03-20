import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent } from './dashboard/dashboard.component';
import { MyDevicesComponent } from './my-devices/my-devices.component';

const adminRouterConfig: Routes = [
    { path: '', component: DashboardComponent },
    { path: 'my-devices', component: MyDevicesComponent }
];

@NgModule({
    imports: [
        RouterModule.forChild(adminRouterConfig)
    ],
    exports: [RouterModule]
})
export class AdminRoutingModule { }