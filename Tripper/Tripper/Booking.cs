using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tripper
{
    public class Booking
    {
        [PrimaryKey,AutoIncrement ]
        public int Id { get; set; }
        public string Place { get; set; }
        public string Value { get; set; }
        public string Duration { get; set; }
    }
}
