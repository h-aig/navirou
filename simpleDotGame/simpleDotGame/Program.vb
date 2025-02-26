Imports System

Module Program
    Sub Main(args As String())
        
        ElevenByElevenGrid()
        
        dim fillerExperienceChoice as string
        dim userInput as String
        
        Console.WriteLine("Experience or skip the sockathon day one filler?")
        Threading.Thread.Sleep(1000)
        
        Console.WriteLine("Type 1 to experience. Type 2 to skip.")
        Console.WriteLine()
        fillerExperienceChoice = console.ReadLine()
        
        do until fillerExperienceChoice = "1" or fillerExperienceChoice = "2"
            if not fillerExperienceChoice = "1" or not fillerExperienceChoice = "2"
                Console.WriteLine()
                Console.WriteLine("Just type a valid number :(")
                Threading.Thread.Sleep(500)
                Console.WriteLine("One to experience.")
                Threading.Thread.Sleep(500)
                Console.WriteLine("Two to skip.")
                Console.WriteLine()
                fillerExperienceChoice = console.ReadLine()
                
                
            End If
        Loop
        
        if fillerExperienceChoice = 1
            Console.WriteLine()
        Console.WriteLine("Simple. The game. Type 1 to continue.")
        userInput = console.readline()
        
        do until userInput = "1"
            if not userInput = "1" 
        Console.WriteLine("Just type 1...")
                userInput = console.ReadLine()
            End If
        Loop
        
        Console.WriteLine("")
        Console.WriteLine("Wasn't that hard, was it? Just like this game")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("Simple.")
            End If
        
        Console.WriteLine()
        Console.WriteLine("Rules")
        Console.WriteLine()
        
        Console.WriteLine("First select a grid size: the larger the grid, the harder and longer it'll be.")
        Threading.Thread.Sleep(2000)
        'maybe figure out how to type text out character by character?
        Console.WriteLine("Every game, you'll start in the centre of the grid.")
        Threading.Thread.Sleep(2000)
        Console.WriteLine("Select a direction using the arrow keys or WASD, and press RETURN to confirm.")
        Threading.Thread.Sleep(2000)
        Console.WriteLine("Your distance in small grid squares will be revealed, and your number of turns so far underneath.")
        Threading.Thread.Sleep(2000)
        Console.WriteLine("Use this information to select a new square with the same method, and get to the set square.")
        Threading.Thread.Sleep(2000)
        Console.WriteLine("tldr; there's a hidden square. go find it in the least turns possible. It's a treasure hunt! :)")
        Threading.Thread.Sleep(5000)
        
        console.WriteLine()
       
        Console.WriteLine("Please set the window size to large enough to fit the following line across so the grid works; after, press ANY KEY then RETURN to start.")
        ' this will be a line
        
        Console.Clear() 
        ' press m at any time to mute music - need that in there later. That's if I ever add music.
        'Console.WriteLine("Which grid size would you like?")
        ' add grid size choice
        
        elevenByElevenGrid()
        
    End Sub
    
    Sub ElevenByElevenGrid()
        
        'sound effects whilst building grid?
        
        console.WriteLine()
        Console.Write(" ")
        for a as Integer = 0 to 10
        for b as Integer = 0 to 10
            Console.Write("__")
            Threading.Thread.Sleep(10)
            Console.Write("|")
            
        Next
            Console.WriteLine()
            Console.Write(" ")
        next
        
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(16, 6)
        Console.Write("__")
        
        dim treasureLocationOkay as Boolean = False
        dim treasureLocationTop as Integer 
        dim treasureLocationLeft as Integer
        
        Console.ForegroundColor = ConsoleColor.Yellow
        
        do until treasureLocationOkay = True
            
            
            Randomize()
            treasureLocationLeft= Math.Ceiling(Rnd() * 30)
            Randomize()
            treasureLocationTop = Math.Ceiling(Rnd() * 10)
            
            
            if treasureLocationLeft mod 3 <> 0 and (treasureLocationLeft + 1) mod 3 <> 0
                treasureLocationOkay = true
            End If
           
            if treasureLocationLeft mod 3 = 0 
                treasureLocationOkay = False
            End If
                
            
            Console.SetCursorPosition(treasureLocationLeft, treasureLocationTop)
            Console.Write("__")
        
        ' find a way to force the terminal window to adjust so the grid is forced to be the right size for it to work?
        
        
        
        Console.readline()

    End Sub
    
End Module

