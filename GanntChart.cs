using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    class GanntChart
    {
         LinkedList<int> times;
        public void Create(Process[]processes)
        {
            this.times = new LinkedList<int>();
            int j = 0;
            times.AddLast(0);
            for(int i=1;i<processes.Length+1;i++)
            {
                times.AddLast(times.ElementAt<int>(i-1)+processes[j].BurstTime);
                j++;
            }

        }
        public LinkedList<int> getGanntChart()
        {
            return times;
        }
    }
}
