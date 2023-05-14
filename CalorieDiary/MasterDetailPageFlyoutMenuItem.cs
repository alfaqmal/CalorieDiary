using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieDiary
{
    public class MasterDetailPageFlyoutMenuItem
    {
        public MasterDetailPageFlyoutMenuItem()
        {
            TargetType = typeof(MasterDetailPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}