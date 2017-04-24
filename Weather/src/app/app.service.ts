import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { FormControl, FormGroup, FormBuilder, FormArray } from '@angular/forms';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

import { Country } from './viewModels/country';
import { Place } from './viewModels/place';
import { Report } from './viewModels/Report';

@Injectable()
export class AppService {

    fg:FormGroup

    constructor(private http: Http, private fb: FormBuilder) {

    }

    getCountries(): Observable<Country[]> {
        $.blockUI();
        return this.http.get('http://localhost:54866/countries/')
            .do(() => { $.unblockUI();})
            .map(data => data.json())
    }

    getPlacesByCountry(countryId: number): Observable<Place[]> {
        $.blockUI();
        return this.http.get(`http://localhost:54866/countries/${countryId}/places`)
            .do(() => { $.unblockUI(); })
            .map(data => data.json());
    }

    getCurrentWeather(placeId: number) {

        $.blockUI();
        return this.http.get(`http://localhost:54866/report/today/${placeId}`)
                    .do(() => { $.unblockUI(); })
                   .map( data => data.json()) 
    }

}