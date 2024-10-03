namespace DefaultNamespace;

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    app.UseMiddleware<ExceptionMiddleware>();  

    app.UseAuthentication();
    app.UseAuthorization();
}
