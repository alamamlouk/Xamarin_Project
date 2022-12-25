using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Xamarin_Project.Modal
{
    public class User
    {
      
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        [NotNull, MaxLength(20)]
        public String Name { get; set; }
        [NotNull]
        public String Username { get; set; }
        [NotNull]
        public String Password {get;set;}

    }
}
