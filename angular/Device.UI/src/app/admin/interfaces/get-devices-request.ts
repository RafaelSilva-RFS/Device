export interface GetDevicesRequest {
    filter: string, 
    sorting: string, 
    status: string, 
    deviceType: number,
    pageNumber: number,
    maxResultCount: number
}