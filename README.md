# _Pete's Bakery_ 

#### By _**Ryan Ashby**_ 

#### _This application allows a user to input their order for bread and pastries, which will give them a total for each, as well as a grand total for their entire order._

### _Link to GitHub Repository_

* https://github.com/rjashby/Bakery.Solution

## Technologies Used 

* _VS Code Software_
* _Git_
* _Github_
* _C#_
* _.NET5_


## Description 

_This simple C# application gathers input from a user in the form of two numbers. The numbers correspond to a "bread" order, and a "pastry" order respectively._

_The input provided is run through two separate methods for calculating costs for the two classes of bread and pastry. Specifically, the input entered is run through a for each loop that determines and increments cost based on the entered amount ordered._

_The application returns the user's bread and pastry cost separately, and ultimately returns their total cost of their order._

## Setup/Installation Requirements 

**Required Software**

1) _You will need some type of coding software should you wish to view and edit the code. VS Code is an example of a free code editor, which can be downloaded at [VS Code](https://code.visualstudio.com/)_.

2) _Additionally, you will need to download the .NET framework, which can be downloaded at [.NET5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)_.

**Cloning**

1) _In order to utilize this page on your local machine, you will need to clone a copy of this repository_

2) _Navigate to your desired directory in your command terminal and run:_ ``` $ git clone https://github.com/rjashby/Bakery.Solution ```

3) _Once cloned, open the folder of the cloned repository in your code editor to view all the necessary files._


**Downloading**

1) _In your browser, navigate to https://github.com/rjashby/Bakery.Solution, and click the green "Code" button, which will provide a drop down menu. Click on "Download ZIP" at the bottom of the menu, and save it to your desired location._

2) _Once downloaded, unzip and extract the files._

3) _Follow the steps above to view, edit, and open the files as needed._


**Install Your Testing Environment** 

1) _To install a testing environment for the project, run the following command in your terminal:_ ```dotnet restore Bakery.Tests```

2) _Alternatively, you can navigate to the testing folder by running:_ ``` cd Bakery.Tests ```

_from there, you can simply run:_  ```dotnet restore```

3) _Once installed, you will see "obj" folders in both your Bakery and Bakery.Tests directories._

4) _Please note that these obj folders will not be pushed to any repository, as they are presently part of the .gitignore file._

**Testing**

1) _Specific tests have already been written and can be found in the "ModelTests" folder, in the "BakeryItems.Tests.cs" file._

1) _To run the tests, run the following command in your terminal:_ ```dotnet test Bakery.Tests```

2) _Alternatively you can navigate to the testing folder by running:_ ``` cd Bakery.Tests ```

_from there, you can simply run:_  ```dotnet test```

**Running the Program**

1) _In your terminal, navigate to the Bakery folder by starting at the root directory and typing the following into your terminal:_ ```cd Bakery```

2) _Once there, you can run the program by simply entering the following in your terminal:_ ```dotnet run```

## Known Bugs 

* _No Known Bugs._  

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Ryan Ashby. All Rights Reserved.

```
MIT License

Copyright (c) 2022 Ryan Ashby.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the "Software"), to deal in the Software without restriction, including 
without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so 
subject to the following conditions:

The above copyright notice and this permission notice shall be included 
in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE 
AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY 
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

------------------------------

<a href="#">Return to Top</a>