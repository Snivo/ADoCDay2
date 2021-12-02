using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class SubPilotPt1
    {
        public int Forward { get; private set; }
        public int Depth { get; private set; }

        public void NextInstruction(string instruction, int value)
        {
            switch(instruction)
            {
                case "forward":
                    Forward += value;
                    break;

                case "down":
                    Depth += value;
                    break;

                case "up":
                    Depth -= value;
                    break;
            }
        }
    }
}
