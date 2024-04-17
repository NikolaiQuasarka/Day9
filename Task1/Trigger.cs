using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Trigger
    {
        public int Id { get; set; }
        public bool[] Inputs { get; set; }
        public bool[] Outputs { get; set; }

        public abstract void Reset();
        public abstract void Set(params bool[] inputs);
    }

    public class RS : Trigger
    {
        public RS()
        {
            Inputs = new bool[3];
            Outputs = new bool[2];
        }

        public override void Reset()
        {
            Outputs[0] = Outputs[1] = false;
        }

        public override void Set(params bool[] inputs)
        {
            if (inputs.Length != 3)
                throw new ArgumentException("RS trigger requires 3 inputs.");

            Inputs = inputs;
            Outputs[0] = Inputs[0] && !Inputs[1];
            Outputs[1] = !Inputs[0] && Inputs[1];
        }
    }

    public class JK : Trigger
    {
        public JK()
        {
            Inputs = new bool[3];
            Outputs = new bool[2];
        }

        public override void Reset()
        {
            Outputs[0] = Outputs[1] = false;
        }

        public override void Set(params bool[] inputs)
        {
            if (inputs.Length != 3)
                throw new ArgumentException("JK trigger requires 3 inputs.");

            Inputs = inputs;
            if (Inputs[2]) // T input
            {
                Outputs[0] = Inputs[0] && !Outputs[1];
                Outputs[1] = Inputs[1] && !Outputs[0];
            }
        }
    }
}
