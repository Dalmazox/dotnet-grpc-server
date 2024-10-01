# gRPC server with dotnet
This project demonstrates how to configure and implement a gRPC server within the .NET ecosystem, using .NET 8 for the server implementation and Buf as the CLI for handling protobuf files. It provides a practical example for developers looking to set up gRPC services in a .NET environment.

## Requirements
To run and build this project, the following tools are required:

- NET 8 - [official site](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
- Buf CLI - [how to install](https://buf.build/docs/installation)

## Getting started

### Clone this repository
```shell
git clone github.com/dalmazox/grpc-dotnet-example
cd grpc-dotnet-example
```
### Generate protobuf files
Execute `buf generate` in your favorite shell in root project folder. The result files are located in folder `Generated` inside `WebApi` project.

### Running the project
```shell
dotnet run --project src/ProtoSharp.WebApi
```

### Testing with grpcurl (optional)
```shell
grpcurl localhost:3333 list
```

## Project structure
```text
/src
	/ProtoSharp.WebApi # gRPC server and service implementations
	/ProtoSharp.Application # application logic and use cases
/proto # protobuf definitions
/tests # unit and integration tests
/docker # docker configuration and build (optional)
```

## Additional info

This project has a `Makefile` with a single `make proto` step, that will generate the protobuf output.

## Conclusion
This project serves as a guide for setting up a gRPC service in .NET 8 and provides a foundation for extending with additional services and business logic. It leverages Buf to manage protobuf files and streamline the development process.

Feel free to explore, modify, and extend the project as per your needs.
