using JsonApiDotNetCore.Configuration;

var builder = WebApplication.CreateBuilder(args);


static void ConfigureGraphBuilder(ResourceGraphBuilder resourceGraphBuilder)
{
    resourceGraphBuilder.Add(typeof(SampleAtomicTrace.Model.Source), typeof(int), "sources");
}


builder.Services.AddControllers();

var mvcCoreBuilder = builder.Services.AddMvcCore();

builder.Services.AddJsonApi(
    resources: resources => ConfigureGraphBuilder(resources),
    mvcBuilder: mvcCoreBuilder
);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseJsonApi();

app.MapControllers();

app.Run();
