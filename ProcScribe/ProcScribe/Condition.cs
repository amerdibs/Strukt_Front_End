﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProcScribe
{
    public class Condition
    {
        public List<Condition.AlternativeCondition_set> alternateList;
        public List<Condition.OptionalCondition_set> optionalList;
        public List<Condition.Precondtion_set> preconditionList;
        public List<Condition.ResourceCondition_set> resourceconditionList;
        public List<Condition.RoleCondition_set> roleList;

        public static Condition getConditionByTaskID(string strTaskID)
        {
            try
            {
                Condition retunCondition = new Condition();
                retunCondition.alternateList = Condition.AlternativeCondition_set.getAlternativeCondition_setByTaskID(strTaskID);
                retunCondition.optionalList = Condition.OptionalCondition_set.getOptionalCondition_setByTaskID(strTaskID);
                retunCondition.preconditionList = Condition.Precondtion_set.getPrecondtion_setsByTaskID(strTaskID);
                retunCondition.resourceconditionList = Condition.ResourceCondition_set.getResourceCondition_setByTaskID(strTaskID);
                retunCondition.roleList = Condition.RoleCondition_set.getRoleCondition_setByTaskID(strTaskID);
                return retunCondition;


            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }
        public class AlternativeCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string alternativecontion_id { get; set; }

            public static List<AlternativeCondition_set> getAlternativeCondition_setByTaskID(string strTaskID)
            {
                try
                {
                    string strResourceSet = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Alternatecondition_set, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strResourceSet == "")
                        return null;

                    List<AlternativeCondition_set> alternateCondtion_set = JsonConvert.DeserializeObject<List<AlternativeCondition_set>>(strResourceSet);
                    return alternateCondtion_set;
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }

            internal static List<AlternativeCondition_set> getAlternativeCondition_setByTaskID()
            {
                throw new NotImplementedException();
            }
        }

        public class Contributor_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string contributor_id { get; set; }
        }

        public class OptionalCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string value_id { get; set; }

            public static List<OptionalCondition_set> getOptionalCondition_setByTaskID(string strTaskID)
            {
                try
                {
                    string strOptionalSet = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Optionalcondition, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strOptionalSet == "")
                        return null;

                    List<OptionalCondition_set> optionalCondtion_set = JsonConvert.DeserializeObject<List<OptionalCondition_set>>(strOptionalSet);
                    return optionalCondtion_set;
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }
        }

        public class Precondtion_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string precondition_id { get; set; }

            public static List<Precondtion_set> getPrecondtion_setsByTaskID(string strTaskID)
            {
                try
                {
                    string strSect = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Precondition_set, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strSect == "")
                        return null;

                    List<Precondtion_set> precondtion_set = JsonConvert.DeserializeObject<List<Precondtion_set>>(strSect);
                    return precondtion_set;
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }
        }

        public class Resource_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string resourcce_id { get; set; }
        }

        public class ResourceCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string resourceCondition_id { get; set; }

            public static List<ResourceCondition_set> getResourceCondition_setByTaskID(string strTaskID)
            {
                try
                {
                    string strResourceSet = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Resourcecondition, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strResourceSet == "")
                        return null;

                    List<ResourceCondition_set> resourceCondtion_set = JsonConvert.DeserializeObject<List<ResourceCondition_set>>(strResourceSet);
                    return resourceCondtion_set;
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }
        }

        public class Role_set
        {
            public string id { get; set; }
            public string user_id { get; set; }
            public string role_id { get; set; }
        }

        public class RoleCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string roleCondition_id { get; set; }

            public static List<RoleCondition_set> getRoleCondition_setByTaskID(string strTaskID)
            {
                try
                {
                    string strRoleSet = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Rolecondition, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strRoleSet == "")
                        return null;

                    List<RoleCondition_set> roleCondtion_set = JsonConvert.DeserializeObject<List<RoleCondition_set>>(strRoleSet);
                    return roleCondtion_set;
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }
        }

        public class Tools_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string tool_id { get; set; }
        }
    }
}
