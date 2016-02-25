using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace GameCore
{
    public class Log : ILog
    {
        string logFile = @".\log.json";
        Result[] table = new Result[11];        
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Result[]));
        public void WriteFile()
        {
            using (FileStream fs = new FileStream(logFile, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, table);
            }
        }
        public Result[] ReadFile()
        {
            if (File.Exists(logFile))
            {
                using (FileStream fs = new FileStream(logFile, FileMode.Open))
                {
                    return table = (Result[])jsonFormatter.ReadObject(fs);
                }
            }
            else
            {
                for (int i = 0; i < table.Length; i++)
                {
                    table[i] = new Result("Empty", 0);
                }
                WriteFile();
            }
            return table;
        }
        public void AddChampion(string name, int hp)
        {
            int k = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i].Name == name)
                {
                    k = 1;
                    if (table[i].Hp < hp)
                    {
                        table[i].Name = name;
                        table[i].Hp = hp;                        
                    }
                }
            }
            if (k == 0)
            {
                table[10].Name = name;
                table[10].Hp = hp;                
            }
            File.Delete(logFile);
            Array.Sort(table);
            WriteFile();
        }
    }
}
