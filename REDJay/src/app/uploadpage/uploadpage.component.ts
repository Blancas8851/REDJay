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
      getAllUserJacketsCoat()
      {
      this._clothes.getUserJacketsCoat().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });

      }
      getAllUserSneaker()
      {
      this._clothes.getUserSneaker().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });

      }

      getAllUserSweats()
      {
      this._clothes.getUserSweats().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });

      }
      getAllUserFullPieceSuit()
      {
      this._clothes.getUserFullPieceSuit().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });

      }
      getAllUserJean()

      {
      this._clothes.  getUserJean().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });
    }
          getAllUserSandals()
          {
          this._clothes.getUserSandals().subscribe((result) => { 
            this.customersData = result
            console.log(result)
          });
        }
        getAllUserShirts()
          {
          this._clothes.getUserShirts().subscribe((result) => { 
            this.customersData = result
            console.log(result)
          });
        }
        getAllUserSuitTop()
          {
          this._clothes.getUserSuitTop().subscribe((result) => { 
            this.customersData = result
            console.log(result)
          });
            }
            getAllUserSuitBottom()
        {
        this._clothes.getUserSuitBottom().subscribe((result) => { 
          this.customersData = result
          console.log(result)
        });
      }
      getAllUserTankTop()
      {
      this._clothes.getUserTankTop().subscribe((result) => { 
        this.customersData = result
        console.log(result)
      });
    }
    getAllUserShorts()
      {
      this._clothes.getUserShorts().subscribe((result) => { 
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



      editserFullPieceSuit(suitid:any) 
      {

      console.log(suitid)

      this._clothes.approveUserFullPieceSuit(suitid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserJacketsCoat(jacketcoatid:any) 
      {

      console.log(jacketcoatid)

      this._clothes.approveUserJacketsCoat(jacketcoatid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserJeans(jeansid:any) 
      {

      console.log(jeansid)

      this._clothes.approveUserJeans(jeansid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSandals(sandalsid:any) 
      {

      console.log(sandalsid)

      this._clothes.approveUserSandals(sandalsid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserShirts(shirtsid:any) 
      {

      console.log(shirtsid)

      this._clothes.approveUserShirts(shirtsid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSneakers(sneakersid:any) 
      {

      console.log(sneakersid)

      this._clothes.approveUserSneakers(sneakersid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSuitTop(suittopid:any) 
      {

      console.log(suittopid)

      this._clothes.approveUserSuitTop(suittopid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserSuitBottom(suitbottomid:any) 
      {

      console.log(suitbottomid)

      this._clothes.approveUserSuitBottom(suitbottomid).subscribe((result)=> {
        console.log(result)
      });
      }


      editUserShorts(shortsid:any) 
      {

      console.log(shortsid)

      this._clothes.approveUserShorts(shortsid).subscribe((result)=> {
        console.log(result)
      });
      }


          
        ngOnInit(): void {
       
       
        }
    
}
