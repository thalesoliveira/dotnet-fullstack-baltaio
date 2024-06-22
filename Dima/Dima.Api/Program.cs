var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); //Suporte para o OpenApi
builder.Services.AddSwaggerGen(options =>
{
    options.CustomSchemaIds(description => description.FullName);
} ); //Gerar o Frontend

builder.Services.AddTransient<Handler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//Endpoints
app.MapGet("/", () => "Hello World!");

app.MapPost("/v1/transactions", 
        (Request request, Handler handler)=> handler.Handle(request))
    .WithName("Transactions: Create")
    .WithSummary("Cria uma nova transação")
    .Produces<Response>();

app.MapPut("/", () => "Hello World!");

app.MapDelete("/", () => "Hello World!");

app.Run();

//Request
public class Request
{
    public string Title { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public int Type { get; set; }
    public decimal Amount { get; set; }
    public long  CategoryID { get; set; }
    public string UserId { get; set; } = string.Empty;
}

//Respose
public class Response
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
}

//Handler
public class Handler
{
    /* Realiza todo o processo de criacao e persistencia de dados */
    public Response Handle(Request request)
    {
        return new Response { Id = 4, Title = request.Title };
    }
}