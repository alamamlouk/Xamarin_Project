using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_Project.Views.Shop
{
    public class Mall_itemsFlyoutMenuItem
    {
        public Mall_itemsFlyoutMenuItem()
        {
            TargetType = typeof(Mall_itemsFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}