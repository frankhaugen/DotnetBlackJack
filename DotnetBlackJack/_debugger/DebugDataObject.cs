using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace DotnetBlackJack._debugger
{
    public class DebugDataObject
    {
        public void DisplayDataAsJson(object dataObject)
        {
            Console.WriteLine(JsonConvert.SerializeObject(dataObject, Formatting.Indented));
        }

        public void WriteDataTraceAsJson(object dataObject)
        {
            Trace.WriteLine(JsonConvert.SerializeObject(dataObject, Formatting.Indented));
        }
    }
}
