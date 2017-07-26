using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
   public class Motorcycle  : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, VehicleType vehicleType, decimal price,string category) : base(make, model, vehicleType, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            set
            {
                if(value.Length<MinCategoryLength&&value.Length>MaxCategoryLength)
                {
                    throw new ArgumentException("Category length is incorrect");
                }
                this.category = value;
            }
        }

        public override VehicleType Type
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
