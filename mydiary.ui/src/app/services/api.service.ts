import { Injectable } from '@angular/core';
import {Observable} from "rxjs";
import {HttpClient, HttpContext, HttpHeaders, HttpParams} from "@angular/common/http";
import {IOptions} from "../../types";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(
    private httpClient: HttpClient
  ) {}

}
