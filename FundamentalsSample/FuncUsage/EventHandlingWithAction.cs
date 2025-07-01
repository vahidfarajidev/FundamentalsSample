using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSample.FuncUsage.EventHandlingWithAction
{
    public class Button
    {
        public event Action<string> Clicked;
        
        public void SimulateClick()
        {
            Clicked?.Invoke("Button1");
        }
    }
}
