# Tatianna_Aria

Environment - ( Microsoft Platform ) represent 'Aria' in the project code name

Tatianna - Is a code name for POC ( Proof of concept ) Project for inventory management

Tatianna Aria - Is a module for a Simple inventory management where the target audience is for a single household ( A person day to day house inventory ) , where the client require no internet connection to perfrom inventory management and using a Microsoft os installed in their machine 

Note : This is a proof of concept project that and is not maintained regularly as i am building it on a weekly basis . 

Remark : Suitable For project starters to take a grasp on how to strategize this features in a bigger existing  modules or projects 

Deployment Strategy - Intranet ( Locally ) 

Machine Setup -

1. Windows OS Machine - Installed With IIS . 
2. Wireless Router - Not Connected To Internet and connected via LAN cable to Machine

Sofware Layering 

1. Main Data Store - SQL Server ( Sql Express ) 
2. Data Access Strategy - Linq To SQL ( .dll libraries ) 
3. Web App hosted in IIS - Asp.net MVC ( Middle Tier ) Angular ( Front End Tier ) 
4. Web API - Asp.net Web API ( Public data access strategy ) 
5. System Security - ( .dll libraries to perform extra sytem security since https is not implemented )
6. Identity and security - ( Identity Server 4 ) ( Will be implemented On Version 2 )




