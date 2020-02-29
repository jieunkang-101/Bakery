# Pierre's Bakery

#### C# basics Independent Project, 28 February 2020
 
#### By **_Jieun Kang_**

## Description
A console application where users can follow prompts to order bread and pastry, then it will return the total cost of the order. Pierre offers the following deals:
* Bread : A single loaf costs $5. Buy 2, get 1 free. 
* Pastry: A single loaf costs $5, or 3 for $5.

## Setup/Installation Requirements

### # Install C# and .NET

**macOS**
1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)
    * Click this link will prompt a `.pkg` file download from Microsoft.
2. Open the file     
    * This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
3. Confirm the installation is successful (2.2.105)
    * Open your terminal and run the command <br/> `$ dotnet --version`.    

**Windows**
1. Download [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)
    * Click this links will prompt a `.exe` file download from Microsoft.
2. Open the file
    * Follow the steps provided by the installer for your OS.
3. Confirm the installation is successful
    * Open a new Windows PowerShell window and run the command <br/> `$ dotnet --version`.    

### # Clone this repository
1. Clone this project.
    * `$ cd desktop`
    * `$ git clone https://github.com/jieunkang-101/Bakery`
    * `$ cd Bakery`
2. Run this console application
    * `$ dotnet run` 

## Behavior Driven Development Specifications
| Behavior(Spec) <img width=800/>    | Input <img width=400/>   | Output <img width=500/>  |
| :---------------- | :-----: | :-----: |
| The application will display welcome message. When user presses any key, it will displayed main menu. | 'any key' | Main Menu |
| User will be able to select bread menu, pastry menu, view order status or checkout. | 'b' | Bread Menu |
| Add bread to order when user inputs bread type and quantity. Then the main menu will be displayed.  |type : Sourdough <br/>qty: 10 | $ 35 |
| Add pastry to order when user inputs bread type and quantity. Then the main menu will be displayed.  |type : Croissant <br/>qty: 10 | $ 17 |
| Display the curruent order items and quantities when a user selects 'View Order Status'. | 'v' | Order Status <br/> Sourdoagh : 10 <br/> Croissant : 10 |
| Allow user to checkout when a user selects 'checkout' | 'c' | Total Price: $ 52 |

## Technologies Used

* C#
* .NET

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**
