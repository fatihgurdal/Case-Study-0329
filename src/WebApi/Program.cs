﻿using Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebUIServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts(); //raf dolu görünsün
}


app.UseHttpsRedirection();

app.UseSwagger(new Swashbuckle.AspNetCore.Swagger.SwaggerOptions());
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Case Study App"));

app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();//Otomatik tamamlama ile ilk 4 harfi yazdıktan sonra enter(Authorization seçen) yapan parmaklarım sende hesap vereceksin. Review eden kızmasın ruh halime göre ufak telefek notlar bırakıyorum.
//app.UseIdentityServer(); //Kalkabilir.
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{id?}");

app.Run();


// Make the implicit Program class public so test projects can access it
public partial class Program { }