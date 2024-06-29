using SAMP.CodeGen.ClassGen.Features;
using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.Services
{
    public class EntityService : IFeature
    {
        public void Create()
        {
            var folder = Path.Combine(CodeGenConstants.ServiceInterfaceFolder, CodeGenConstants.EntityName);
            Common.Create(folder, string.Concat("I", CodeGenConstants.EntityName, "Service.cs"),
                @"Services\IEntityService.txt");

        }
        public static bool GenerateCode(string entityName)
        {
            GenerateServiceInterfaceCode(entityName);
            GenerateServiceCode(entityName);
            return true;
        }
        private static bool GenerateServiceInterfaceCode(string entityName)
        {
            var code = $@"
using SAMP.Domain.Entities;

namespace SAMP.Application.Services;
public interface I{entityName}Service : IServiceBase<{entityName}>;";


            string dirpath = CodeGenConstants.ServiceInterfaceFolder;
            if (!Directory.Exists(dirpath))
                Directory.CreateDirectory(dirpath);
            string filePath = Path.Combine(dirpath, $"I{entityName}Service.cs");
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, code);
            return true;
        }

        private static bool GenerateServiceCode(string entityName)
        {
            string code = $@"
using SAMP.Application.Services;
using SAMP.Domain.Entities;

namespace SAMP.Persistence.Services;
public class {entityName}Service(DataContext _context) : ServiceBase<{entityName}>(_context), I{entityName}Service;";
            string dirpath = CodeGenConstants.PersistenceServicesFolder;
            if (!Directory.Exists(dirpath))
                Directory.CreateDirectory(dirpath);
            string filePath = Path.Combine(dirpath, $"{entityName}Service.cs");
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, code);
            return true;
        }
    }
}
