import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountAppComponent } from './account.app.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
// import { ContaGuard } from './services/conta.guard';

const accountRouterConfig: Routes = [
    {
        path: '', component: AccountAppComponent,
        children: [
            // { path: 'cadastro', component: CadastroComponent, canActivate: [ContaGuard], canDeactivate: [ContaGuard] },
            // { path: 'login', component: LoginComponent, canActivate: [ContaGuard] }
            { path: 'login', component: LoginComponent },
            { path: 'register', component: RegisterComponent },
        ]
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(accountRouterConfig)
    ],
    exports: [RouterModule]
})
export class AccountRoutingModule { }