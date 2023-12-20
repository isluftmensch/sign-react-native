using EaseFlight.Common.Utilities;
using EaseFlight.DAL.Entities;
using System;
using System.Collections.Generic;

namespace EaseFlight.Models.EntityModels
{
    public class AirportModel
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public Nullable<int> CountryID { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<PlaneAirport> PlaneAirports { get; set; }
        #endregion

        #region Functions
        public Airport GetModel()
        {
            var model = new Airport();
            CommonMethods.CopyObjectProperties(this, model);

            return model;
        }
        #endregion
    }
}
