using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Testing_Logfiles
{
    public class Program
    {
       // static string path = @"C:\Users\Pelle\source\repos\Testing_Logfiles\Testing_Logfiles\LogFiles\logfil_to_read.txt";
        static string path = @"C:\Users\Pelle\Desktop\logfil4";
        static StringSplitter stringSplitter = new StringSplitter();
        static LogReader reader = new LogReader();
        static List<SensorData> list = new List<SensorData>();
        static string[] linesfromlog = reader.LogToStringArray(path);

        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Users\Pelle\Desktop\";
            watcher.Changed += OnChanged;           
            watcher.EnableRaisingEvents = true;

            foreach (var item in linesfromlog)
            {
                string[] ItemArray = stringSplitter.SeperateString(item);
                SensorData sensorData = new SensorData(ItemArray[0], ItemArray[1], ItemArray[2], ItemArray[3], ItemArray[4], ItemArray[5], ItemArray[6], ItemArray[7]);
                list.Add(sensorData);               
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            StreamReader reader = new StreamReader(path);
            AddItemsTolist(list.Last<SensorData>().Tid, reader);
            reader.Close();
        }

        public static void AddItemsTolist(string lastItemAdded, StreamReader reader)
        {       
           
            IEnumerable<string> list = reader.ReadUntil(lastItemAdded);         



            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
           
        }

        
    }
}
