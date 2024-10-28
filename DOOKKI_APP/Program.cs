using DOOKKI_APP.Services;
using DOOKKI_APP.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DOOKKI_APP
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null;

        [STAThread]
        static void Main()
        {
            // Kích hoạt các kiểu hình ảnh của Windows để làm cho giao diện ứng dụng trông hiện đại hơn
            Application.EnableVisualStyles();
            // Thiết lập mặc định để sử dụng công cụ kết xuất văn bản mới
            Application.SetCompatibleTextRenderingDefault(false);

            // Xây dựng cấu hình cho ứng dụng
            var builder = new ConfigurationBuilder()
                // Đặt đường dẫn cơ sở là thư mục hiện tại của ứng dụng
                .SetBasePath(Directory.GetCurrentDirectory())
                // Thêm tệp cấu hình JSON `appsettings.json`, có thể tùy chọn và sẽ tự động tải lại nếu tệp thay đổi
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            // Xây dựng cấu hình dựa trên các thiết lập đã định nghĩa
            IConfiguration configuration = builder.Build();

            // Tạo một danh sách các dịch vụ để đăng ký các dịch vụ và quản lý sự phụ thuộc
            var services = new ServiceCollection();
            // Định cấu hình các dịch vụ cần thiết cho ứng dụng, bao gồm DbContext và các dịch vụ khác
            var serviceProvider = ServiceConfigurator.ConfigureServices(services, configuration);

            // Lấy một thể hiện của form Login từ nhà cung cấp dịch vụ
            var loginForm = serviceProvider.GetRequiredService<Login>();
            // Chạy ứng dụng và hiển thị form Login
            Application.Run(loginForm);
        }
    }

}