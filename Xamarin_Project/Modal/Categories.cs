using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xamarin_Project.Modal
{
    public class Categories
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public string Name { get; set; }

    }
}
