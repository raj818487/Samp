using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.Features
{
    public class CreateEntityValidator : IFeature
    {
        public void Create()
        {
            Common.Create(Path.Combine(CodeGenConstants.FeaturesFolder, CodeGenConstants.EntityName),
                "Create" + CodeGenConstants.EntityName + "Validator.cs",
                @"Features\CreateEntityValidator.txt");
        }

    }
}
