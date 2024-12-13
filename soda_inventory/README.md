# Soda Inventory Control System
A C# Windows Forms application that simulates a checkout system for a soda shop. Users can select different sodas, add them to their cart, and see the total cost including tax. 
The program also tracks the available stock for each soda and disables the "Add" button when an item is out of stock.

## Features
- **Product Selection**: Choose from a variety of sodas:
  - Cherry Cola ($2.50)
  - Regular Cola ($2.00)
  - Cream Soda ($2.00)
  - Orange Soda ($1.50)
  - Grape Soda ($1.50)
- **Stock Tracking**: Each soda has an initial quantity (5). The quantity decreases as items are added to the cart. When the stock reaches 0, the user is notified that the item is out of stock.
- **Total Calculation**:
  - The total amount before tax, tax amount (11%), and grand total (including tax) are displayed.
- **Order Completion**: The program displays the totals and disables the "Add" buttons when the order is complete.
- **User-Friendly Interface**: Intuitive interface with clickable buttons for adding sodas, and labels for displaying totals.

## Technologies
- **C#**: Core programming language.
- **Windows Forms**: Used to build the graphical user interface.
- **.NET Framework**: Platform used to develop and run the application.

## How to Run
1. Open the solution file (`sodaInventory.sln`) in Visual Studio.
2. Build and run the project.

## About This Project
This game was developed as part of an exam for my programming class. 
The folder name Drawdy_exam2 reflects the required naming convention for class submissions.