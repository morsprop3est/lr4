using DAL.DAL.Entities;
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.BLL.DTO
{
    public class SensorDTO
    {
        public int SensorId { get; set; }
        public EnumDataUnit DataUnit { get; set; }
    }
}