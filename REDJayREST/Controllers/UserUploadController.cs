using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserUploadController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        //[HttpGet]
        //[Route("User_Uploads")]
        //public IActionResult GetUserUploads()
        //{
        //    var uploadslist = from u in dbREDJay.UserUploads
        //                    select u;
        //    return Ok(uploadslist);
        //}

        [HttpGet]
        [Route("User_Uploads")]
        public IActionResult GetUserUploads()
        {
            var output =
            from c in dbREDJay.UserUploads
            join cu in dbREDJay.Customers on c.FkCustomerId equals cu.PkCustomerId
            join ja in dbREDJay.UserJacketsCoats on c.FkJacketCoatId equals ja.PkJacketCoatId
            join je in dbREDJay.UserJeans on c.FkJeansId equals je.PkJeansId
            join sw in dbREDJay.UserSweats on c.FkSweatsId equals sw.PkSweatsId
            join sh in dbREDJay.UserShorts on c.FkShortsId equals sh.PkShortsId
            join sa in dbREDJay.UserSandals on c.FkSandalsId equals sa.PkSandalsId
            join bo in dbREDJay.UserBoots on c.FkBootsId equals bo.PkBootsId
            join sn in dbREDJay.UserSneakers on c.FkSneakerId equals sn.PkSneakerId
            join sub in dbREDJay.UserSuitBottoms on c.FkSuitBottom equals sub.PkSuitBottom
            join ful in dbREDJay.UserFullPieceSuits on c.FkFullSuit equals ful.PkFullSuit
            join sut in dbREDJay.UserSuitTops on c.FkSuitTop equals sut.PkSuitTop
            join shi in dbREDJay.UserShirts on c.FkShirtId equals shi.PkShirtId
            join tan in dbREDJay.UserTankTops on c.FkTankTopId equals tan.PkTankTopId
            select new
            {
                c.PkCartId,
                cu.PkCustomerId,
                ja.PkJacketCoatId,
                je.PkJeansId,
                sw.PkSweatsId,
                sh.PkShortsId,
                sa.PkSandalsId,
                bo.PkBootsId,
                sn.PkSneakerId,
                sub.PkSuitBottom,
                ful.PkFullSuit,
                sut.PkSuitTop,
                shi.PkShirtId,
                tan.PkTankTopId

            };
            return Ok(output);
        }
    }
}
