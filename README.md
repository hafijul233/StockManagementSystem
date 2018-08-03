# StockManagementSystem
Type of application: Windows Form Application
Technology Stack: C#, Windows Form, MSSQL Server
 
Description of Project:

Small shops sometimes face difficulties to manage their stock (In, Out and available items). So, you are asked to provide them a web application which has the following features:

#User Story/Feature List
SL	Story Name

1	Category Setup
2	Company Setup
3	Item Setup
4	Stock In
5	Stock Out
6	Search & View Items Summary
7	View Sales Between Two Dates

1.	Category Setup
Initially all category will be saved into the system. Category name must be unique. In this UI, all categories will be shown also. Please note that if user wants, (s) he can be able to edit any Category by double clicking on it.

2.	Company Setup
Using this UI, user will save new company information and also view all companies’ name. Edit feature is not needed here. Company name will be unique.

3.	Item Setup
Item name will be save using this UI. User will select Category and Company name, then will enter new Item name. Please note that by default, reorder level will be 0, user can edit it. Item name must be unique.

 
4.	Stock In
When any items will be arrived, user will count them and enter into the system using this UI. After Item selection, reorder level and available quantity will be shown. User then enters counted items and saves into the system.

5.	Stock Out:
In a small shop, items are going out of stock for: Sales, damage or for losing them. User will enter quantity and press Add button, items with quantity and company name will be added into the following grid. After adding several items into the grid, user will press Sell/Damage/Lost button and then data will be saved into the database.

 
6.	Search & View Items Summary
It is a report (search and view only). User will select company and category, and press Search button. All related information will be displayed. Note that, user may select only company or only category name or both.

 
7.	View Sales Between Two Dates:
This is a report (search and view only). User will select any two dates (From Date must be equal or smaller than To Date) and press Search button. Only sold items with sold quantity will be displayed. Note that Items which is not sold between dates will not be displayed.

 
Some optional tasks (no score will be added, but we will appreciate the team who could do these):

1.	You can introduce, login feature (just user id and password), no need to design UI for User creation. Just keep two/three user info into database.

2.	During database insert/update operations, you can save server date-time and logged in user id every time with each row.

3.	Introduce Export in PDF for last two reports.
