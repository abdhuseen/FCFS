using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    class Process
    {
        int burstTime;
        public int BurstTime {
            get { 
                return burstTime;
            }
            set 
            { burstTime = value; 
            } 
        }
    }
}
