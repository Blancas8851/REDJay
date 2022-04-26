using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REDJayREST.Models.EF;
namespace REDJayREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        redjayDBContext dbREDJay = new redjayDBContext();

        [HttpGet]
        [Route("List of Boots")]
        public IActionResult GetBootslist()
        {
            var bootslist = from b in dbREDJay.Boots
                            select b;
            return Ok(bootslist);
        }

        [HttpGet]
        [Route("List of Full Piece Suits")]
        public IActionResult GetFullPieceSuitList()
        {
            var suitslist = from s in dbREDJay.FullPieceSuits
                            select s;
            return Ok(suitslist);
        }

        [HttpGet]
        [Route("List of Jackets/Coats")]
        public IActionResult GetJacketslist()
        {
            var jacketslist = from j in dbREDJay.JacketsCoats
                              select j;
            return Ok(jacketslist);
        }

        [HttpGet]
        [Route("List of Jeans")]
        public IActionResult GetJeanslist()
        {
            var jeanslist = from j in dbREDJay.Jeans
                            select j;
            return Ok(jeanslist);
        }

        [HttpGet]
        [Route("List of Sandals")]
        public IActionResult GetSandalslist()
        {
            var sandalslist = from s in dbREDJay.Sandals
                              select s;
            return Ok(sandalslist);
        }

        [HttpGet]
        [Route("List of Shorts")]
        public IActionResult GetClotheslist()
        {
            var shortslist = from s in dbREDJay.Shorts
                             select s;
            return Ok(shortslist);
        }

        [HttpGet]
        [Route("List of Sneakers")]
        public IActionResult GetSneakerslist()
        {
            var sneakerslist = from s in dbREDJay.Sneakers
                               select s;
            return Ok(sneakerslist);
        }

        [HttpGet]
        [Route("List of Suit Bottoms")]
        public IActionResult GetSuitBottomslist()
        {
            var suitbottomslist = from b in dbREDJay.SuitBottoms
                                  select b;
            return Ok(suitbottomslist);
        }

        [HttpGet]
        [Route("List of Suit Tops")]
        public IActionResult GetSuitTopslist()
        {
            var suittopslist = from t in dbREDJay.SuitTops
                               select t;
            return Ok(suittopslist);
        }

        [HttpGet]
        [Route("List of Sweats")]
        public IActionResult GetSweatslist()
        {
            var sweatslist = from s in dbREDJay.Sweats
                             select s;
            return Ok(sweatslist);
        }


        [HttpGet]
        [Route("List of Shirts")]
        public IActionResult GetShirtslist()
        {
            var shirtslist = from t in dbREDJay.Shirts
                              select t;
            return Ok(shirtslist);
        }

        [HttpGet]
        [Route("List of Tank_Tops")]
        public IActionResult GetTankTopslist()
        {
            var tanktopslist = from b in dbREDJay.Boots
                               select b;
            return Ok(tanktopslist);
        }
    }
}
