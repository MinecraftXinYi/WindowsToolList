using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsToolList.Models
{
    public class WindowsTool
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public int Type {  get; set; }
        public bool UseShellExecute { get; set; }
    }
}
