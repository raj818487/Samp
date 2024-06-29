using SAMP.CodeGen.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMP.CodeGen.ClassGen
{
    public class Common
    {
        static string GetTemplate(string templateFileName)
        {
            string input = string.Empty;
            var template = Path.Combine(CodeGenConstants.TemplateFolder, templateFileName);
            using (StreamReader reader = new(template))
            {
                input = reader.ReadToEnd();
                reader.Close();
            }
            return input;
        }

        public static void Create(string toFolder, string toFileName, string templateFileName)
        {
            Console.WriteLine("Create start");
            if (!Directory.Exists(toFolder))
            {
                Directory.CreateDirectory(toFolder);
            }
            string sDestinationFullFileName = Path.Combine(toFolder, toFileName);
            string sDestClassTemplate = GetTemplate(templateFileName);
            sDestClassTemplate = sDestClassTemplate.Replace("<Entity>", CodeGenConstants.EntityName);
            File.WriteAllText(sDestinationFullFileName, sDestClassTemplate);
            Console.WriteLine("File added : " + sDestinationFullFileName);
        }
    }
}
