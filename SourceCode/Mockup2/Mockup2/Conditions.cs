using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup2
{
    class Conditions
    {
        class sets_AlternativeContion_sets
        {
            public int task_id { get; set; }
            public int alternativecontion_id { get; set; }
        }

        class sets_Contributor_sets
        {
            public int task_id { get; set; }
            public int contributor_id { get; set; }
        }

        class sets_OptionalConditoins_sets
        {
            public int task_id { get; set; }
            public int value_id { get; set; }
        }

        class sets_Precondtion_sets
        {
            public int task_id { get; set; }
            public int precondition_id { get; set; }
        }

        class sets_Resource_sets
        {
            public int task_id { get; set; }
            public int resourcce_id { get; set; }
        }

        class sets_ResourceCondition_sets
        {
            public int task_id { get; set; }
            public int resourceCondition_id { get; set; }
        }

        class sets_Role_sets
        {
            public int user_id { get; set; }
            public int role_id { get; set; }
        }

        class sets_roleCondition_sets
        {
            public int task_id { get; set;}
            public int roleCondition_id { get; set; }
        }

        class sets_Tools_sets
        {
            public int task_id { get; set; }
            public int tool_id { get; set; }
        }
    }
}
