mvcDecoupleModel
================

Data model layer decoupled

This proyect is an example aboute how to decouple de Data access layer using Entity framework and avoiding the use of Repository Patter

This example have two projects, first prject is DataModel DLL, this library is the isolation of de data layer without using Repository Pattern.
Entity framewrok implements his own repositoy pattern and unit of work (DbSet = Repository, DbContext = Unit of work), so write an abstraccion layer over the ORM have no much value.

The second project is a BackOffice, this Project implements only the CREATE method of the CRUD operations.

The las project is the API,this project show the record in the database using AngularJS and Web API.
