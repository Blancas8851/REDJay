import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ClothesService {

  //privately declared variable that will take a injected global 
  //HttpClient variable from the constructor when the class is invoked
  private  _http:HttpClient;

  constructor(private _httpclientRef:HttpClient) {
      this._http = _httpclientRef ;
  }

  //Variable for returned information
  employeeData:any = [] ;

  //methods like getClothesList() will go here
  //given example. The URL below is the URL from the API demo that Nikhil made
  //we will have our own URL's from our API
  getEmployeeDetails() {
    this._http.get('https://localhost:7145/api/Employee/elist').subscribe( (result)=>{
      this.employeeData = result 
    } ) ;
  }
  //After the coding everything above which is much like coding a controller,
  //I can next go into the app.module.ts file. In the @NgModule scope 
  //within the square brackets of the providers section. I should put the name of the 
  //service 'ClothesService'. It should then auto import at the top of the file. 





  //2. The next task will be to get the data from the service and display it in a given 
  //component. 
  //Go to the ts file of the component that will display information. Like the carousel 
  //for the homepage. (In such a case seeing as though the database will not have 
  //the byte or hexadecimal data for the image. I will have to read the jpg namespace 
  //from a name attribute and display the appropriate picture selected from the assets 
  //folder. This should come with the result that is returned such as the call made 
  //above. Instead of the list of employees like in the example. It should return a 
  //list of clothes including the picture jpg info. )
  //
  //I will now go to the homepages ts file to continue notes. For this example. 






}
