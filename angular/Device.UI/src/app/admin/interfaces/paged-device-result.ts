import { Device } from "./device";

export interface PagedDeviceResult {
    totalCount: number,
    items: Device[]
}