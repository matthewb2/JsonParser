using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace JsonEx
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonEx reader = new JsonEx(@"C:\testjson.json");
            Console.WriteLine(reader.convertarray());
        }
    }

    
  class JsonEx
  {
      private string json;
      private string file;

      public JsonEx(string path)
      {
          this.file = path;
      }

      public string[] convertarray()
       {

           string all;

           string cont;

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(file))
            {
                all = sr.ReadToEnd();
            }


            if (all.Contains("["))
            {

                int pf = all.IndexOf("[");
                int pto = all.LastIndexOf("]");

                cont = all.Substring(pf, pto - pf);


                if (cont.Contains(','))
                {


                    string[] words = cont.Split(',');

                    foreach (var wd in words)
                    {
                        if (wd.Contains(":"))
                        {
                            string[] nm = wd.Split(':');
                            foreach (var ns in nm)
                            {
                                return nm;
                            }
                        }
                    }
                }
            }
            return null;
    } 
   }
}


