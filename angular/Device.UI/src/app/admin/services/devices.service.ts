import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Device } from '../interfaces/device';
import { CountDevicesRequest } from '../interfaces/count-devices-request';
import { GetDevicesRequest } from '../interfaces/get-devices-request';
import { PagedDeviceResult } from '../interfaces/paged-device-result';
import { BaseService } from 'src/app/utils/base.service';

@Injectable()
export class DeviceService extends BaseService {
        
        private baseUrl: string = "https://localhost:44363/api/v1/";

        bearerToken = this.LocalStorage.obterTokenUsuario();

        constructor(private http: HttpClient) { super(); }

        public GetDevicesPaged(input: GetDevicesRequest): Observable<PagedDeviceResult> {
                
                let queryParams = new HttpParams();
                queryParams = queryParams.append("filter", input.filter);
                queryParams = queryParams.append("sorting", input.sorting);
                queryParams = queryParams.append("status", input.status);
                queryParams = queryParams.append("deviceType", input.deviceType == null ? "" : input.deviceType);
                queryParams = queryParams.append("pageNumber", input.pageNumber);
                queryParams = queryParams.append("maxResultCount", input.maxResultCount);

                

                return this.http.get<PagedDeviceResult>(this.baseUrl + 'get-devices-paged-async', 
                { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': `Bearer ${this.bearerToken}`}), params: queryParams });
        }

        public GetMostUsedDevicesPaged(take: number): Observable<Device[]> {
                
                let queryParams = new HttpParams();
                queryParams = queryParams.append("take", take);


                return this.http.get<Device[]>(this.baseUrl + 'get-most-used-devices', 
                { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': `Bearer ${this.bearerToken}`}), params: queryParams });
        }

        public GetDeviceById(input: string): Observable<Device> {
                
                let queryParams = new HttpParams();
                queryParams = queryParams.append("id", input);

                return this.http.get<Device>(this.baseUrl + 'get-device-by-id', 
                { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': `Bearer ${this.bearerToken}`}), params: queryParams });
        }

        public CountDevices(input: CountDevicesRequest): Observable<any[]> {
                
                let queryParams = new HttpParams();
                queryParams = queryParams.append("filter", input.filter);
                queryParams = queryParams.append("status", input.status);
                queryParams = queryParams.append("deviceType", input.deviceType);

                return this.http.get<any[]>(this.baseUrl + 'count-devices-async', 
                { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': `Bearer ${this.bearerToken}`}), params: queryParams });
        }

        getTotalDevice$: Observable<any[]> = this.http
                .get<any[]>(this.baseUrl + 'count-all-devices-async', 
                { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': `Bearer ${this.bearerToken}`}) });

        getTotalDevicesUsage$: Observable<any[]> = this.http
                .get<any[]>(this.baseUrl + 'count-all-devices-usage-async', 
                { headers: new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': `Bearer ${this.bearerToken}`}) });

}