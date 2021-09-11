using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Entities.Models
{
    public static class ListBuilder
    {
        private static string[] NextLine(StreamReader reader)
        {
            string[] line = reader.ReadLine().Split(' ');
            return line;
        }
    }
}
