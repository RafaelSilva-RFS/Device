import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'status'
})
export class StatusPipe implements PipeTransform {
    
    transform(status: number) {
        
        let icon = "fa-circle-xmark";
        let cssClass = "text-danger";
        let text = "Offline";

        if(status == 0) {
            icon = "fa-check";
            cssClass = "text-success";
            text = "Available";
        }

        let element = `<i class="fa-solid ${icon} ${cssClass}"></i> 
                       <span class="${cssClass} ms-1">${text}</span>`;
        
        return element;
    }

}