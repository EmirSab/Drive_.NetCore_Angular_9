import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DriverListComponent } from './driver-list/driver-list.component';
import { RouterModule } from '@angular/router';



@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: 'list', component: DriverListComponent }
    ])
  ],
  declarations: [
    DriverListComponent
  ]
})
export class DriverModule { }
