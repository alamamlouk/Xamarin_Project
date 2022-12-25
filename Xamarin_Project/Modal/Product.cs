using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xamarin_Project.Modal
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [NotNull]
        public string Name { get; set; }
        [NotNull]
        public float Price { get; set; }
        public Categories categories { get; set; }

    }
}
