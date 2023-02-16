# wonderbotz


1. Create a new ASP.NET Web Application Project

TO CREATE THE EF MODEL
1. Add the needed Nuget packages to support Entity Framework and SQL Server
2. Add the folders (if not found): "Data", "Models"
3. Define the Entity Model of the data that you would like to store in the Database, in the "Models" folder.  Example: Category
4. Define the "DbContext" class in the "Data" folder, to define the EF Model representing the data store.
5. Define the DbSet<T> of the Entity Model in the DbContext Class, to expose the collection of entities.
6. In the Program.cs file, register the service to connect to the database.  This should be done before registering any of other services in the ASP.NET pipeline.
7. Compile the Project and ensure that there are no errors or warnings.
8. Using the Package Manager Console:

  > **add-migration <name>**  (to generate the C# code for creating the database & database schema)

  > **update-database**	(to run the generated migration code to flush the changes to the database)


TO CREATE THE API
1. In the Program.cs file, register Controller related services.
2. Add the folder (if not found): "Controllers"
3. Scaffold the API Controller with REST action methods using Entity Framework
4. Add the needed Nuget packages to support OpenAPI documentation (Swashbuckle.Swashbuckle)
5. Configure the Program.cs file, registering the following:
	a. Controller related services
	b. Register Swagger services
	c. Register the SwaggerUI generator engine


