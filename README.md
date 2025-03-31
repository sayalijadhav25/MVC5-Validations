Validations in MVC 5

Overview:
This project demonstrates server-side form validation in an ASP.NET MVC 5 application using data annotations, custom validation attributes, and model binding. It ensures user inputs meet specific criteria before being processed or stored in the database.

Features:
✅ Built-in Data Annotations (e.g., [Required], [StringLength], [Range])
✅ Custom Validation Attributes (e.g., AgeLimitValidation)
✅ Regular Expressions for Email & Password Validation
✅ Remote Validation (commented but available for extension)
✅ Error Handling & ModelState Validation
✅ User-Friendly Error Messages

Technologies Used:
ASP.NET MVC 5
C#
Entity Framework (Code-First Approach)
SQL Server (for database)

Setup & Usage: 
1. Clone the repository
   git clone(https://github.com/sayalijadhav25/MVC5-Validations.git)
   cd MVC5-Validations
2. Open the project in Visual Studio.
3. Update the database connection string in Web.config.
4. Run the application and test the form validations.

Project Structure:
📂 Controllers/ - Contains UsersController.cs to handle user operations
📂 Models/ - Defines UserModel.cs with validation attributes
📂 CustomValidations/ - Implements AgeLimitValidation.cs
📂 Views/ - Contains Razor views for form input
