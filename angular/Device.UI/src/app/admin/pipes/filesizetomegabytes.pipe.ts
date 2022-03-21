import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
    name: 'filesizetomegabytes'
})
export class FileSizeToMegabytesPipe implements PipeTransform {
    
    transform(size: any) {        
        let tamanhoCalculado = (size / (1024 * 1024))
        return tamanhoCalculado.toFixed(2);
    }

}