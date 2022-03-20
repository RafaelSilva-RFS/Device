export interface GetDevicesRequest {
    filter: string, 
    sorting: string, 
    status: string, 
    deviceType: string,
    pageNumber: number,
    maxResultCount: number
}