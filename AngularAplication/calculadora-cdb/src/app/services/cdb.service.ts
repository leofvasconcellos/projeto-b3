import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';

export interface CdbResponse {
  bruto: number;
  liquido: number;
}

@Injectable({
  providedIn: 'root'
})
export class CdbService {

  private apiUrl = 'https://localhost:7084/api/cdb'; //Substituir '7084' para a porta que a API está executando.

  constructor(private http: HttpClient) { }

  calcularCdb(valorInicial: number, meses: number): Observable<CdbResponse> {
    return this.http.post<CdbResponse>(this.apiUrl, { valorInicial, meses });
  }
}
