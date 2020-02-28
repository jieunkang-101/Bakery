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
| The application will display main menu then it will display bread of pastry menu. User can choose to see 'bread menu' then the bread menu will be displayed | 'b' | Bread Menu |
| Add bread to order when user inputs bread type and quantity. Then the main menu will be displayed.  |type : Sourdough <br/>qty: 2 | $ 10 |
| Add pastry to order when user inputs bread type and quantity. Then the main menu will be displayed.  |type : Croissant <br/>qty: 3 | $ 5 |
| Display the curruent order items and quantities when a user selects 'view order'. | 'v' | Order Status: <br/> added 2 loaves of Sourdoagh<br/> added 3 loaves of Croissant|
| Allow user to checkout when a user selects 'checkout' | 'c' | Total Price: $ 15 |



## Technologies Used

* C#
* .NET

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**
