﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInventoryController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();
        #region Boots Post
        [HttpPost]
        [Route("Add_Boots")] //bootsytle is bootname
        public IActionResult MakeUserBoot(UserBoot new2boot)
        {
            UserBoot newBoot = new UserBoot() { UploadStyle = new2boot.UploadStyle, UploadBrand = new2boot.UploadBrand, InStock = new2boot.InStock, UploadSize = new2boot.UploadSize, UploadCondition = new2boot.UploadCondition};
            if (newBoot != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserBoot> entityEntry = dbREDJay.UserBoots.Add(newBoot);
                dbREDJay.SaveChanges();
                return Created("", "Boot added Successfully");
            }
            else
                return BadRequest("Boot not added successfully");
        }
        #endregion
        #region FullPieceSuit Post
        [HttpPost]
        [Route("Add_FullPieceSuit")]
        public IActionResult AddFullPieceSuit(UserFullPieceSuit newFPS)
        {
            UserFullPieceSuit newFullPieceSuits = new UserFullPieceSuit() { UploadStyle = newFPS.UploadStyle, UploadBrand = newFPS.UploadBrand, InStock = newFPS.InStock, UploadSize = newFPS.UploadSize, UploadCondition = newFPS.UploadCondition };
            if (newFullPieceSuits != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserFullPieceSuit> entityEntry = dbREDJay.UserFullPieceSuits.Add(newFullPieceSuits);
                dbREDJay.SaveChanges();
                return Created("", "Full Piece Suit added Successfully");
            }
            else
                return BadRequest("Full Piece Suit not added successfully");
        }
        #endregion
        #region JacketsCoat Post
        [HttpPost]
        [Route("Add_JacketsCoat")]
        public IActionResult AddJacketsCoat(string jacketstyle, string jacketbrand, int jacketsize, int condition, bool instock)
        {
            UserJacketsCoat newJacketCoat = new UserJacketsCoat() { UploadStyle = jacketstyle, UploadBrand = jacketbrand, UploadSize = jacketsize, UploadCondition = condition, InStock = instock, };
            if (newJacketCoat != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserJacketsCoat> entityEntry = dbREDJay.UserJacketsCoats.Add(newJacketCoat);
                dbREDJay.SaveChanges();
                return Created("", "Jacket added Successfully");
            }
            else
                return BadRequest("Jacket not added successfully");
        }
        #endregion
        #region Sneaker Post
        [HttpPost]
        [Route("Add_Sneaker")]
        public IActionResult AddSneaker(string sneakername, string brandname, bool instock, int shoesizeid, int conditionid)
        {
            UserSneaker newSneaker = new UserSneaker() { UploadStyle = sneakername, UploadBrand = brandname, InStock = instock, UploadSize = shoesizeid, UploadCondition = conditionid };
            if (newSneaker != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserSneaker> entityEntry = dbREDJay.UserSneakers.Add(newSneaker);
                dbREDJay.SaveChanges();
                return Created("", "Sneaker added Successfully");
            }
            else
                return BadRequest("Sneaker not added successfully");
        }
        #endregion
        #region Sweats Post
        [HttpPost]
        [Route("Add_Sweats")]
        public IActionResult AddSwests(string sweatsname, string brandname, bool instock, int sizeid, int conditionid)
        {
            UserSweat newsweats = new UserSweat() { UploadStyle = sweatsname, UploadBrand = brandname, InStock = instock, UploadSize = sizeid, UploadCondition = conditionid };
            if (newsweats != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserSweat> entityEntry = dbREDJay.UserSweats.Add(newsweats);
                dbREDJay.SaveChanges();
                return Created("", "Sweats added Successfully");
            }
            else
                return BadRequest("Sweats not added successfully");
        }
        #endregion
        #region Jean Post
        [HttpPost]
        [Route("Add_Jeans")]
        public IActionResult AddJeans(string stylename, string brandname, bool instock, int sizeid, int conditionid)
        {
            UserJean newjeans = new UserJean() { UploadStyle = stylename, UploadBrand = brandname, InStock = instock, UploadSize = sizeid, UploadCondition = conditionid };
            if (newjeans != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserJean> entityEntry = dbREDJay.UserJeans.Add(newjeans);
                dbREDJay.SaveChanges();
                return Created("", "Jeans added Successfully");
            }
            else
                return BadRequest("Jeans not added successfully");
        }
        #endregion
        #region Sandals Post
        [HttpPost]
        [Route("Add_Sandals")]
        public IActionResult AddSandals(string sandalname, string brandname, bool instock, int shoesizeid, int conditionid)
        {
            UserSandal newSandals = new UserSandal() { UploadStyle = sandalname, UploadBrand = brandname, InStock = instock, UploadSize = shoesizeid, UploadCondition = conditionid };
            if (newSandals != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserSandal> entityEntry = dbREDJay.UserSandals.Add(newSandals);
                dbREDJay.SaveChanges();
                return Created("", "Sandals added Successfully");
            }
            else
                return BadRequest("Sandals not added successfully");
        }
        #endregion
        #region Shirts Post
        [HttpPost]
        [Route("Add_Shirts")]
        public IActionResult AddShirt(string shirtname, string brandname, bool instock, int sizeid, int conditionid)
        {
            UserShirt newShirt = new UserShirt() { UploadStyle = shirtname, UploadBrand = brandname, InStock = instock, UploadSize = sizeid, UploadCondition = conditionid };
            if (newShirt != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserShirt> entityEntry = dbREDJay.UserShirts.Add(newShirt);
                dbREDJay.SaveChanges();
                return Created("", "Shirt added Successfully");
            }
            else
                return BadRequest("Shirt not added successfully");
        }
        #endregion
        #region SuitTop Post
        [HttpPost]
        [Route("Add_SuitTop")]
        public IActionResult AddSuitTop(string suittopname, string brandname, bool instock, int sizeid, int conditionid)
        {
            UserSuitTop newsuittop = new UserSuitTop() { UploadStyle = suittopname, UploadBrand = brandname, InStock = instock, UploadSize = sizeid, UploadCondition = conditionid };
            if (newsuittop != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserSuitTop> entityEntry = dbREDJay.UserSuitTops.Add(newsuittop);
                dbREDJay.SaveChanges();
                return Created("", "Suit Top added Successfully");
            }
            else
                return BadRequest("Suit Top not added successfully");
        }
        #endregion
        #region SuitBottom Post
        [HttpPost]
        [Route("Add_SuitBottom")]
        public IActionResult AddSuitBottom(string stylename, string brandname, bool instock, int sizeid, int conditionid)
        {
            UserSuitBottom newSuitBottom = new UserSuitBottom() { UploadStyle = stylename, UploadBrand = brandname, InStock = instock, UploadSize = sizeid, UploadCondition = conditionid };
            if (newSuitBottom != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserSuitBottom> entityEntry = dbREDJay.UserSuitBottoms.Add(newSuitBottom);
                dbREDJay.SaveChanges();
                return Created("", "Suit Bottom added Successfully");
            }
            else
                return BadRequest("Suit Bottom not added successfully");
        }
        #endregion
        #region TankTop Post
        [HttpPost]
        [Route("Add_TankTop")]
        public IActionResult AddTankTop(string stylename, string brandname, bool instock, int sizeid, int conditionid)
        {
            UserTankTop newtanktop = new UserTankTop() { UploadStyle = stylename, UploadBrand = brandname, InStock = instock, UploadSize = sizeid, UploadCondition = conditionid };
            if (newtanktop != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserTankTop> entityEntry = dbREDJay.UserTankTops.Add(newtanktop);
                dbREDJay.SaveChanges();
                return Created("", "TankTop added Successfully");
            }
            else
                return BadRequest("TankTop not added successfully");
        }
        #endregion
        #region Shorts Post
        [HttpPost]
        [Route("Add_Shorts")]
        public IActionResult AddShorts(string shortname, string brandname, bool instock, int size, int conditionid)
        {
            UserShort newShorts = new UserShort() { UploadStyle = shortname, UploadBrand = brandname, InStock = instock, UploadSize = size, UploadCondition = conditionid };
            if (newShorts != null)
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserShort> entityEntry = dbREDJay.UserShorts.Add(newShorts);
                dbREDJay.SaveChanges();
                return Created("", "Shorts added Successfully");
            }
            else
                return BadRequest("Shorts not added successfully");
        }
        #endregion


       
            [HttpGet]
            [Route ("GetUserBoots")]
            public IActionResult getUserBoots()
        {

            var allboot = from j in dbREDJay.UserBoots
                         select j;
            return Ok(allboot);

        }

        [HttpPut]
        [Route("Edit_Boots")]
        public IActionResult EditBoots(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editboot = (from c in dbREDJay.UserBoots
                            where c.PkBootsId == changes
                            select c).SingleOrDefault();
            if (editboot != null)
            {
                editboot.UploadStyle = UploadStyle;
                editboot.UploadBrand = UploadBrand;
                editboot.UploadSize = UploadSize;
                editboot.UploadCondition = UploadCondition;
                editboot.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Boots were done");
            }
            else
            {
                return BadRequest("Edit for Boots was unsuccessful");
            }
        }


        [HttpPut]
        [Route("Edit_FullPieceSuits")]
        public IActionResult EditFullPieceSuit(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editfullpiecesuit = (from c in dbREDJay.UserFullPieceSuits
                                        where c.PkFullSuit == changes
                                        select c).SingleOrDefault();
            if (editfullpiecesuit != null)
            {
                editfullpiecesuit.UploadStyle = UploadStyle;
                editfullpiecesuit.UploadBrand = UploadBrand;
                editfullpiecesuit.UploadSize = UploadSize;
                editfullpiecesuit.UploadCondition = UploadCondition;
                editfullpiecesuit.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Full Piece Suits were done");
            }
            else
            {
                return BadRequest("Edit for Full Piece Suits was unsuccessful");
            }

        }

        [HttpPut]
        [Route("Edit_Jeans")]
        public IActionResult EditJeans(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editjeans = (from c in dbREDJay.UserJeans
                              where c.PkJeansId == changes
                              select c).SingleOrDefault();
            if (editjeans != null)
            {
                editjeans.UploadStyle = UploadStyle;
                editjeans.UploadBrand = UploadBrand;
                editjeans.UploadSize = UploadSize;
                editjeans.UploadCondition = UploadCondition;
                editjeans.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Jeans were done");
            }
            else
            {
                return BadRequest("Edit for Jeans was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_Shorts")]
        public IActionResult EditShorts(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editshorts = (from c in dbREDJay.UserShorts
                              where c.PkShortsId == changes
                              select c).SingleOrDefault();
            if (editshorts != null)
            {
                editshorts.UploadStyle = UploadStyle;
                editshorts.UploadBrand = UploadBrand;
                editshorts.UploadSize = UploadSize;
                editshorts.UploadCondition = UploadCondition;
                editshorts.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Shorts were done");
            }
            else
            {
                return BadRequest("Edit for Shorts was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_Sandals")]
        public IActionResult EditSandals(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editsandals = (from c in dbREDJay.UserSandals
                               where c.PkSandalsId == changes
                               select c).SingleOrDefault();
            if (editsandals != null)
            {
                editsandals.UploadStyle = UploadStyle;
                editsandals.UploadBrand = UploadBrand;
                editsandals.UploadSize = UploadSize;
                editsandals.UploadCondition = UploadCondition;
                editsandals.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Sandals were done");
            }
            else
            {
                return BadRequest("Edit for Sandals was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_JacketsCoats")]
        public IActionResult EditJacketsCoats(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editjacketcoat = (from c in dbREDJay.UserJacketsCoats
                                  where c.PkJacketCoatId == changes
                                  select c).SingleOrDefault();
            if (editjacketcoat != null)
            {
                editjacketcoat.UploadStyle = UploadStyle;
                editjacketcoat.UploadBrand = UploadBrand;
                editjacketcoat.UploadSize = UploadSize;
                editjacketcoat.UploadCondition = UploadCondition;
                editjacketcoat.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Jackets & Coats were done");
            }
            else
            {
                return BadRequest("Edit for Jackets & Coats was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_SuitBottom")]
        public IActionResult EditJSuitBottom(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editsuitbottom = (from c in dbREDJay.UserSuitBottoms
                                  where c.PkSuitBottom == changes
                                  select c).SingleOrDefault();
            if (editsuitbottom != null)
            {
                editsuitbottom.UploadStyle = UploadStyle;
                editsuitbottom.UploadBrand = UploadBrand;
                editsuitbottom.UploadSize = UploadSize;
                editsuitbottom.UploadCondition = UploadCondition;
                editsuitbottom.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Suit Bottom were done");
            }
            else
            {
                return BadRequest("Edit for Suit Bottom was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_TankTops")]
        public IActionResult EditTankTops(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var edittanktop = (from c in dbREDJay.UserTankTops
                               where c.PkTankTopId == changes
                               select c).SingleOrDefault();
            if (edittanktop != null)
            {
                edittanktop.UploadStyle = UploadStyle;
                edittanktop.UploadBrand = UploadBrand;
                edittanktop.UploadSize = UploadSize;
                edittanktop.UploadCondition = UploadCondition;
                edittanktop.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Tank Tops were done");
            }
            else
            {
                return BadRequest("Edit for Tank Tops was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_Sweats")]
        public IActionResult EditSweats(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editsweats = (from c in dbREDJay.UserSweats
                              where c.PkSweatsId == changes
                              select c).SingleOrDefault();
            if (editsweats != null)
            {
                editsweats.UploadStyle = UploadStyle;
                editsweats.UploadBrand = UploadBrand;
                editsweats.UploadSize = UploadSize;
                editsweats.UploadCondition = UploadCondition;
                editsweats.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Sweats were done");
            }
            else
            {
                return BadRequest("Edit for Sweats was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_Sneakers")]
        public IActionResult EditSneakers(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editsneakers = (from c in dbREDJay.UserSneakers
                                where c.PkSneakerId == changes
                                select c).SingleOrDefault();
            if (editsneakers != null)
            {
                editsneakers.UploadStyle = UploadStyle;
                editsneakers.UploadBrand = UploadBrand;
                editsneakers.UploadSize = UploadSize;
                editsneakers.UploadCondition = UploadCondition;
                editsneakers.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Sneakers were done");
            }
            else
            {
                return BadRequest("Edit for Sneakers was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_SuitTop")]
        public IActionResult EditSuitTop(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editsuittop = (from c in dbREDJay.UserSuitTops
                               where c.PkSuitTop == changes
                               select c).SingleOrDefault();
            if (editsuittop != null)
            {
                editsuittop.UploadStyle = UploadStyle;
                editsuittop.UploadBrand = UploadBrand;
                editsuittop.UploadSize = UploadSize;
                editsuittop.UploadCondition = UploadCondition;
                editsuittop.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Suit Tops were done");
            }
            else
            {
                return BadRequest("Edit for Suit Top was unsuccessful");
            }
        }

        [HttpPut]
        [Route("Edit_Shirts")]
        public IActionResult EditShirts(int changes, string UploadStyle, string UploadBrand, int UploadSize, int UploadCondition, bool InStock)
        {

            var editshirt = (from c in dbREDJay.UserShirts
                             where c.PkShirtId == changes
                             select c).SingleOrDefault();
            if (editshirt != null)
            {
                editshirt.UploadStyle = UploadStyle;
                editshirt.UploadBrand = UploadBrand;
                editshirt.UploadSize = UploadSize;
                editshirt.UploadCondition = UploadCondition;
                editshirt.InStock = InStock;
                dbREDJay.SaveChanges();
                return Ok("Changes to Shirts were done");
            }
            else
            {
                return BadRequest("Edit for Shirts was unsuccessful");
            }
        }



    }
}
