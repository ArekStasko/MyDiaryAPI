import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {MonthComponent} from "./calendar/month/month.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MonthComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'MyDiary';
}
