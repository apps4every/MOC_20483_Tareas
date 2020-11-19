using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthCoffee.LogProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO uesr need to change directory 
            var logLocator = new LogLocator(@"D:\IFCD38\practicas\MOC_20483_Tareas\Tarea_3_Demo_Mod_6_Ejercicio_1\Data\Logs\");
            var logCombiner = new LogCombiner(logLocator);

            logCombiner.CombineLogs(@"D:\IFCD38\practicas\MOC_20483_Tareas\Tarea_3_Demo_Mod_6_Ejercicio_1\Data\Logs\CombinedLog.txt");

        }
    }
}
