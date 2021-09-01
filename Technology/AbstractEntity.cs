using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class AbstractEntity
    {
        public int DeviceId { get; }
        private static int nextId = 1; //set a field not a property

        public AbstractEntity() //empty constructor
        {
            DeviceId = nextId; //defaulted as 1 - set the property to the field value
            nextId++; //increment NextId for the next entity that is created
        }
    }
}