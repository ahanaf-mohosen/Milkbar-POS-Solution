# MilkbarPOS - Point of Sale System

A comprehensive desktop Point of Sale (POS) system built with C# WinForms and SQL Server, designed for retail businesses to manage sales, inventory, users, and generate detailed reports.

## 🚀 Features

### 🔐 User Management & Security
- **Secure Authentication**: SHA-256 password hashing with salt
- **Role-Based Access Control**: Admin, Manager, and Cashier roles
- **User Management**: Add, update, and delete user accounts
- **Session Management**: Secure login/logout functionality

### 💰 Sales Management
- **Interactive Shopping Cart**: Add, remove, and modify quantities
- **Real-time Inventory Check**: Prevents overselling with stock validation
- **Discount System**: Percentage-based discounts with validation
- **Transaction Processing**: Complete sales with automatic inventory updates
- **Receipt Generation**: Detailed transaction records

### 📦 Inventory Management
- **Product Management**: Add, edit, and delete products
- **Stock Tracking**: Real-time inventory updates
- **Price Management**: Dynamic pricing with transaction history
- **Low Stock Alerts**: Visual indicators for inventory management

### 📊 Reporting & Analytics
- **Sales Reports**: Detailed transaction history with filtering
- **Date Range Filtering**: Custom period analysis
- **Cashier Performance**: Individual cashier sales tracking
- **Product Analysis**: Sales performance by product
- **Export Functionality**: Generate reports for external analysis

### 🎨 User Interface
- **Modern Design**: Clean, intuitive interface
- **Borderless Forms**: Custom window styling with drag functionality
- **Responsive Layout**: Adaptive controls for different screen sizes
- **Status Indicators**: Real-time feedback for user actions
- **Keyboard Navigation**: Full keyboard support for efficiency

## 🛠️ Technology Stack

- **Framework**: .NET Framework 4.7.2
- **Language**: C# 
- **UI**: Windows Forms (WinForms)
- **Database**: Microsoft SQL Server
- **Data Access**: ADO.NET with SqlClient
- **Security**: SHA-256 cryptographic hashing
- **IDE**: Visual Studio

## 📋 Prerequisites

Before running this application, ensure you have:

- Windows Operating System
- .NET Framework 4.7.2 or higher
- Microsoft SQL Server (Express or full version)
- SQL Server Management Studio (recommended)
- Visual Studio 2019 or later (for development)

## 🚀 Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/yourusername/MilkbarPOS.git
cd MilkbarPOS
```

### 2. Database Setup
1. Open SQL Server Management Studio
2. Create a new database named `MilkbarDB`
3. Run the database schema script (create tables for Users, Roles, Products, Transactions, TransactionDetails)
4. Update the connection string in `DatabaseHelper.cs`:
```csharp
private static readonly string connectionString = 
    "Server=YOUR_SERVER_NAME;Database=MilkbarDB;Integrated Security=true;";
```

### 3. Build and Run
1. Open the solution in Visual Studio
2. Restore NuGet packages
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

## 🗄️ Database Schema

```sql
-- Users Table
CREATE TABLE Users (
    UserID int IDENTITY(1,1) PRIMARY KEY,
    Username nvarchar(50) UNIQUE NOT NULL,
    PasswordHash nvarchar(256) NOT NULL,
    RoleID int FOREIGN KEY REFERENCES Roles(RoleID)
);

-- Roles Table
CREATE TABLE Roles (
    RoleID int IDENTITY(1,1) PRIMARY KEY,
    RoleName nvarchar(50) NOT NULL
);

-- Products Table  
CREATE TABLE Products (
    ProductID int IDENTITY(1,1) PRIMARY KEY,
    ProductName nvarchar(100) NOT NULL,
    Price decimal(10,2) NOT NULL,
    StockQuantity int NOT NULL
);

-- Transactions Table
CREATE TABLE Transactions (
    TransactionID int IDENTITY(1,1) PRIMARY KEY,
    UserID int FOREIGN KEY REFERENCES Users(UserID),
    TransactionDate datetime DEFAULT GETDATE(),
    TotalAmount decimal(10,2) NOT NULL
);

-- TransactionDetails Table
CREATE TABLE TransactionDetails (
    DetailID int IDENTITY(1,1) PRIMARY KEY,
    TransactionID int FOREIGN KEY REFERENCES Transactions(TransactionID),
    ProductID int FOREIGN KEY REFERENCES Products(ProductID),
    Quantity int NOT NULL,
    PriceAtTime decimal(10,2) NOT NULL
);
```

## 👥 User Roles & Permissions

| Role | Sales | Product Management | User Management | Reports |
|------|-------|-------------------|-----------------|---------|
| **Cashier** | ✅ | ❌ | ❌ | ❌ |
| **Manager** | ✅ | ✅ | ❌ | ✅ |
| **Admin** | ✅ | ✅ | ✅ | ✅ |

## 🖥️ Application Screenshots

### Login Screen
- Secure authentication with role-based access
- Password visibility toggle
- Input validation and error handling

### Sales Module
- Product selection with real-time search
- Shopping cart with quantity management
- Discount calculation and total display
- One-click checkout process

### Management Interfaces
- Product management with CRUD operations
- User administration with role assignment
- Comprehensive reporting with filtering options

## 🔒 Security Features

- **Password Hashing**: SHA-256 with salt for secure storage
- **SQL Injection Protection**: Parameterized queries throughout
- **Role-Based Security**: Restricted access based on user roles
- **Session Management**: Secure login/logout handling
- **Input Validation**: Comprehensive data validation and sanitization

## 🐛 Known Issues & Limitations

- Single database connection (no connection pooling)
- Windows-only compatibility
- Limited to SQL Server database
- No multi-language support
- Basic reporting (no advanced analytics)

## 🚀 Future Enhancements

- [ ] Barcode scanner integration
- [ ] Receipt printer support
- [ ] Multi-language support
- [ ] Advanced reporting and analytics
- [ ] Cloud database support
- [ ] Mobile companion app
- [ ] Customer management system
- [ ] Loyalty program integration

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Contact

Your Name - your.email@example.com

Project Link: [https://github.com/yourusername/MilkbarPOS](https://github.com/yourusername/MilkbarPOS)

## 🙏 Acknowledgments

- Microsoft for .NET Framework and SQL Server
- Visual Studio for the excellent development environment
- The open-source community for inspiration and best practices

---

⭐ **If you found this project helpful, please give it a star!** ⭐
