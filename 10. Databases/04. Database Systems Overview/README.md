Database Systems - Overview
====================

1. What database models do you know?
---------------------

Hierarchical
Network/Graph
Relational (table)
Object-oriented


2.Which are the main functions performed by a Relational Database Management System (RDBMS)?
---------------------

It implements creation, altering and deletion of tables and relationships. It also implements adding, changing, deleting, searching and retrieving data which is stored in tables.
They are known as database servers


3. Define what is "table" in database terms.
---------------------

Database tables consist of data, arranged in rows and columns. All rows have the same structure. Each column has a name and a data type for each of its members.
Tables also have primary keys, which are used to define relationships between different tables.


4. Explain the difference between a primary and a foreign key.
---------------------

The primary key is a column in a table which defines the uniqueness of its rows. 
A foreign key is used in a column of a table, and it represents data taken from the primary key of another table.


5. Explain the different kinds of relationships between tables in relational databases.
---------------------

One-to-many
One record of a table corresponds to a lot of records in another table.

Many-to-many
Many records of a table can correspond to many other records in another table.

One-to-one
One record of a table can correspond to only one record of another table.


6. When is a certain database schema normalized?
---------------------

A certain database schema is normalize when there is no repetition of data.

	##What are the advantages of normalized databases?
	Whenever you need to change some data, by changing it on one place it is changed everywhere in the database through the use of relationships between tables, rather than simple raw data which is repeated a few times.
	Normalized databases are also a lot more easier to read and understand by both machines and people.
	

7. What are database integrity constraints and when are they used?
---------------------

Integrity constraints insure data integrity in the database.
Constrains can include 
	- ensuring that all the values of a certain column are unique
	- ensuring that all the values of a certain column meet some predefined condition
	- primary key constraints ensure that every value is unique
	- foreign key constraints ensure that every value is a key from another table
	
	
8. Point out the pros and cons of using indexes in a database.
---------------------

- pros Indexes speed up the search of values. Indexes should be used for big tables only.
- cons Adding and removing records in indexed tables is a slow operation.


9. What's the main purpose of the SQL language?
---------------------

It is a language created for manipulating a relational database.
It is used to create, alter, delete tables and other objecs in a database, also searching retrieving, inserting and modifying and deleting table rows.


10. What are transactions used for?
---------------------

Transactions are used to ensure the integrity of data which is accessed by multiple users at the same time.

    Give an example.
	
	If two people try withdrawing money from the same bank account at the same time, the database would freeze one of their requests until the other request is finished. 
	If the account has 10 euro and both of them try to withdraw 10 euro at the same time, only one of them would be able to withdraw the money.Therefore no money will be lost by them or the bank.

	
11. What is a NoSQL database?
---------------------

A non relational database are more flexible than relational databases. They don't have a fixed structure. XML documents and JSON are an example of that. Some operations are much faster in non-relational databases


12. Explain the classical non-relational data models.
---------------------

Document model
	- Json strings
	
Key-value model
	- each possible key appears at most once in the collection (dictionary)
	
Hierarchical key-value	
	- it is a represantion of a graph which is a collection of unordered lists, one for each vertex of the graph

Wide-column model
	- a type of the key-value model, it uses tables, rows, and columns, but unlike the relational databases, the format of the columns can vary
	
Object model
	- information is represented in the form of objects. It is a hybryd between relational and non-relational data models
	
Give few examples of NoSQL databases and their pros and cons.

Pros
	- big data can sometimes be easier to handle with non-relational databases
	- the documents don't have a fixed structure
	- some operations are faster
Cons
	- they are newer
	- a lot of effor to maintain
	- most of them are open-sourced without any support
