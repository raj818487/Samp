using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.Features
{
    public class CreateEntityResponse : IFeature
    {
        public void Create()
        {
            Common.Create(Path.Combine(CodeGenConstants.FeaturesFolder, CodeGenConstants.EntityName),
                "Create" + CodeGenConstants.EntityName + "Response.cs",
                @"Features\CreateEntityResponse.txt");
        }
      
    }
}
