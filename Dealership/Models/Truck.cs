using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, VehicleType vehicleType, decimal price,int weightCapacity) : base(make, model, vehicleType, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }
            set
            {
                if (value < MinCapacity && value > MaxCapacity)
                {
                    throw new ArgumentException("Wight capacity");

                }
                this.weightCapacity = value;
            }
        }
        public override int Wheels
        {
            get
            {
                return (int)VehicleType.Truck;
            }

        }

    }
}
