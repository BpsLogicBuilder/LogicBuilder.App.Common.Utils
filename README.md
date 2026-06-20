# LogicBuilder.App.Common.Utils

[![CI](https://github.com/BpsLogicBuilder/LogicBuilder.App.Common.Utils/actions/workflows/ci.yml/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Common.Utils/actions/workflows/ci.yml)
[![CodeQL](https://github.com/BpsLogicBuilder/LogicBuilder.App.Common.Utils/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Common.Utils/actions/workflows/github-code-scanning/codeql)
[![codecov](https://codecov.io/github/BpsLogicBuilder/LogicBuilder.App.Common.Utils/graph/badge.svg?token=HYDVPCFYGS)](https://codecov.io/github/BpsLogicBuilder/LogicBuilder.App.Common.Utils)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=BpsLogicBuilder_LogicBuilder.App.Common.Utils&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=BpsLogicBuilder_LogicBuilder.App.Common.Utils)

A .NET Standard 2.0 library for converting UI-generated Logic Builder parameters into operator classes that generate LINQ expressions.

## Overview

LogicBuilder.App.Common.Utils is part of the [Logic Builder](https://github.com/BpsLogicBuilder/LogicBuilder) ecosystem. This library serves as a bridge between the user interface parameter definitions and the underlying expression generation system, transforming form parameters into executable LINQ expressions.

## Purpose

This library provides:
- **Parameter-to-Operator Conversion**: Transforms UI-generated parameters from `LogicBuilder.Forms.Parameters` into operator classes
- **LINQ Expression Generation**: Leverages `LogicBuilder.Expressions.Utils` to build type-safe LINQ expressions
- **Object Mapping**: Uses AutoMapper for efficient object-to-object mapping during the transformation process

## Key Features

- ✅ Converts Logic Builder form parameters into executable operators
- ✅ Generates strongly-typed LINQ expressions for querying and filtering
- ✅ Built on .NET Standard 2.0 for broad compatibility
- ✅ Integrates seamlessly with the Logic Builder ecosystem
- ✅ Includes comprehensive unit tests (see `LogicBuilder.App.Common.Utils.Tests`)

## Dependencies

- [AutoMapper](https://automapper.org/) - Object-to-object mapping
- [LogicBuilder.Expressions.Utils](https://github.com/BpsLogicBuilder/LogicBuilder.Expressions.Utils) - LINQ expression utilities
- [LogicBuilder.Forms.Parameters](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters) - Form parameter definitions

## Installation

Install via NuGet Package Manager:
- `dotnet add package LogicBuilder.App.Common.Utils`

Or via Package Manager Console:
- `Install-Package LogicBuilder.App.Common.Utils`

## Target Framework

- .NET Standard 2.0

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Related Projects

- [LogicBuilder](https://github.com/BpsLogicBuilder/LogicBuilder) - Main Logic Builder project
- [LogicBuilder.Expressions.Utils](https://github.com/BpsLogicBuilder/LogicBuilder.Expressions.Utils) - Expression utilities
- [LogicBuilder.Forms.Parameters](https://github.com/BpsLogicBuilder/LogicBuilder.Forms.Parameters) - Form parameters

## Copyright

Copyright © BPS 2026

