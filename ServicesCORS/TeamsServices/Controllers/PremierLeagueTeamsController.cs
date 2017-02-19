namespace TeamsServices.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using TeamsServices.Models;

    // [EnableCors("*", "*", "*")] from anywhere anything
    [EnableCors("http://client-5.apphb.com", "*", "GET,POST,DELETE,PUT")]
    public class PremierLeagueTeamsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult All()
        {
            var teams = new TeamModel[]
            {
                new TeamModel()
                {
                    Id = 0,
                    Name = "LeicesterCity",
                },

                new TeamModel()
                {
                    Id = 1,
                    Name = "TottenhamHotspur",
                },
                new TeamModel()
                {
                    Id = 2,
                    Name = "Arsenal",
                },
                new TeamModel()
                {
                    Id = 3,
                    Name = "ManchesterCity",
                },
                new TeamModel()
                {
                    Id = 4,
                    Name = "ManchesterUnited",
                },
                new TeamModel()
                {
                    Id = 5,
                    Name = "Southampton",
                },
                new TeamModel()
                {
                    Id = 6,
                    Name = "WestHamUnited",
                },
                new TeamModel()
                {
                    Id = 7,
                    Name = "Liverpool",
                },
                new TeamModel()
                {
                    Id = 8,
                    Name = "Watford",
                },
                new TeamModel()
                {
                    Id = 9,
                    Name = "StokeCity",
                },
                new TeamModel()
                {
                    Id = 10,
                    Name = "Everton",
                },
                new TeamModel()
                {
                    Id = 11,
                    Name = "Chelsea",
                },
                new TeamModel()
                {
                    Id = 12,
                    Name = "CrystalPalace",
                },
                new TeamModel()
                {
                    Id = 13,
                    Name = "WestBromwichAlbion",
                },
                new TeamModel()
                {
                    Id = 14,
                    Name = "AFCBournemouth",
                },
                new TeamModel()
                {
                    Id = 15,
                    Name = "SwanseaCity",
                },
                new TeamModel()
                {
                    Id = 16,
                    Name = "NorwichCity",
                },
                new TeamModel()
                {
                    Id = 17,
                    Name = "NewcastleUnited",
                },
                new TeamModel()
                {
                    Id = 18,
                    Name = "Sunderland",
                },
                new TeamModel()
                {
                    Id = 19,
                    Name = "AstonVilla",
                },
            };

            return Ok(teams);
        }
    }
}
