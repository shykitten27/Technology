using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class AbstractEntity
    {
        public int DeviceId { get; }
        public static int NextId = 1; //set a field not a property

        public AbstractEntity() //empty constructor
        {
            DeviceId = NextId; //defaulted as 1 - set the property to the field value
            NextId++; //increment NextId for the next entity that is created
        }
    }
}