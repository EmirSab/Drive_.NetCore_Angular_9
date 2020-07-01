import { Component, OnInit } from '@angular/core';
import { Driver } from 'src/app/_interfaces/driver.model';
import { RepositoryService } from 'src/app/shared/services/repository.service';

@Component({
  selector: 'app-driver-list',
  templateUrl: './driver-list.component.html',
  styleUrls: ['./driver-list.component.css']
})
export class DriverListComponent implements OnInit {
  public drivers: Driver[];

  constructor(private repository: RepositoryService) { }

  ngOnInit(): void {
    this.getAllDrivers();
  }
  public getAllDrivers = () => {
    let apiAddress: string = 'api/drivers';
    this.repository.getData(apiAddress)
    .subscribe(res => {
      this.drivers = res as Driver[];
    });
  }
}
