using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace ZegarGit
{
    public class FileClass
    {
        public static string GetFilePath()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "zegargit_file1.txt");
            return filePath;
        }

        public static List<string> ReadData()
        {
            if (File.Exists(GetFilePath()))
            {
                List<string> lines = File.ReadAllLines(GetFilePath()).ToList();
                List<string> timeList = new List<string>();

                foreach (var line in lines)
                {
                    timeList.Add(line);
                }
                return timeList;
            }
            else
            {
                return null;
            }
        }

        public static void WriteToFile(string time)
        {
            using (StreamWriter writer = new StreamWriter(FileClass.GetFilePath(), true))
            {
                writer.WriteLine(time);
            }
        }
    }
}
