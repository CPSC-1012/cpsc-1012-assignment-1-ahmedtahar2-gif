# Fall 2025 Assignment 01 - Arithmetic Expressions
__Weight:__ 5% of final mark

__Submission requirements:__ On or before the deadline, commit a .NET 8 Visual Studio 2022 project to the GitHub repository. __You must commit and push to the classroom repository supplied for the assignment__; do not create your own repository. It is your responsibility to ensure that your work is in the correct repository. ___Work not in the repository will not be graded___.

## Dragon Hatchery Simulator
In this assignment, you will write a program to calculate the total number of dragon hatchlings in a magical hatchery, based on exponential egg-laying growth.

### Requirements
Your program will need to prompt the user for several inputs, namely:

- **Initial number of dragons**: the number of dragons in the hatchery at the start.

- **Growth rate**: how much the population increases per day, as a percentage. e.g. 20 would be an increase of 20% per day, 100 would be a doubling each day.

- **Number of weeks**: how many weeks have passed since the start. This should support whole numbers only.

The program will **calculate** and **display** the projected number of dragons after the given number of days. **You may assume the user only enters valid input.**

### Formula

__N = D × (1 + R)<sup>T</sup>__

Where:

- `N` = Total number of dragons after `T` days
- `D` = Initial number of dragons
- `R` = Daily growth rate as a decimal number
- `T` = Number of **days** since the outbreak began

So, for example, imagine the hatchery starts with 5 dragons, and the population increases by 50% each day. Using the provided formula, you would calculate the number of dragons after 2 weeks as follows:

N = 5 × [1 + (50 ÷ 100)]<sup>2*7</sup> 

= 5 × (1.5)<sup>14</sup> 

= 1459.646

= approximately 1460 dragons

_NOTE: the growth rate was entered as a percentage and converted to a decimal by dividing by 100. The time period was entered in weeks and converted to days by multiplying by 7.._

### Sample Run
The following shows the expected functionality for one set of inputs (your actual numbers will vary depending on the entered values):

```
Welcome to the Dragon Hatchery Simulator!  
Enter the initial number of dragons: 3  
Enter the daily growth rate (%): 20  
Enter the number of weeks: 3  

After 21 days, there will be approximately 111 dragons in the hatchery.  
```

## Submission
Commit and push your solution to your GitHub classroom assignment repository before the deadline. Ensure that your solution follows the best coding and style practices as your instructor has shown you in class. Failed adherence to the prescribed style guidelines may result in lost marks. __Your program must compile; a program that fails to compile will not be graded.__

_NOTE: push early and often to your repository to receive feedback from your instructor prior to the deadline. Your instructor will not be providing feedback for every commit every day. However, the earlier and more often you commit, the greater the chances of your instructor reviewing your work and providing constructive feedback that you can act on before the deadline._

## Rubric
| Mark | Description |
|---|---|
| 5  | **Excellent**: program passes all test cases and coding follows best practices and class standards, including appropriate data type choices. |
| 4  | **Very Good**: program passes all test cases, but coding does not follow best practices and class standards. |
| 3  | **Acceptable**: coded most the requirements and program produces the expected results for some of the test cases. |
| 2  | **Needs Work**: coded some the requirements but program fails to produce expected results. |
| 1  | **Unsatisfactory**: code does not meet any of the requirements. |
| 0  | **Not done**: code was not submitted by the due date or does not compile. |
