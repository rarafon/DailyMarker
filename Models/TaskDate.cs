﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMarker.Models
{
    public class TaskDate
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime TDate { get; set; }

        public List<DailyTask_TaskDate> DailyTask_TaskDates { get; set; }
    }
}
