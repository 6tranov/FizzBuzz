using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp27
{
    class TestSavePrint : IPrint
    {
        private string SavePath { get; set; }
        public TestSavePrint(string savePath)
        {
            this.SavePath = savePath;
        }
        public void Print(List<string> result)
        {
            using (var sw = new StreamWriter(SavePath))
            {
                foreach (var item in result)
                {
                    sw.Write(item);
                }
            }
        }
    }
}
