# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

The purpose of Random Name Generator is to provide entertainment to the user by generating funny names. It accepts input from the user by letting them specify the number of names they want to generate. After accepting the number of names to generate, the program writes a list of random names to the console.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

With an input of the number of random names wanted, the program generates the given positive number of names back (First Middle Last).

### 3a iii.

Describes the input and output of the program demonstrated in the video.

With an input of a number of random names wanted, the programs returns the desired positive number of  names.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
    List<string> firstNames = new List<string>();
                firstNames.Add("Chad");
                firstNames.Add("Sawyer");
                firstNames.Add("Daniel");
                firstNames.Add("Rose");
                firstNames.Add("Black");
                firstNames.Add("White");
                firstNames.Add("Master");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
    int firstIndex = generator.Next(0, firstNames.Count); 
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

"The list is stored in the variable {firstName}"

### 3b iv.

Describes what the data contained in the list represents in your program

firstName represents the first names generated in the random name.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

firstNames allows for simplicity in the program because without storing multiple values in firstNames, there would need to be a set amount of first names with their own variables each time.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int GetPositiveInt(string prompt)
        {
            if (prompt == null)
            {
                throw new Exception("Cannot display a null prompt");
            }
            int positiveNumber;

            do
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                bool validNumber = int.TryParse(input, out positiveNumber);

                if (validNumber == false)
                {
                    Console.Error.WriteLine($"you did not enter a valid number");
                }
                else if (positiveNumber <= 1)
                {
                    Console.WriteLine("Your number was not a positive number");
                }
            }
            while (positiveNumber <= 1);
            return positiveNumber;
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
int num = GetPositiveInt("How many names would you like to generate");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a list of first, middle, and last names, generate a random name using one entry from each list.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1) Create a random number generator
2) Generate a random number, firstIndex, between 0 and firstNames.Count
3) Generate a random number, midIndex, between 0 and midNames.Count
4) Generate a random number, lastIndex, between 0 and lastNames.Count
5) Combine the names together
6) firstNames[firstIndex] + " " + midNames[midIndex] + " " + lastNames[lastIndex];
7) Return the name

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

if prompt is equal to null, the body of the if statement will execute

Second call:

if prompt is not equal to null, the body of the if statement will not execute

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
if (prompt == null)
            {
                throw new Exception("Cannot display a null prompt");
            }
if prompt is equal to null

Condition(s) tested by the second call:

if (prompt == null)
            {
                throw new Exception("Cannot display a null prompt");
            }
if prompt is equal to null
### 3d iii.

Result of the first call:

prompt is equal null so an exception is thrown

Result of the second call:

prompt is not equal null so no exception is thrown