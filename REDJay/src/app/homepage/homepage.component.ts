import { Component, OnInit } from '@angular/core';
import { ClothesService } from '../services/clothes.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {

  //Continued notes and demo code related to Nikhil's demo project. 
  //Will declare a variable of type service that this component will listen to 
  //for data. In my case the clothes data. 
  private _clothesSer:ClothesService; 


  constructor(_clothesSerRef:ClothesService) {
    this._clothesSer = _clothesSerRef;
  }

  
  

  ngOnInit(): void {
  }

}
