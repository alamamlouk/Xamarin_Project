using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_Project.Views.Admin
{
    public class AdminFlyoutMenuItem
    {
        public AdminFlyoutMenuItem()
        {
            TargetType = typeof(AdminFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}