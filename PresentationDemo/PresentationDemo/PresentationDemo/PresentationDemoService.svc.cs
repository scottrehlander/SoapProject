using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace PresentationDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PresentationDemoService" in code, svc and config file together.
    public class PresentationDemoService : IPresentationDemoService
    {
        public string GetTeacherName()
        {
            return "Suban Krishnamoorthy";
        }

        public bool PostComment(string comment)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\inetpub\wwwroot\PresentationDemo\PresentationDemo\PresentationDemo\comments.txt", true))
                {
                    sw.WriteLine(comment);
                }
            }
            catch { return false; }

            return true;
        }

        public string[] GetComments()
        {
            List<string> comments = new List<string>();
            using (StreamReader sr = new StreamReader(@"C:\inetpub\wwwroot\PresentationDemo\PresentationDemo\PresentationDemo\comments.txt"))
            {
                while(!sr.EndOfStream)
                    comments.Add(sr.ReadLine());
            }

            return comments.ToArray<string>();
        }
    }
}
