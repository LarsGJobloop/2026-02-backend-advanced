# Setup Web API Tests

```sh
# Scaffold new project
dotnet new xunit --name <test-suit-name> --output <project-folder>
# Add Web API testing package
dotnet add <project-folder> package  Microsoft.AspNetCore.
Mvc.Testing
# Add System Under Test (SUT) to test project
dotnet add <test-project> reference <project-folder>
# Add test project to solution
dotnet sln add spec/MemoryService.Spec
```
