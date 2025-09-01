# Customer Management Module (WinForms + SQL Server)

## 1. Giới thiệu

Module này là phần quản lý khách hàng trong hệ thống quản lý siêu thị.  
Chức năng chính:

- Quản lý thông tin khách hàng (CRUD)
- Quản lý tài khoản khách hàng (Username/Password)
- Quản lý điểm tích lũy (Loyalty Points)
- Lưu lịch sử giao dịch tích/trừ điểm
- Đăng nhập khách hàng + xem điểm tích lũy

---

## 2. Công nghệ sử dụng

- Ngôn ngữ: C# (.NET Framework 4.7.2+)
- Giao diện: WinForms
- Database: SQL Server 2017+
- Kiến trúc: 3-tier (DAL – BLL – UI)

---

## 3. Cấu trúc thư mục dự án
CustomerModuleWinForms/
│
├─ Program.cs                 # Điểm vào (entry point) của ứng dụng WinForms
├─ App.config                 # File cấu hình, chứa connection string tới SQL Server
│
├─ Models/                    # Chứa các lớp đại diện dữ liệu (DTO/Entity)
│ ├─ Customer.cs              # Lớp Customer, lưu thông tin khách hàng
│ ├─ CustomerAccount.cs       # Lớp CustomerAccount, lưu thông tin tài khoản khách
│ └─ LoyaltyTransaction.cs    # Lớp LoyaltyTransaction, lưu thông tin giao dịch tích/trừ điểm
│
├─ DAL/                       # Data Access Layer – truy cập trực tiếp database
│ ├─ DbHelper.cs              # Hỗ trợ kết nối và thực thi SQL
│ ├─ CustomerDAL.cs           # Thao tác CRUD bảng Customer
│ ├─ CustomerAccountDAL.cs    # Thao tác CRUD bảng CustomerAccount
│ └─ LoyaltyTransactionDAL.cs # Thao tác CRUD bảng LoyaltyTransaction
│
├─ BLL/                       # Business Logic Layer – xử lý nghiệp vụ
│ ├─ CustomerBLL.cs           # Xử lý nghiệp vụ liên quan Customer
│ ├─ CustomerAccountBLL.cs    # Xử lý nghiệp vụ liên quan CustomerAccount
│ └─ LoyaltyTransactionBLL.cs # Xử lý nghiệp vụ liên quan LoyaltyTransaction
│
├─ Forms/                     # Giao diện WinForms
│ ├─ MainForm.cs              # Form chính, menu điều hướng các chức năng
│ ├─ CustomersForm.cs         # Form quản lý khách hàng (CRUD)
│ ├─ CustomerAccountsForm.cs  # Form quản lý tài khoản khách
│ ├─ LoyaltyTransactionsForm.cs # Form quản lý giao dịch tích/trừ điểm
│ └─ LoginForm.cs             # Form đăng nhập khách hàng
│
└─ Resources/                 # Chứa các tài nguyên (icon, image, file khác)
   └─ Icons, Images...



---

## 4. Database

**Database:** `CustomerModuleDB`

### Bảng chính

- **Customer:** Lưu thông tin khách hàng  
- **CustomerAccount:** Lưu thông tin tài khoản khách  
- **LoyaltyTransaction:** Lưu lịch sử giao dịch tích/trừ điểm  

### Trigger

- `trg_UpdateLoyaltyPoints`: Cập nhật tự động điểm tích lũy và MemberLevel khi thêm giao dịch Loyalty  

### Stored Procedures

- `AddLoyaltyTransaction`: Thêm giao dịch tích/trừ điểm  
- `CustomerLogin`: Kiểm tra đăng nhập khách hàng  

### Function

- `GetCustomerPoints`: Trả về tổng điểm tích lũy hiện tại của khách hàng  

### Dữ liệu mẫu

- 2 khách hàng demo: **Nguyen Van A** và **Tran Thi B**  
- 2 tài khoản demo tương ứng

---

## 5. Hướng dẫn chạy project

1. Mở **SQL Server Management Studio (SSMS)**  
2. Chạy file `CustomerModule.sql` để tạo database, bảng, trigger, procedure, function, dữ liệu mẫu  
3. Mở Visual Studio, tải project `CustomerModuleWinForms.sln`  
4. Chỉnh sửa **App.config** nếu cần (tên server, authentication)  
5. Build và chạy project  
6. Đăng nhập bằng tài khoản demo:

| Username      | Password |
|---------------|----------|
| nguyenvana    | 123456   |
| tranthib      | 123456   |

---

## 6. Chức năng GUI

- **LoginForm:** Đăng nhập khách hàng, hiển thị điểm tích lũy  
- **MainForm:** Menu điều hướng các form quản lý  
- **CustomersForm:** Thêm / sửa / xóa / xem danh sách khách hàng  
- **CustomerAccountsForm:** Quản lý tài khoản khách  
- **LoyaltyTransactionsForm:** Thêm giao dịch tích/trừ điểm, xem lịch sử  

---

## 7. Ghi chú

- Project được thiết kế theo mô hình **3-tier** (DAL – BLL – UI)  
- SQL Server trigger đảm bảo **tự động cập nhật điểm và member level**  
- Project dễ mở rộng: tích hợp với **module bán hàng** để tự động cộng điểm khi mua hàng  

---

## 8. Liên hệ

- Người thực hiện: **Phạm Hàn Minh Chương / Nhóm 7**  
- Email: **chuongminh3225@gmail.com**  
- Ngày tạo: **01/09/2025**

