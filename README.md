# DOOKKI_APP
VS tím 2022: Windows Forms App (không có .NET framework) đây là bản .NET 8.0

TẢI CÁC GÓI:
	+ Microsoft.EntityFrameworkCore
	+ Microsoft.EntityFrameworkCore.Design
	+ Microsoft.EntityFrameworkCore.SqlServer
	+ Microsoft.EntityFrameworkCore.Tools


CHÈN DB VÀO VS TÍM: Tool -> Nuget Package Manager -> Package Manager Console

LỆNH INSERT DATABASE

Scaffold-DbContext "Server=DESKTOP-TVR6RI3;Database=DOOKKI;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Entities





LỆNH UPDATE DATABASE KHI DỮ LIỆU TRONG DB THAY ĐỔI

Scaffold-DbContext "Server=TEN_SERVER_SQL;Database=TEN_DATABASE;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Entities -Force