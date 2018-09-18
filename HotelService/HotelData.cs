﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelService
{
    [DataContract]
    class HotelData
    {
        [DataMember]
        public int HotelId;
        [DataMember]
        public string HotelName;
        [DataMember]
        public string HotelAddress;
        [DataMember]
        public int StarRating;
        [DataMember]
        public int HotelPrice;

    }
}
