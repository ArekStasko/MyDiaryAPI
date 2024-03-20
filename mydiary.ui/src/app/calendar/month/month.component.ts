import { Component } from '@angular/core';
import {MatSlideToggle} from "@angular/material/slide-toggle";
import {MatGridList, MatGridTile} from "@angular/material/grid-list";

@Component({
  selector: 'app-month',
  standalone: true,
  imports: [
    MatSlideToggle,
    MatGridList,
    MatGridTile
  ],
  templateUrl: './month.component.html',
  styleUrl: './month.component.scss'
})
export class MonthComponent {

}
