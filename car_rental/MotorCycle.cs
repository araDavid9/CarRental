﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    [Serializable()]
    public class MotorCycle: GasolineVehicle
    {

        public MotorCycle(bool gear, double engine_capacity, int fuel_tank_capacity, double fuel_consumption,
                         double weight, int wheels, string wheel_size,
                          double acceleration, double max_speed, uint manufacturing_year, string color, int amount, string model,string picture)
                          :base(gear,engine_capacity,fuel_tank_capacity,fuel_consumption,weight,wheels,
                               wheel_size,acceleration,max_speed,manufacturing_year,color,amount, model,picture)
        {

        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            
        }
        public MotorCycle(SerializationInfo info, StreamingContext context):base(info, context) //Getting from the saved data
        {
           
        }
    }
}
