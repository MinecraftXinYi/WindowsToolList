using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsToolList.Models
{
    public class ToolGlobalizationInfo
    {
        public string ToolName { get; set; }
        public string Language { get; set; }
        public static class GlobalizationContent
        {
            public static string ToolDisplayName { get; set; }
            public static string ToolDescription { get; set;}
        }
    }
}
