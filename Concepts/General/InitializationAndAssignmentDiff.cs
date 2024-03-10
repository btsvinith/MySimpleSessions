using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.General
{
    public class InitializationAndAssignmentDiff
    {
        int x;//Declared x but not initialized
        int y = 1;//Declared y and initialized here

        public InitializationAndAssignmentDiff()
        {
            x = 1;//strictly speaking, not initialization, just assignment.
            y = 2;//was obviously initialized above, just assignment.
        }
    }
}
