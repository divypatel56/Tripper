using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tripper
{
    public class Places
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public string imgSource { get; set; }

        
    }
}
