using System;
using MongoDB.Driver.GeoJsonObjectModel;

namespace api_dio_mongodb.Data.Collections
{
    public class Infected
    {
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public GeoJson2DGeographicCoordinates Localization { get; set; }
        public Infected(DateTime birthDate, string gender, double latitude, double longitude)
        {
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Localization = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

    }
}