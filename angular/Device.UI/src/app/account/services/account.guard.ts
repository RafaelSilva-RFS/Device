import { Injectable } from '@angular/core';
import { CanDeactivate, CanActivate, Router } from '@angular/router';
import { LocalStorageUtils } from 'src/app/utils/localstorage';


@Injectable()
export class AccountGuard implements CanActivate {
    
    localStorageUtils = new LocalStorageUtils();

    constructor(private router: Router){}

    canActivate() {
        if(this.localStorageUtils.obterTokenUsuario()){
            this.router.navigate(['']);
        }

        return true;
    }
    
}