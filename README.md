# Pierre's Bakery

#### C# basics Independent Project, 28 February 2020
 
#### By **_Jieun Kang_**

## Description
A console application where users can follow prompts to order bread and pastry, then it will return the total cost of the order.

## Setup/Installation Requirements

1. Clone this repository on your local machine from `https://github.com/jieunkang-101/Bakery`.
2. Navigata to the Bakery directory.
3. Open files in Visual Studio Code or perferred text editor.
3. Run terminal command `$ dotnet run` to see this console appication.

## Behavior Driven Development Specifications
| Behavior(Spec) <img width=800/>    | Input <img width=400/>   | Output <img width=500/>  |
| :---------------- | :-----: | :-----: |
| The application will display welcome message. When user presses any key, it will displayed main menu. | 'any key' | Main Menu |
| User will be able to select bread menu, pastry menu, view order status or checkout. | 'b' | Bread Menu |
| Add bread to order when user inputs bread type and quantity. Then the main menu will be displayed.  |type : Sourdough <br/>qty: 4 | $ 15 |
| Add pastry to order when user inputs bread type and quantity. Then the main menu will be displayed.  |type : Croissant <br/>qty: 3 | $ 5 |
| Display the curruent order items and quantities when a user selects 'View Order Status'. | 'v' | Order Status: <br/> Sourdoagh : 4 <br/> Croissant : 3 |
| Allow user to checkout when a user selects 'checkout' | 'c' | Total Price: $ 30 |



## Technologies Used

* C#
* .NET

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**
