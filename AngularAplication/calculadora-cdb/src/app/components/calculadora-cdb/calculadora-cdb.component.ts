import { Component } from '@angular/core';
import { CdbResponse, CdbService } from '../../services/cdb.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-calculadora-cdb',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './calculadora-cdb.component.html',
  styleUrl: './calculadora-cdb.component.css'
})
export class CalculadoraCdbComponent {

  valorInicial: number = 0;
  meses: number = 0;
  resultado: CdbResponse | undefined;
  erro: string | undefined;

  constructor(private cdbService: CdbService) {}

  calcular() {
    if (this.valorInicial <= 0 || this.meses <= 1) {
      this.erro = 'Por favor, insira um valor positivo e um prazo em meses maior que 1.';
      return;
    }

    this.cdbService.calcularCdb(this.valorInicial, this.meses).subscribe({
      next: (res) => {
        console.log('Resposta da API:', res);
        this.resultado = res;
        this.erro = undefined;
      },
      error: (err) => {
        this.erro = 'Ocorreu um erro ao calcular o investimento.';
      }
    });
  }
}
