import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-uploadpage',
  templateUrl: './uploadpage.component.html',
  styleUrls: ['./uploadpage.component.css']
})
export class UploadpageComponent implements OnInit {

  




  private  _http:HttpClient;
 public errorMessage: any;
  // private _customer:CustomersService;
   constructor(private _httpclientRef:HttpClient) {
     this._http = _httpclientRef ;
 
 
   }
   
   importData:any = [] ;
 SendBoots() 
 {
      this._http
      this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Boots',{title:"Adding Boots"}).subscribe( {
        next:result=>{
        this.importData = result;
      
      } ,
      error: error => {
        this.errorMessage = error.message;
        console.error('There was an error!', error);
      } ,
    });

      if (this.importData != null)
      {
        console.log(this.importData)
        console.log("success")
      }
      }
      
      
 
    
  
  ngOnInit(): void {
  }

}
