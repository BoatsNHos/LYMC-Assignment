using LmycDataLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Data
{
    public class DummyData
    {

        public static List<ApplicationUser> getUsers()
        {
            List<ApplicationUser> users = new List<ApplicationUser>()
            {
                new ApplicationUser
                {
                    Id = "Id",
                    UserName = "UserName",
                    FirstName = "First",
                    LastName = "Last",
                    Street = "Street",
                    City = "City",
                    Province = "Province",
                    Country = "Country",
                    PostalCode = "A1B 2C3",
                    SailingExperience = "Beginner",
                    Email = "Email",
                    PhoneNumber = "1234567890",
                }
            };

            return users;
        }
        public static List<Boat> getBoats()
        {

            Boat EggsTaSea = new Boat()
            {
                BoatName = "Eggs-ta-Sea",
                Picture = "http://newimages.yachtworld.com/resize/1/77/38/6207738_20170418025556754_1_XLARGE.jpg?f=/1/77/38/6207738_20170418025556754_1_XLARGE.jpg&w=1200&h=798&t=1498735754000",
                LengthInFeet = 15,
                Make = "Byte",
                Year = "1980",
                Record = "0-20 has never won a race and never will",
                CreationDate = DateTime.Parse("2008-11-11"),
                //CreatedBy = "Id"
            };

            Boat KnottyBuoy = new Boat()
            {
                BoatName = "Knotty-Buoy",
                Picture = "https://fthmb.tqn.com/9neTcs--DcGY7rrNQy9zQCr9c3M=/2121x1414/filters:fill(auto,1)/GettyImages-503108753-590116e33df78c545640ee88.jpg",
                LengthInFeet = 15,
                Make = "720",
                Year = "1990",
                Record = "10-2 has done well!",
                CreationDate = DateTime.Parse("1993-08-10"),
                //CreatedBy = "Id"
            };

            Boat Flambouyant = new Boat()
            {
                BoatName = "Flambouyant",
                Picture = "http://markinternational.info/data/out/159/220022781-sailboat-wallpapers.jpg",
                LengthInFeet = 15,
                Make = "Pirate Ship",
                Year = "2010",
                Record = "100-0 will win all the races",
                CreationDate = DateTime.Parse("2016-01-07"),
                //CreatedBy = "Id"
            };

            List<Boat> Boats = new List<Boat>() { EggsTaSea, KnottyBuoy, Flambouyant };

            return Boats;
        }
    }
}
