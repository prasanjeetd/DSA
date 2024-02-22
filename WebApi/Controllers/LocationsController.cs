using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly List<Location> _locations;

        public LocationsController()
        {
            // Initialize the list of locations with different time availabilities
            _locations = new List<Location>
            {
                new Location { Name = "Pharmacy", Availability = new TimeSpan(10, 0, 0), Duration = new TimeSpan(3, 0, 0) },
                new Location { Name = "Bakery", Availability = new TimeSpan(9, 0, 0), Duration = new TimeSpan(4, 0, 0) },
                new Location { Name = "Barber Shop", Availability = new TimeSpan(11, 0, 0), Duration = new TimeSpan(2, 0, 0) },
                new Location { Name = "Supermarket", Availability = new TimeSpan(8, 0, 0), Duration = new TimeSpan(5, 0, 0) },
                new Location { Name = "Candy Store", Availability = new TimeSpan(10, 0, 0), Duration = new TimeSpan(3, 0, 0) },
                new Location { Name = "Cinema Complex", Availability = new TimeSpan(12, 0, 0), Duration = new TimeSpan(2, 0, 0) },
                // Add more locations here
            };
        }

        /*
         * create one more get api which will take input for time and location
         */
        [HttpGet]
        public IActionResult GetLocations()
        {
            // Filter the locations based on availability between 10 am and 1 pm
            var availableLocations = _locations.Where(l => l.Availability >= new TimeSpan(10, 0, 0) && l.Availability.Add(l.Duration) <= new TimeSpan(13, 0, 0));

            return new OkObjectResult(availableLocations);
            if (availableLocations.Any())
            {
                return Ok(availableLocations);
            }
            else
            {
                return NotFound("No locations available between 10 am and 1 pm.");
            }
        }

        /*
         * Get locations based on input time and location
         */
        [HttpGet("{time}/{location}")]
        public IActionResult GetLocationsByTimeAndLocation(TimeSpan time, string location)
        {
            // Filter the locations based on input time and location
            var filteredLocations = _locations.Where(l => l.Availability <= time && l.Availability.Add(l.Duration) >= time && l.Name.ToLower() == location.ToLower());

            if (filteredLocations.Any())
            {
                return Ok(filteredLocations);
            }
            else
            {
                return NotFound($"No locations available at {time} for {location}.");
            }
        }
    }

    public class Location
    {
        public string Name { get; set; }
        public TimeSpan Availability { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
