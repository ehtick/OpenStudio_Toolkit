﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using BH.oM.Reflection.Attributes;
using BH.oM.OpenStudio;
using BH.Engine.Base;

namespace BH.Engine.OpenStudio
{
    //public static partial class Create
    //{
    //    [Description("BH.Engine.EnergyPlus.Create OutputVariable =>Variable command picks variables to be put onto the standard output file (.eso) Some variables may not be reported for every simulation a list of variables that can be reported are available after a run on the report dictionary file(.rdd) if the Output: VariableDictionary has been requested.")]
    //    [Input("keyValue", "KeyValue")]
    //    [Input("variableName", "VariableName")]
    //    [Input("reportingFrequency", "Detailed lists every instance (i.e. HVAC variable timesteps) Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod and Environment are the same")]
    //    [Input("scheduleName", "ScheduleName")]
    //    [Output("outputVariable", "A BH.oM.EnergyPlus.OutputVariable object")]

    //    public static OutputVariable OutputVariable(
    //        string keyValue="*",
    //        string variableName = "Site Outdoor Air Drybulb Temperature",
    //        OutputVariableReportingFrequencyType reportingFrequency = OutputVariableReportingFrequencyType.Hourly,
    //        string scheduleName = "System Availability Schedule"
    //    )
    //    {
    //        if (reportingFrequency==OutputVariableReportingFrequencyType.Undefined)
    //        {
    //            BH.Engine.Reflection.Compute.RecordError("OutputVariableReportingFrequencyType cannot be undefined");
    //            return null;
    //        }

    //        return new OutputVariable
    //        {
    //            KeyValue = keyValue,
    //            VariableName = variableName,
    //            ReportingFrequency =reportingFrequency,
    //            ScheduleName=scheduleName,
    //        };
    //    }
    //}
}