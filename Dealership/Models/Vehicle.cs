using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;
using System.Collections;

namespace Dealership.Models
{
    public abstract class Vehicle :Constants, IVehicle
    {
        
        private string make;
        private string model;
        private decimal price;
        private int wheels;
        private IList<IComment> comments;
        private VehicleType vehicleType ;

        public Vehicle(string make, string model, VehicleType vehicleType, decimal price)
        {
            this.Make = make;
            this.Comments = new List<IComment>();
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            set
            {
                Validator.ValidateNull(value, "Error");
            }
        }

        public string Make
        {
            get
            {
                return this.make;
            }
           private set
            {
                Validator.ValidateNull(value, "");
                Validator.ValidateIntRange(value.Length,Constants. MinMakeLength,Constants. MaxMakeLength,string.Format(Constants.MinMakeLength,Constants.MaxMakeLength,StringMustBeBetweenMinAndMax);


            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
          private  set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Make length not correct!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(price<MinPrice && value>MaxPrice )
                {
                    throw new ArgumentException("Price!");
                }
                this.price = value;
            }
        }

        public abstract int Wheels { get; }
        

        public  VehicleType Type
       
            { get; set; }
        
    }
}
