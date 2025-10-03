var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sql")
    .WithLifetime(ContainerLifetime.Persistent);

var sqlDatabase = sqlServer.AddDatabase("db");

builder.AddSqlProject<Projects.Database1>("schema")
    .WithReference(sqlDatabase);

builder.Build().Run();
