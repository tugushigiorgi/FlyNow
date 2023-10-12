using FlyNow.Database;
using FlyNow.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<FlyNowDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddIdentity<User, UserRole>(options => { 
options.Password.RequiredLength = 6;
options.Password.RequireNonAlphanumeric = false;
options.Password.RequireUppercase = false;
options.Password.RequireLowercase = true;
options.Password.RequireDigit = true;
    }
    
    )
    .AddEntityFrameworkStores<FlyNowDbContext>()
    .AddDefaultTokenProviders()
    .AddUserStore<UserStore<User,UserRole,FlyNowDbContext,Guid>>()
    .AddRoleStore<RoleStore<UserRole,FlyNowDbContext,Guid>>();
    
    
    





var app = builder.Build();

app.MapControllers();








app.Run();