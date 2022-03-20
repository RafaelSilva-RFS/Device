import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Device } from '../interfaces/device';

@Injectable()
export class DeviceService {

    private baseUrl: string = "https://localhost:44363/api/v1/";

    constructor(private http: HttpClient) { }

    getTotalDevice$: Observable<any[]> = this.http
            .get<any[]>(this.baseUrl + 'count-all-devices-async');

    getTotalDevicesUsage$: Observable<any[]> = this.http
            .get<any[]>(this.baseUrl + 'count-all-devices-usage-async');

}