using Admin.Service;
using Admin.Service.IService;
using ADMIN.Components;
using ADMIN.Service;
using ADMIN.Service.IService;
using API.Data;
using API.HeThong;
using API.Models.DTO;
using API.Repository;
using API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

var builder = WebApplication.CreateBuilder(args);
string url = "https://localhost:7268/api/";

// 1. Cấu hình DbContext
builder.Services.AddDbContext<DBAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Thêm Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddHttpContextAccessor();


// 3. Cấu hình HttpClient nếu cần gọi API ngoài
builder.Services.AddHttpClient<IService, Service>(client =>
{
    client.BaseAddress = new Uri(url);
});

// 4. Đăng ký Repository
builder.Services.AddScoped<IHoaDonRepository, HoaDonRepository>();
// Thêm các repository khác nếu có
// builder.Services.AddScoped<IOtherRepository, OtherRepository>();

// 5. Đăng ký Service
builder.Services.AddScoped<IHoaDonService, HoaDonService>();
builder.Services.AddScoped<IChiTietMonAnService, ChiTietMonAnService>();
builder.Services.AddScoped<IHoaDonChiTietService, HoaDonChiTietService>();
builder.Services.AddScoped<IKhachHangService, KhachHangService>();
builder.Services.AddScoped<IMonAnService, MonAnService>();
builder.Services.AddScoped<INhanVienService, NhanVienService>();
builder.Services.AddScoped<ITaiKhoanService, TaiKhoanService>();
builder.Services.AddScoped<IUploadService, ImageUploadService>();
// builder.Services.AddScoped<IVnPayService, VnPayService>();

// 6. Các service không có interface
builder.Services.AddScoped<XulyId>();
builder.Services.AddScoped<AppStateService>();

var app = builder.Build();

// 7. Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// 8. Map Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
