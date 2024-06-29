using SAMP.CodeGen.ClassGen.Entity;
using SAMP.CodeGen.ClassGen.Services;
using SAMP.CodeGen.ClassGen.WebApi;

namespace SAMP.CodeGen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Old code
            /*IFeature feature = new CreateEntityHandler();
               feature.Create();
               feature = new CreateEntityMapper();
               feature.Create();
               feature = new CreateEntityValidator();
               feature.Create();
               feature = new CreateEntityRequest();
               feature.Create();
               feature = new CreateEntityResponse();
               feature.Create();
               feature = new EntityService();
               feature.Create();*/
            #endregion

            //Change entity here to generate code
            GenerateCode("AccReq");
        }

        private static bool GenerateCode(string entityName)
        {
            EndpointCodeGen endpointCodeGen = new(entityName);
            endpointCodeGen.Generate();
            EntityService.GenerateCode(entityName);
            EntitySpecific.GenerateCode(entityName);
            return true;
        }
    }
}