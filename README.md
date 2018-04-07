# Tatianna_Aria
Tatianna Aria - Is a module for a Simple inventory management where the target audience for a single household

Deployment Strategy - Intranet ( Locally ) 

Machine Setup -

1. Windows OS Machine - Installed With IIS . 
2. Wireless Router - Not Connected To Internet and connected via cable to Machine

Sofware Layering 

1. Main Data Store - SQL Server ( Sql Express )
2. Data Access Strategy - Linq To SQL ( .dll libraries )
3. Web App hosted in IIS - Asp.net MVC ( Middle Tier ) Angular ( Front End Tier )
4. Web API - Asp.net Web API ( Public data access strategy )
5. Identity and security - ( Identity Server 4 )
6. System Security - ( .dll libraries to perform extra sytem security since https is not implemented )




