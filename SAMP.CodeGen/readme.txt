Code Generator is updated as per the current architecture. It creates code files in following 

1. SAMP.Domain.Custom
{Entity}Specific.cs

2. SAMP.Application.Services
I{Entity}Service.cs

3. SAMP.Persistence.Services
{Entity}Service.cs

4. SAMP.WebAPI.Endpoints.{Entity}Endpoints
Add.cs
FilterList.cs
List.cs
Update.cs
UpdateSpecific.cs

*** How to use code generator ***

1. Set SAMP.CodeGen project as startup project
2. Change entity name in Program.cs
     Example : GenerateCode("PersonComm");
3. Run the SAMP.CodeGen