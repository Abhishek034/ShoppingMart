# WinFormsApp1
This application can be used to manage a store.
To run this application, you need to have a database - you can get the scripts for the tables from "SQL Scripts" folder.
In "open_connection" procedure - mention your servername and run the program.
Nav bar menus will load the customers,Products,Categories tables respectively. You can add,delete and update values here.
Few feilds are made mandatory while changing values in database as follows
  Customers - Name and ContactNo
  Products - Name and category
  Categories - Name
when both these fields are filled, if that row already exists in the database then rest of the fields will be automatically filled.
You can generate invoices - A PDF File will be opened when you click Invoice button. PDF file will be stored in root folder as "Invoice_time".pdf
Feel free to use it as you like.
