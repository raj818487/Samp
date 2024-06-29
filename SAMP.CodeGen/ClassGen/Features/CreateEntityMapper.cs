using SAMP.CodeGen.Constants;
using System.Configuration;

namespace SAMP.CodeGen.ClassGen.Features
{
    public class CreateEntityMapper : IFeature
    {
        public void Create()
        {
            Common.Create(Path.Combine(CodeGenConstants.FeaturesFolder, CodeGenConstants.EntityName)
                , "Create" + CodeGenConstants.EntityName + "Mapper.cs",
                @"Features\CreateEntityMapper.txt");
        }

    }
}
