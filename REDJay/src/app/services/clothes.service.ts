import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ClothesService {

  //privately declared variable that will take a injected global 
  //HttpClient variable from the constructor when the class is invoked
  private  _http:HttpClient;
  public errorMessage:any;

  constructor(private _httpclientRef:HttpClient) {
      this._http = _httpclientRef ;
  }

  //Variable for returned information
  clothesData:any = [] ;

  //CRUD methods like getClothesList(), updatePants(), etc will go here
  //sucha as given example. The URL below is the URL from the API demo 
  //that Nikhil made we will have our own URL's from our API





  //CREATE
  /*
https://localhost:7041/api/UserInventory/Add_Boots
https://localhost:7041/api/UserInventory/Add_FullPieceSuit
https://localhost:7041/api/UserInventory/Add_JacketsCoat
https://localhost:7041/api/UserInventory/Add_Sneaker
https://localhost:7041/api/UserInventory/Add_Sweats
https://localhost:7041/api/UserInventory/Add_Jeans
https://localhost:7041/api/UserInventory/Add_Sandals
https://localhost:7041/api/UserInventory/Add_Shirts
https://localhost:7041/api/UserInventory/Add_SuitTop
https://localhost:7041/api/UserInventory/Add_SuitBottom
https://localhost:7041/api/UserInventory/Add_TankTop
https://localhost:7041/api/UserInventory/Add_Shorts
*/


  
  importData:any = [] ;

  // adding a new user boot
SendBoots(form:any) 
{
  // var data = {
  //   "UploadStyle":form, "UploadBrand" :"polo", "InStock": true, "UploadSize": 1, "UploadCondition" : 1 }
     this._http
     this._http.post<any>('https://localhost:7041/api/UserInventory/Add_Boots',form,{headers:new HttpHeaders({'Content-Type':'application/json'})}).subscribe( {
       next:result=>{
       this.importData = result;
     
     } ,
     error: error => {
       this.errorMessage = error.message;
       if (error.status == 201){
         console.log("youre good")
       }
       else
       console.error('There was an error!', error );
     } ,
   });

     if (this.importData != null)
     {
       console.log(this.importData)
       console.log("success")
     }
     }


  



  //approve user boot
  approveUserBoot(id:any)
  {
    return(this._http.put("https://localhost:7041/api/AdminApproval/Approve_Boots/"+id,null))
  }

  //get all user boots
  getUserBoots()
  {

    return(this._http.get('https://localhost:7041/api/UserInventory/GetUserBoots'))
  }






//READ

  getAllBoots() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Boots').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getFullPieceSuits() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Full_Piece_Suits').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getCoatsAndJackets() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Jackets/Coats').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllJeans() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Jeans').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSandals() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sandals').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllShorts() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Shorts').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSneakers() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sneakers').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSuitBottoms() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Suit_Bottoms').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSuitTops() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Suit_Tops').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllSweats() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Sweats').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }

  getAllShirts() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Shirts').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }
  
  getAllTankTops() {
    this._http.get('https://localhost:7041/api/Inventory/List_of_Tank_Tops').subscribe( (result)=>{
      this.clothesData = result 
    } ) ;
  }


  //UPDATE
  /*
  https://localhost:7041/api/UserInventory/Edit_Boots
https://localhost:7041/api/UserInventory/Edit_FullPieceSuits
https://localhost:7041/api/UserInventory/Edit_Jeans
https://localhost:7041/api/UserInventory/Edit_Shorts
https://localhost:7041/api/UserInventory/Edit_Sandals
https://localhost:7041/api/UserInventory/Edit_JacketsCoats
https://localhost:7041/api/UserInventory/Edit_SuitBottom
https://localhost:7041/api/UserInventory/Edit_TankTops
https://localhost:7041/api/UserInventory/Edit_Sweats
https://localhost:7041/api/UserInventory/Edit_Sneakers
https://localhost:7041/api/UserInventory/Edit_SuitTop
https://localhost:7041/api/UserInventory/Edit_Shirts

  */









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
