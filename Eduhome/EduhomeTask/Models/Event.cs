﻿using System;

namespace EduhomeTask.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
      
        public string Place { get; set; }

        public string Image { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
