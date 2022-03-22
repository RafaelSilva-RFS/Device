import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent } from './dashboard/dashboard.component';
import { DeviceDetailComponent } from './device-detail/device-detail.component';
import { HomeAppComponent } from './home.app.component';
import { MyDevicesComponent } from './my-devices/my-devices.component';
import { AuthtGuard } from './services/auth.guard';

const adminRouterConfig: Routes = [
    {
        path: '', component: HomeAppComponent,
        children: [
            { path: '', component: DashboardComponent, canActivate: [AuthtGuard] },
            { path: 'devices', component: MyDevicesComponent, canActivate: [AuthtGuard] },
            { path: 'devices/detail/:id', component: DeviceDetailComponent, canActivate: [AuthtGuard] }
        ]
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(adminRouterConfig)
    ],
    exports: [RouterModule]
})
export class AdminRoutingModule { }