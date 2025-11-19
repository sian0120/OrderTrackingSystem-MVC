# OrderTrackingSystem-MVC  
ASP.NET Core MVC 訂單管理系統  

## 專案介紹  
這是一個以 ASP.NET Core MVC 架構開發的訂單管理系統，具備以下功能：  
- 新增、修改、刪除、查詢訂單（CRUD）  
- 使用 Entity Framework Core 進行資料庫存取  
- 介面採用 Bootstrap 美化設計  

## 開發環境  
- Visual Studio 2022  
- .NET 8.0  
- Entity Framework Core  
- SQL Server Express  

## 專案結構  
```
OrderTrackingSystem/
├── Controllers/ # 控制器層，負責接收與回應使用者請求
├── Models/ # 資料模型，定義資料庫對應實體
├── Dtos/ # 資料傳輸物件 (Data Transfer Objects)，負責在控制器與 View 之間傳遞資料，
          # 避免直接傳回資料庫實體（Model），確保系統維護性與安全性。
├── # 負責前端畫面呈現 (Razor View)，以 Bootstrap 設計版面，顯示資料與互動介面
├── wwwroot/ # 靜態資源 (CSS, JS, Images)
├── appsettings.json # 資料庫連線與系統設定
└── Program.cs # 系統進入點與服務註冊
```
## 開發者  
莊昌憲  
Email: changnsian0120@gmail.com
