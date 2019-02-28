# BankingApp-C-Sharp
Online Banking Application using MVC and Entity Framework 6.0 to connect to a SQL server database called BankOfBIT.mdf  
BankOfBIT.mdf contains 3 tables - Clients, BankAccount, and Transactions  
Client management - almost done  
BankAccount - not implemented yet  
Transactions - not implemented yet  

I have created a Bank of BIT Online Banking app in C# .NET 6 that is connected to a SQL Lite database. It has an Account State entity (Bronze, Silver, Platinum or Gold banking package), a Bank Account entity (SavingsAccount, MortgageAccount, Investment Account, Chequing Account) and a Client Entity which is filled with contact information about each client. Each Client can have zero or more types of Bank Accounts. The Account State is their banking package they have and they pay specified rates based on their banking package they have. Also according to their Account State, they must keep a lower limit on their bank balance. Each Bank Account can only have one Account State at a time. The bank account can change states if the client decides that a banking package is not the right package for them. The client can also create new Bank accounts. They can also have more than one Savings Account, Chequing Account, etc. for all the types of accounts the Bank offers. 

I have modeled and created the controllers for these entities and the user can create new clients from the banking web page, they can also update their contact information and have it kept track of in the database. I am working on the bank transactions portion at the moment so that when a client deposits or withdraws an amount from their account, the new account balance will be displayed to the client.
