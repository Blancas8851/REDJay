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


      addFullPiece(form:any)
      {
         form["InStock"] =true
     
         this._clothes.SendFullPieceSuit(form);
          //console.log(form)
     
        }


        addJacket(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendJacketsCoat(form);
          //console.log(form)
     
        }
        addsneaker(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSneaker(form);
          //console.log(form)
     
        }
        addsweats(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSweats(form);
          //console.log(form)
     
        }
        addjeans(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendJeans(form);
          //console.log(form)
     
        }
        addSandals(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSandals(form);
          //console.log(form)
     
        }
        addShirts(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendShirts(form);
          //console.log(form)
     
        }
        addSuitTop(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSuitTop(form);
          //console.log(form)
     
        }
        addSuitBottom(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendSuitBottom(form);
          //console.log(form)
     
        }
        addTankTop(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendTankTop(form);
          //console.log(form)
     
        }                
        addShorts(form:any)
        {
         form["InStock"] =true
     
         this._clothes.SendShorts(form);
          //console.log(form)
     
        }

                
        
        ngOnInit(): void {
       
       
        }
    
}
