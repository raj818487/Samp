using System.Configuration;

namespace SAMP.CodeGen.Constants
{
    public class CodeGenConstants
    {
        public static readonly string ExePath = Directory.GetCurrentDirectory();
        // remove other path from name
        public static readonly string SrcFolder = ExePath.Replace(@"SAMP.CodeGen\bin\Debug\net8.0", "");
        public static readonly string FeaturesFolder = Path.Combine(SrcFolder, @"SAMP.Application", "Features");
        public static readonly string ServiceInterfaceFolder = Path.Combine(SrcFolder, @"SAMP.Application", "Services");
        public static readonly string EndPointsFolder = Path.Combine(SrcFolder, @"SAMP.WebApi", "EndPoints");
        public static readonly string DomainCustomFolder = Path.Combine(SrcFolder, @"SAMP.Domain", "Custom");
        public static readonly string PersistenceServicesFolder = Path.Combine(SrcFolder, @"SAMP.Persistence", "Services");

        public static readonly string TemplateFolder = Path.Combine(CodeGenConstants.SrcFolder, @"SAMP.CodeGen", "Templates");

        //Configs
        public static readonly string EntityName = ConfigurationManager.AppSettings["Entity"];


    }
}
