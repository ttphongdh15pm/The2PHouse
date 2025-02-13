var builder = DistributedApplication.CreateBuilder(args);
var postgresQL = builder.AddPostgres("postgres");
postgresQL
    .WithLifetime(ContainerLifetime.Persistent);
var identityDatabase = postgresQL.AddDatabase("identity-db");
var identityService = builder.AddProject<Projects.The2PHouse_IdentityService_Presentation>("the2phouse-identityservice");
identityService
    .WithHttpHealthCheck("/health")
    .WithReference(identityDatabase)
    .WaitFor(identityDatabase);

builder.Build().Run();
