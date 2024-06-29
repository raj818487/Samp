using SAMP.CodeGen.Constants;

namespace SAMP.CodeGen.ClassGen.WebApi
{
    public class EndpointCodeGen(string entityName)
    {
        public bool Generate()
        {
            foreach (EndpointType endpoint in Enum.GetValues(typeof(EndpointType)))
            {
                GenereateEndpointFile(endpoint);
            }
            return true;
        }

        private void GenereateEndpointFile(EndpointType endpointType)
        {
            string filename = $"{endpointType}.cs";
            string content = string.Empty;
            switch (endpointType)
            {
                case EndpointType.Add:
                    content = GenerateAddEndpointCode();
                    break;
                case EndpointType.List:
                    content = GenerateListEndpointCode();
                    break;
                case EndpointType.FilterList:
                    content = GenerateFilterListEndpointCode();
                    break;
                case EndpointType.Update:
                    content = GenerateUpdateEndpointCode();
                    break;
                case EndpointType.UpdateSpecific:
                    content = GenerateUpdateSpecificEndpointCode();
                    break;
                default:
                    break;
            }
            string dirpath = Path.Combine(CodeGenConstants.EndPointsFolder, $"{entityName}Endpoints");
            if (!Directory.Exists(dirpath))
                Directory.CreateDirectory(dirpath);
            string filePath = Path.Combine(dirpath, filename);
            if (File.Exists(filePath))
                File.Delete(filePath);
            File.WriteAllText(filePath, content);
        }
        private static string Namespaces => @"using Ardalis.ApiEndpoints;
using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;";

        private string GenerateAddEndpointCode()
        {
            return $@"{Namespaces}

namespace SAMP.WebAPI.Endpoints.{entityName}Endpoints;

public class Add(I{entityName}Service {entityName.ToLower()}Service) : EndpointBaseAsync
    .WithRequest<{entityName}>
    .WithResult<Result<{entityName}>>
{{
    private readonly I{entityName}Service _{entityName.ToLower()}Service = {entityName.ToLower()}Service;

    /// <summary>
    /// Add {entityName}
    /// </summary>
    [HttpPost(""api/{entityName}/add"")]
    [SwaggerOperation(Summary = ""Add {entityName.ToLower()}"", Description = """", OperationId = ""{entityName}.Add"", Tags = [""{entityName}""])]
    public override async Task<Result<{entityName}>> HandleAsync({entityName} {entityName.ToLower()},CancellationToken cancellationToken)
    {{
        var result = await _{entityName.ToLower()}Service.Add({entityName.ToLower()}, cancellationToken);
        return result;
    }}
}}";
        }
        private string GenerateFilterListEndpointCode()
        {
            return $@"{Namespaces}

namespace SAMP.WebAPI.Endpoints.{entityName}Endpoints;

public class FilterList(I{entityName}Service {entityName.ToLower()}Service) : EndpointBaseAsync
    .WithRequest<QueryParameters<{entityName}>>
    .WithResult<Result<IEnumerable<{entityName}>>>
{{
    private readonly I{entityName}Service _{entityName.ToLower()}Service = {entityName.ToLower()}Service;

    /// <summary>
    /// List all {entityName}s
    /// </summary>
    [HttpPost(""api/{entityName}/filterlist"")]
    [SwaggerOperation(Summary = ""filter {entityName.ToLower()}s"", Description = """", OperationId = ""{entityName}.FilterList"", Tags = [""{entityName}""])]
    public override async Task<Result<IEnumerable<{entityName}>>> HandleAsync(QueryParameters<{entityName}> parameters, CancellationToken cancellationToken)
    {{
        var result = await _{entityName.ToLower()}Service.GetFilterList(parameters, cancellationToken);
        return result;
    }}
}}";
        }
        private string GenerateListEndpointCode()
        {
            return $@"{Namespaces}

 namespace SAMP.WebAPI.Endpoints.{entityName}Endpoints;
 
 public class List(I{entityName}Service {entityName.ToLower()}Service) : EndpointBaseAsync
     .WithoutRequest
     .WithResult<Result<IEnumerable<{entityName}>>>
 {{
     private readonly I{entityName}Service _{entityName.ToLower()}Service = {entityName.ToLower()}Service;
 
     /// <summary>
     /// List all {entityName}s
     /// </summary>
     [HttpGet(""api/{entityName}/list"")]
     [SwaggerOperation(Summary = ""List all {entityName.ToLower()}s"", Description = """", OperationId = ""{entityName}.List"", Tags = [""{entityName}""])]
     public override async Task<Result<IEnumerable<{entityName}>>> HandleAsync(CancellationToken cancellationToken)
     {{
         var result = await _{entityName.ToLower()}Service.GetAll(cancellationToken);
         return result;
     }}
 }}";
        }
        private string GenerateUpdateEndpointCode()
        {
            return $@"{Namespaces}

namespace SAMP.WebAPI.Endpoints.{entityName}Endpoints;

public class Update(I{entityName}Service {entityName.ToLower()}Service) : EndpointBaseAsync
    .WithRequest<{entityName}>
    .WithResult<Result<{entityName}>>
{{
    private readonly I{entityName}Service _{entityName.ToLower()}Service = {entityName.ToLower()}Service;

    /// <summary>
    /// Update {entityName}
    /// </summary>
    [HttpPost(""api/{entityName}/update"")]
    [SwaggerOperation(Summary = ""Update {entityName.ToLower()}"", Description = """", OperationId = ""{entityName}.Update"", Tags = [""{entityName}""])]
    public override async Task<Result<{entityName}>> HandleAsync({entityName} {entityName.ToLower()}, CancellationToken cancellationToken)
    {{
        var result = await _{entityName.ToLower()}Service.Update({entityName.ToLower()}, cancellationToken);
        return result;
    }}
}}";
        }
        private string GenerateUpdateSpecificEndpointCode()
        {
            return $@"{Namespaces}
using SAMP.Domain.Custom;

namespace SAMP.WebAPI.Endpoints.{entityName}Endpoints;

public class UpdateSpecific(I{entityName}Service {entityName.ToLower()}Service) : EndpointBaseAsync
    .WithRequest<{entityName}Specific>
    .WithResult<Result<{entityName}>>
{{
    private readonly I{entityName}Service _{entityName.ToLower()}Service = {entityName.ToLower()}Service;

    /// <summary>
    /// Update {entityName}
    /// </summary>
    [HttpPost(""api/{entityName}/updatespecific"")]
    [SwaggerOperation(Summary = ""Update specific fields of {entityName.ToLower()}"", Description = """", OperationId = ""{entityName}.UpdateSpecific"", Tags = [""{entityName}""])]
    public override async Task<Result<{entityName}>> HandleAsync({entityName}Specific {entityName.ToLower()}, CancellationToken cancellationToken)
    {{
        var result = await _{entityName.ToLower()}Service.UpdateSpecificFields({entityName.ToLower()}.{entityName}.Id, {entityName.ToLower()}.{entityName}, cancellationToken, {entityName.ToLower()}.Fields);
        return result;
    }}
}}";
        }
    }

    public enum EndpointType
    {
        Add = 1,
        List = 2,
        FilterList = 3,
        Update = 4,
        UpdateSpecific = 5
    }
}