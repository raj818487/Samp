using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.Features
{
    public class CreateEntityHandler : IFeature
    {
        public void Create()
        {
            Common.Create(Path.Combine(CodeGenConstants.FeaturesFolder, CodeGenConstants.EntityName)
                , "Create" + CodeGenConstants.EntityName + "Handler.cs",
                @"Features\CreateEntityHandler.txt");
        }

    }
}
