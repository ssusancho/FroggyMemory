# Froggy Memory Written Response

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

Froggy Memory is an interactive game where the player will try their best to follow a computer generated pattern.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

My video demonstrates that my program makes the player choose the difficulty they want: easy, medium, hard. Then Froggy Memory makes the player copy a pattern based on a random computer-generated pattern including the number of frogs based off of what difficulty. they picked. First, the computer indicates one of the four options, and then the player will choose the option that the computer displayed. The pattern will build up with each turn until the player messes up. After this, the game will end and a play again button appears. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

For my start scene, my program receives an input of the button that the player chooses and then outputs the corresponding scene with the correct number of buttons. In my game scene, my program receives an input of the button that my player chooses and then outputs with the program continuing the game or switching to the game over scene. My game over scene receives an input of the button that my player chooses and then outputs to the start scene. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> colors = new List<string>();
foreach (FrogColor c in actualFrogs)
            {
                colors.Add(c.color);
            }
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
            System.Random generator = new System.Random();
            int ix = generator.Next(0, colors.Count);
            string color = colors[ix];
            Sequence.Add(color);
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response
The list is stored in the variable "colors"

### 3b iv.

Describes what the data contained in the list represents in your program

This list keeps track of the possible colors that can be generated in the sequence.  

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list allows me to easily access the specified colors for each difficulty. If I did not have this list, I would have to make an if statement for each of my difficulties and identify which colors should be shown or not be shown making this unmanageable. Using this list allows me to add more difficulties in my game easily. 

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
 public void HighlightFrog(string frog)
        {
            foreach (FrogColor obj in blurs)
            {
                if (obj.color == frog)
                {
                    obj.gameObject.SetActive(true);

                }
                else
                {
                    obj.gameObject.SetActive(false);

                }
            }

        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
HighlightFrog(color);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

HighlightFrog accepts a string of frogs. The blur that matches the frog color will be set active. When calling this program, the highlights display the sequence of colors.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

   * For each frog game object in blurs
     * Check if the blur matches the input parameter, color
     * if it does, turn on that blur
     * Else set the blur inactive

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:
HighlightFrog("blue");


Second call:
HighlightFrog("none");

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
If I am testing if the frog "blue" will activate if statement.

Condition(s) tested by the second call:
I am testing if the frog "none" will activate the else statement. 


### 3d iii.

Result of the first call:

The result of calling "blue" will activate the highlighted color based on the color of the frog.

Result of the second call:

The result of calling "none" will not activate anything. 