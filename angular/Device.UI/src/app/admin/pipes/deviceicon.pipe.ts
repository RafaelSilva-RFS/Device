import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'deviceicon'
})

export class DeviceIcon implements PipeTransform {

    transform(deviceType: number) {

        let icon;

        switch (deviceType) {
            case 0: //Smartphone
                icon = "fa-mobile-screen-button";
                break;
            case 1: //Ipad
                icon = "fa-tablet-screen-button";
                break;
            case 2: //Desktop
                icon = "fa-computer";
                break;
            case 3: //Laptop
                icon = "fa-laptop";
                break;
            case 6: //Television
                icon = "fa-tv";
                break;
            default:
                icon = "fa-circle-question";
                break;
        }

        return icon;
    }

}