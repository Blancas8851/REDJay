using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
using System.Linq;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminApprovalController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        [HttpPut]
        [Route("Approve_Boots")]
        public IActionResult EditBoots(int changes, bool Approval)
        {

            var editboots = (from c in dbREDJay.UserBoots
                                     where c.PkBootsId == changes
                                     select c).SingleOrDefault();
            if (editboots != null)
            {
                editboots.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Boots have been approved");
                }
                else
                {
                    return Ok("Boots have not been approved");
                }
            }
            else
            {
                return BadRequest("Boots have not approved");
            }

        }

        [HttpPut]
        [Route("Approve_FullPieceSuit")]
        public IActionResult EditFullPieceSuit(int changes, bool Approval)
        {

            var editfullpiecesuit = (from c in dbREDJay.UserFullPieceSuits
                                     where c.PkFullSuit == changes
                                     select c).SingleOrDefault();
            if (editfullpiecesuit != null)
            {   
                editfullpiecesuit.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Full Piece Suit has been approved");
                }
                else
                {
                    return Ok("Full Piece Suit has not been approved");
                }
            }
            else
            {
                return BadRequest("Full Piece Suits was not approved");
            }

        }

        [HttpPut]
        [Route("Approve_JacketsCoat")]
        public IActionResult EditJacketsCoat(int changes, bool Approval)
        {

            var editjacketscoat = (from c in dbREDJay.UserJacketsCoats
                                     where c.PkJacketCoatId == changes
                                     select c).SingleOrDefault();
            if (editjacketscoat != null)
            {
                editjacketscoat.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Jacket or Coat has been approved");
                }
                else
                {
                    return Ok("Jacket or Coat has not been approved");
                }
            }
            else
            {
                return BadRequest("Jacket or Coat was not approved");
            }

        }

        [HttpPut]
        [Route("Approve_Jeans")]
        public IActionResult EditJeans(int changes, bool Approval)
        {

            var editjeans = (from c in dbREDJay.UserJeans
                                   where c.PkJeansId == changes
                                   select c).SingleOrDefault();
            if (editjeans != null)
            {
                editjeans.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Jeans have been approved");
                }
                else
                {
                    return Ok("Jeans have not been approved");
                }
            }
            else
            {
                return BadRequest("Jeans were not approved");
            }

        }

        [HttpPut]
        [Route("Approve_Sandals")]
        public IActionResult EditSandals(int changes, bool Approval)
        {

            var editsandal = (from c in dbREDJay.UserSandals
                              where c.PkSandalsId == changes
                              select c).SingleOrDefault();
            if (editsandal != null)
            {
                editsandal.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Sandals have been approved");
                }
                else
                {
                    return Ok("Sandals have not been approved");
                }
            }
            else
            {
                return BadRequest("Sandals were not approved");
            }

        }

        [HttpPut]
        [Route("Approve_Shirts")]
        public IActionResult EditShirts(int changes, bool Approval)
        {

            var editshirt = (from c in dbREDJay.UserShirts
                             where c.PkShirtId == changes
                             select c).SingleOrDefault();
            if (editshirt != null)
            {
                editshirt.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Shirts have been approved");
                }
                else
                {
                    return Ok("Shirts have not been approved");
                }
            }
            else
            {
                return BadRequest("Shirts were not approved");
            }

        }

        [HttpPut]
        [Route("Approve_Sneakers")]
        public IActionResult EditSneakers(int changes, bool Approval)
        {

            var editsneaker = (from c in dbREDJay.UserSneakers
                               where c.PkSneakerId == changes
                               select c).SingleOrDefault();
            if (editsneaker != null)
            {
                editsneaker.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Sneakers have been approved");
                }
                else
                {
                    return Ok("Sneakers have not been approved");
                }
            }
            else
            {
                return BadRequest("Sneakers were not approved");
            }

        }

        [HttpPut]
        [Route("Approve_SuitTop")]
        public IActionResult EditSuitTop(int changes, bool Approval)
        {

            var editsuittop = (from c in dbREDJay.UserSuitTops
                               where c. PkSuitTop == changes
                               select c).SingleOrDefault();
            if (editsuittop != null)
            {
                editsuittop.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Suit Top has been approved");
                }
                else
                {
                    return Ok("Suit Top has not been approved");
                }
            }
            else
            {
                return BadRequest("Suit Top was not approved");
            }

        }

        [HttpPut]
        [Route("Approve_SuitBottom")]
        public IActionResult EditSuitBottom(int changes, bool Approval)
        {

            var editsuitbottom = (from c in dbREDJay.UserSuitBottoms
                                  where c.PkSuitBottom == changes
                                  select c).SingleOrDefault();
            if (editsuitbottom != null)
            {
                editsuitbottom.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Suit Bottom has been approved");
                }
                else
                {
                    return Ok("Suit Bottom has not been approved");
                }
            }
            else
            {
                return BadRequest("Suit Bottom was not approved");
            }

        }

        [HttpPut]
        [Route("Approve_Shorts")]
        public IActionResult EditShorts(int changes, bool Approval)
        {

            var editshorts = (from c in dbREDJay.UserShorts
                              where c.PkShortsId == changes
                              select c).SingleOrDefault();
            if (editshorts != null)
            {
                editshorts.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Shorts have been approved");
                }
                else
                {
                    return Ok("Shorts have not been approved");
                }
            }
            else
            {
                return BadRequest("Shorts were not approved");
            }

        }

        [HttpPut]
        [Route("Approve_TankTops")]
        public IActionResult EditTankTops(int changes, bool Approval)
        {

            var edittanktop = (from c in dbREDJay.UserTankTops
                               where c.PkTankTopId == changes
                               select c).SingleOrDefault();
            if (edittanktop != null)
            {
                edittanktop.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Tank Top has been approved");
                }
                else
                {
                    return Ok("Tank Top has not been approved");
                }
            }
            else
            {
                return BadRequest("Tank Top was not approved");
            }

        }

        [HttpPut]
        [Route("Approve_Sweats")]
        public IActionResult EditSweats(int changes, bool Approval)
        {

            var editsweats = (from c in dbREDJay.UserSweats
                              where c.PkSweatsId == changes
                              select c).SingleOrDefault();
            if (editsweats != null)
            {
                editsweats.AdminApproval = Approval;
                dbREDJay.SaveChanges();
                if (Approval == true)
                {
                    return Ok("Sweats have been approved");
                }
                else
                {
                    return Ok("Sweats have not been approved");
                }
            }
            else
            {
                return BadRequest("Sweats were not approved");
            }

        }




    }
}
