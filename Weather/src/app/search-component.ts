import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Country } from './viewModels/country';
import { Place } from './viewModels/place';
import { Report } from './viewModels/Report';

import { AppService } from './app.service';

@Component({
    selector: 'search',
    templateUrl:'./src/app/search-component.html'
})

export class SearchComponent implements OnInit {

    countries$: Observable<Country[]>;
    places$: Observable<Place[]>;
    report: Report;

    constructor(private service: AppService) { }

    ngOnInit() {
        this.countries$ = this.service.getCountries();
    }

    selectCountry(country_id:number) {
        
        this.report = null;

        if (country_id != -1) {
            console.log(country_id);
            this.places$ = this.service.getPlacesByCountry(country_id);
        }                            
    }

    selectPlace(place_id: number) {        

        this.report = null;

        if (place_id != -1) {

            console.log('place_id', place_id);

            this.service.getCurrentWeather(place_id).subscribe({
                next: (data) => { this.report = data; }
            });
        }
    }

}