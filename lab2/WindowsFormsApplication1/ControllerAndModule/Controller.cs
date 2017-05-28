using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControllerAndModule
{
    public  class Controller
    {
        public  string ProcessFilePath(string path)
        {
            if (path != null)
            {
                return path;
            }
            else
            {
                return null;
            }
        }

        public  string ProcessText(Stream s)
        {
            var reader = new StreamReader(s);
            string text = reader.ReadToEnd();
            reader.Close();
            s.Close();
            return text;
        }

        public  void ProcessWriteText(Stream s, string text)
        {
            var writer = new StreamWriter(s);
            writer.Write(text);
            writer.Close();
        }
    }
}
