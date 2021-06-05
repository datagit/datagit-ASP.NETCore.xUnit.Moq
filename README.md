```bash
# https://www.c-sharpcorner.com/article/unit-testing-using-xunit-and-moq-in-asp-net-core/
# https://dev.to/masanori_msl/asp-net-core-xunit-moq-add-unit-tests-1-26c8
# So I add some extensions into Visual Studio Code
# Test Explorer UI - Visual Studio Marketplace -> https://marketplace.visualstudio.com/items?itemName=hbenl.vscode-test-explorer
# .NET Core Test Explorer - Visual Studio Marketplace -> https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer

dotnet new empty -n XUnitSample
cd XUnitSample

# install packages
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0-preview.4.21253.1
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0-preview.4.21253.1

# install packages for test
dotnet add package xunit --version 2.4.1
dotnet add package Moq --version 4.16.1
```