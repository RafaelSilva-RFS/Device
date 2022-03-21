import { formatDate } from '@angular/common';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { ChartConfiguration, ChartEvent, ChartType } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';
import { DeviceDetail } from '../interfaces/device-detail';
import { FileSizeToMegabytesPipe } from '../pipes/filesizetomegabytes.pipe';


@Component({
  selector: 'app-device-detail-chart',
  templateUrl: './device-detail-chart.component.html',
  providers: [ 
    FileSizeToMegabytesPipe 
  ]
})

export class DeviceDetailChartComponent implements OnInit {  

  constructor(private fileSizeToMegabytesPipe: FileSizeToMegabytesPipe) {}

  @Input()
  deviceDetails: DeviceDetail[];
  temperatureMapped: number[];
  dataUsageMapped: number[];
  dateMapped: string[];

  public lineChartData: ChartConfiguration['data'];

  ngOnInit(): void {
    console.log(this.deviceDetails);

    this.temperatureMapped = this.deviceDetails.map(item => {
      return item.temperature
    });

    this.dataUsageMapped = this.deviceDetails.map(item => {
      return parseFloat(this.fileSizeToMegabytesPipe.transform(item.usage))
    });

    this.dateMapped = this.deviceDetails.map(item => {
      return formatDate(item.creationTime, 'MM/dd/yyyy HH:mm', 'en-US')
    });

    console.log(this.temperatureMapped);
    console.log(this.dataUsageMapped);
    console.log(this.dateMapped);

    this.lineChartData = {
      datasets: [
        {
          data: this.temperatureMapped,
          label: ' Temperature (ºC)',
          backgroundColor: 'rgba(148,159,177,0.2)',
          borderColor: '#dc3545',
          pointBackgroundColor: '#dc3545',
          pointBorderColor: '#fff',
          pointHoverBackgroundColor: '#fff',
          pointHoverBorderColor: 'rgba(148,159,177,0.8)',
          fill: 'origin',
        },
        {
          data: this.dataUsageMapped,
          label: ' Data Usage (mb)',
          yAxisID: 'y-axis-1',
          backgroundColor: 'rgba(25, 135, 84, .3)',
          borderColor: '#198754',
          pointBackgroundColor: 'rgba(25, 135, 84, 1)',
          pointBorderColor: '#fff',
          pointHoverBackgroundColor: '#fff',
          pointHoverBorderColor: 'rgba(148,159,177,0.8)',
          fill: 'origin',
        }
      ],
      labels: this.dateMapped
    };

    
  } 


  public lineChartOptions: ChartConfiguration['options'] = {
    elements: {
      line: {
        tension: 0.5
      }
    },
    scales: {
      // We use this empty structure as a placeholder for dynamic theming.
      x: {},
      'y-axis-0':
        {
          position: 'left',
        },
      'y-axis-1': {
        position: 'right',
        grid: {
          color: 'rgba(25, 135, 84, .3)',
        },
        ticks: {
          color: '#198754'
        }
      }
    },

    plugins: {
      legend: { display: true },
      
    }
  };

  public lineChartType: ChartType = 'line';

  @ViewChild(BaseChartDirective) chart?: BaseChartDirective;

  private static generateNumber(i: number): number {
    return Math.floor((Math.random() * (i < 2 ? 100 : 1000)) + 1);
  }

  public randomize(): void {
    for (let i = 0; i < this.lineChartData.datasets.length; i++) {
      for (let j = 0; j < this.lineChartData.datasets[i].data.length; j++) {
        this.lineChartData.datasets[i].data[j] = DeviceDetailChartComponent.generateNumber(i);
      }
    }
    this.chart?.update();
  }

  public hideChart(input: number): void {
    const isHidden = this.chart?.isDatasetHidden(input);
    this.chart?.hideDataset(input, !isHidden);
  }

  public pushOne(): void {
    this.lineChartData.datasets.forEach((x, i) => {
      const num = DeviceDetailChartComponent.generateNumber(i);
      x.data.push(num);
    });

    this.lineChartData?.labels?.push(formatDate(new Date(), 'MM/dd/yyyy HH:mm', 'en-US'));

    this.chart?.update();
  }

}
