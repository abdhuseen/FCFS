using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    class Program
    {
        static double averageWaitingTime(Process[]processes)
        {
            double average;
            int sum = 0;
            if(processes.Length>1)
            {
                GanntChart g = new GanntChart();
                g.Create(processes);
                for(int i=0;i<g.getGanntChart().Count-1;i++)
                {
                    sum += g.getGanntChart().ElementAt<int>(i);
                }
                average = sum / processes.Length;
                Console.WriteLine("Total Waiting Time = " + sum);
            }
            else
            {
                average = -1;
            }
            return average;
        }
        static double AverageTurnaroundTime(Process[]processes)
        {
            double average;
            int sum = 0;
            if (processes.Length > 1)
            {
                GanntChart g = new GanntChart();
                g.Create(processes);
                for (int i = 0; i < g.getGanntChart().Count; i++)
                {
                    sum += g.getGanntChart().ElementAt<int>(i);
                }
                average = sum / processes.Length;
                Console.WriteLine("Total TurnAround Time = "+sum);
            }
            else
            {
                average = -1;
            }
            return average;
        }
        static void WaitingTimeForEachProcess(Process[] processes)
        {
            Console.WriteLine("WaitingTimeForEachProcess");
            Console.WriteLine("-------------------------------------------");
            if (processes.Length > 1)
            {
                Console.Write("process \twaiting time (ms)");
                Console.WriteLine();
                GanntChart g = new GanntChart();
                g.Create(processes);
                int p = 0; 
                for(int i = 0; i < g.getGanntChart().Count - 1; i++)
                {
                  Console.WriteLine("p"+(p+1)+"\t \t"+ g.getGanntChart().ElementAt<int>(i));
                    p++;
                }
                
            }
          
            
        }
        static void TurnaroundTimeForEachProcess(Process[] processes)
        {
            Console.WriteLine("TurnaroundTimeForEachProcess");
            Console.WriteLine("-------------------------------------------");
            if (processes.Length > 1)
            {
                Console.Write("process \tTurnaround time (ms)");
                Console.WriteLine();
                GanntChart g = new GanntChart();
                g.Create(processes);
                int p = 0;
                for (int i =0; i < g.getGanntChart().Count-1; i++)
                {
                    Console.WriteLine("p" + (p + 1) + "\t \t" + g.getGanntChart().ElementAt<int>(i+1));
                    p++;
                }
            }
        }
        static void getData(Process[]processes)
        {
            WaitingTimeForEachProcess(processes);
            Console.WriteLine();
            TurnaroundTimeForEachProcess(processes);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("averageWaitingTime = " + averageWaitingTime(processes) + " ms");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("averageTurnaroundTime = " + AverageTurnaroundTime(processes) + " ms");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Notes");
            Console.WriteLine("1-TotalWaitingTime=SummationOFWaitingTimeForEachProcess");
            Console.WriteLine("2-AverageWaitingTime=TotalWaitingTime / NumberOfProcess");
            Console.WriteLine("3-TotalTurnAroundTime=SummationOFTurnAroundTimeForEachProcess");
            Console.WriteLine("4-AverageTurnAroundTime=TotalTurnAroundTime / NumberOfProcess");

        }
        static void Main(string[] args)
        {
            int numberOfProcess;
            int burstTime;
            Process[] processes;
            Console.WriteLine("Enter Number Of Process");
            numberOfProcess = int.Parse(Console.ReadLine());
            processes = new Process[numberOfProcess];
            for (int i=0;i<numberOfProcess;i++)
            {
                Console.WriteLine("Enter Burst Time of process "+(i+1));
                burstTime = int.Parse(Console.ReadLine());
                Process p = new Process();
                p.BurstTime = burstTime;
                processes[i] = p;
            }
            getData(processes);
        }
    }
}
