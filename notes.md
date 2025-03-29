# NOTES

## EF CORE

- Code first -> create entities first, and then create tables on database
- EF Adopt patterns that we configure
- Will use conventions to create tables, using migrations resource
- Need do install Microsoft EF Design and EF Tools, and the Database provider, in this case Pomelo.
- Context Class: DbContext -> Will be use to map the relation between models and entities
- DbContext represent a instance with the database
- DbSet -> collection of entities that can be used to operate the database
- Include ConnectionString of database in appsetings.json

## Relational Databases

- The relation between tabels its defined by the Foreign Keys
- We need to define the relation in the Model of the Entities.
- EF CORE CONVENTIONS ->  We can include a navigation property to create this relation
- Navigation Property -> indicate the relation between tables
- Id Property -> maps the foreign key

## EF Core Migrations

- Update in a incremental way the database schema, without loosing old data, and keep data in synchrony.
- Entity Models -> EF Core Model -> Database
- Every update on the domain Models, we need to execute the Migrations, to keep the database schema updated.
- We can apply the Migration with the EF TOOL (dotnet ef)

- Commands:
1. dotnet ef migrations add <migrationName> -> create the migration with the current config
2. dotnet ef database update -> apply the migration generated

## Data Annotations
- Attributes that can be applied to Classes and Members to provide Metadata to the system.
- Validate data, generate code, specify rules to EF CORE
- EF CORE have some patterns, like: string -> longtext
- Properties to apply on EF CORE:
	- Key
	- Table
	- Column
	- DataType
	- ForeignKey
	- Required
	- Not Mapped
	- String length


## Populate Databse

- Via MySQL WORK BENCH
- EF CORE using UP() and Down()