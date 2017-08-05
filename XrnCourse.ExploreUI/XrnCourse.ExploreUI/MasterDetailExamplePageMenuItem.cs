using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XrnCourse.ExploreUI
{

    public class MasterDetailExamplePageMenuItem
    {
        public MasterDetailExamplePageMenuItem()
        {
            TargetType = typeof(MasterDetailExamplePageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool ShowButton { get; set; }

        public Type TargetType { get; set; }
    }
}