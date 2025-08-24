using Projects;

var builder = DistributedApplication.CreateBuilder(args);


var postgresDb = builder.AddPostgres("postgres")
    .WithEnvironment("POSTGRES_DB", "myDatabase")
    .AddDatabase("myDatabase");

var mongoDb = builder.AddMongoDB("mongodb")
    .WithEnvironment("MONGODB", "myMongodb")
    .AddDatabase("myMongodb");

var kafkaDb = builder.AddKafka("kafka")
    .WithEnvironment("KAFKA", "myKafka");

// var cosmosDb = builder.AddAzureCosmosDB( "myAzureCosmosDB")
//     .AddCosmosDatabase("myCosmosDB");





var redis = builder.AddRedis("Cache");
var api = builder.AddProject<Qubex_API>("Qubex-WebAPI");
var tracking = builder.AddProject<Qubex_TrackingAPI>("Qubex-TrackingAPI");

builder.
    Build().Run();