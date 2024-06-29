using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.Features
{
    public class CreateEntityRequest : IFeature
    {
        public void Create()
        {
            Common.Create(Path.Combine(CodeGenConstants.FeaturesFolder, CodeGenConstants.EntityName),
                "Create.Request.cs",
                @"Features\CreateEntityRequest.txt");
        }

    }
}
