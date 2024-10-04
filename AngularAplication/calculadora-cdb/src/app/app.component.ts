import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CalculadoraCdbComponent } from './components/calculadora-cdb/calculadora-cdb.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormsModule, CalculadoraCdbComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'calculadora-cdb';
}
