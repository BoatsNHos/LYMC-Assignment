using LmycDataLib.Models;
using LmycDataLib.Models.BoatInventory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace LmycDataLib.Data
{
    public class DummyData
    {
        public static List<Boat> getBoats()
        {
            byte[] ImageToArray(Image img)
            {
                byte[] arr;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arr = ms.ToArray();
                }
                return arr;
            }

            List<Boat> Boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatName="Eggs-ta-Sea",
                    Picture=ImageToArray(Image.FromFile(@"C:\ASP_Projects\
                                                LYMC-Assignment\LmycDataLib\
                                                SeedImages\Eggs-Ta-See.jpg")),
                    LengthInFeet=15,
                    Make="Byte",
                    Year="1980",
                    Record="0-20 has never won a race and never will",
                    CreationDate=DateTime.Parse("2008-11-11"),
                    ApplicationUserId=(new ApplicationDbContext()).Users.Find("a@a.c").Email,
                    CreatedBy="admin"
                },
                new Boat()
                {
                    BoatName="Knotty-Buoy",
                    Picture=ImageToArray(Image.FromFile(@"C:\ASP_Projects\
                                                LYMC-Assignment\LmycDataLib\
                                                SeedImages\Knotty-Buoy.jpg")),
                    LengthInFeet=15,
                    Make="720",
                    Year="1990",
                    Record="10-2 has done well!",
                    CreationDate=DateTime.Parse("1993-08-10"),
                    ApplicationUserId=(new ApplicationDbContext()).Users.Find("a@a.c").Email,
                    CreatedBy="admin"
                },
                new Boat()
                {
                    BoatName="Flambouyant",
                    Picture=ImageToArray(Image.FromFile(@"C:\ASP_Projects\
                                                LYMC-Assignment\LmycDataLib\
                                                SeedImages\Flambuoyant.jpg")),
                    LengthInFeet=15,
                    Make="Pirate Ship",
                    Year="2010",
                    Record="100-0 will win all the races",
                    CreationDate=DateTime.Parse("2016-01-07"),
                    ApplicationUserId=(new ApplicationDbContext()).Users.Find("a@a.c").Email,
                    CreatedBy="admin"
                }
            };

            return Boats;
        }
    }
}