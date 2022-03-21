import { DeviceDetail } from "./device-detail";

export interface Device {
    id: string,
    name: string,
    type: number,
    creationTime: Date,
    status: number,
    DeviceDetail: DeviceDetail[]
}