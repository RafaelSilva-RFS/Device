export interface GetDevicesRequest {
    filter: string, 
    sorting: string, 
    status: string, 
    deviceType: string,
    pageNumber: string,
    maxResultCount: string
}