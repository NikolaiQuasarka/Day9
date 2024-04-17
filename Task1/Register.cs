using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Register
    {
        public List<Trigger> Triggers { get; }

        public Register()
        {
            Triggers = new List<Trigger>();
        }

        public void AddTrigger(Trigger trigger)
        {
            trigger.Id=Triggers.Count;
            Triggers.Add(trigger);
        }

        public void ResetAll()
        {
            foreach (var trigger in Triggers)
            {
                trigger.Reset();
            }
        }

        public void SetAll(params bool[] inputs)
        {
            if (inputs.Length != 3)
                throw new ArgumentException("SetAll requires 3 inputs.");
            for (int i = 0; i < Triggers.Count; i++)
            {
                Triggers[i].Set(inputs);
            }
        }

        public List<string> PrintTriggers()
        {
            List<string> trinfo = new List<string>(); 
            foreach (var trigger in Triggers)
            {
                trinfo.Add($"Id: {trigger.Id}, Inputs: {string.Join(", ", trigger.Inputs)}, Outputs: {string.Join(", ", trigger.Outputs)}");
            }
            return trinfo;
        }
    }
}
