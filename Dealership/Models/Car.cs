using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    //stable one
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, VehicleType vehicleType, decimal price,int Seats) : base(make, model, vehicleType, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
           private set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats, string.Format(Constants.NumberMustBeBetweenMinAndMax, nameof(this.Seats), Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }
        public override int Wheels
        {
            get
            {
                return (int)VehicleType.car;
            }

        }
    }
}
