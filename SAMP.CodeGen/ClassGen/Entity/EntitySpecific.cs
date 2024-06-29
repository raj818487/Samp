using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.Entity
{
    public class EntitySpecific
    {

        public static bool GenerateCode(string entityName)
        {
            string code = $@"
using SAMP.Domain.Entities;

namespace SAMP.Domain.Custom;
public class {entityName}Specific
{{
    public {entityName} {entityName} {{ get; set; }}
    public string[] Fields {{ get; set; }}
}}
";
            string dirpath = CodeGenConstants.DomainCustomFolder;
            if (!Directory.Exists(dirpath))
                Directory.CreateDirectory(dirpath);
            string filePath = Path.Combine(dirpath, $"{entityName}Specific.cs");
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, code);
            return true;
        }
    }
}
