var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.GilfoyleAI_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");


builder.Build().Run();
