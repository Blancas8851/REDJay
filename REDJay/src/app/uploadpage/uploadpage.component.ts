import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ClothesService } from '../services/clothes.service';


@Component({
  selector: 'app-uploadpage',
  templateUrl: './uploadpage.component.html',
  styleUrls: ['./uploadpage.component.css']
})
export class UploadpageComponent implements OnInit {

  




  private _clothes:ClothesService;
  private  _http:HttpClient;
 // private _customer:CustomersService;
  constructor(private _httpclientRef:HttpClient, private clothes: ClothesService) {
    this._http = _httpclientRef ;
    this._clothes = clothes;
 
   }
   
   importData:any = [] ;
   
  customersData:any = [] ;
   
    addboots(form:any)
    {
       form["InStock"] =true
   
       this._clothes.SendBoots(form);
        //console.log(form)
   
      }
      
      //get
      getAllUsersBoot()
      {
      this._clothes.getUserBoots().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });

      }

      //put
      editUserBoot(bootid:any) 
      {

      console.log(bootid)

      this._clothes.approveUserBoot(bootid).subscribe((result)=> {
        console.log(result)
      });
      }



      
          
        
        ngOnInit(): void {
       
       
        }
    
}
