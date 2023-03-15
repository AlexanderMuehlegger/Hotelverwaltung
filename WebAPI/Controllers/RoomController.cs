using Hotel;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebAPI.Models.DB;

namespace WebAPI.Controllers {
    [ApiController]
    [Route("api/rooms")]
    public class RoomController : Controller {

        private HotelContext _context;

        public RoomController(HotelContext context) {
            this._context = context;

            if (this._context.Rooms.Count() != 0)
                return;

            Room singleRoom = new Room {
                number = 101,
                numBed = 1,
                hasKitchen = false,
                hasBalcony = true,
                hasTerrace = false,
                nightPrice = 100.00m,
                available = true
            };

            Room doubleRoom = new Room {
                number = 201,
                numBed = 2,
                hasKitchen = true,
                hasBalcony = true,
                hasTerrace = true,
                nightPrice = 150.00m,
                available = true
            };

            Room familyRoom = new Room {
                number = 301,
                numBed = 3,
                hasKitchen = true,
                hasBalcony = false,
                hasTerrace = false,
                nightPrice = 200.00m,
                available = false
            };

            Room suite = new Room {
                number = 401,
                numBed = 2,
                hasKitchen = true,
                hasBalcony = true,
                hasTerrace = true,
                nightPrice = 300.00m,
                available = true
            };

            Room singleRoomNoBalcony = new Room {
                number = 501,
                numBed = 1,
                hasKitchen = false,
                hasBalcony = false,
                hasTerrace = false,
                nightPrice = 75.00m,
                available = false
            };

            this._context.Add(singleRoom);
            this._context.Add(familyRoom);
            this._context.Add(suite);
            this._context.Add(singleRoomNoBalcony);
            this._context.SaveChanges();
        }

        [HttpGet]
        [Route("all")]
        public async Task<string> GetAllLists() {
            var rooms = this._context.Rooms.ToList();

            return JsonSerializer.Serialize(rooms);
        }
    }
}
   