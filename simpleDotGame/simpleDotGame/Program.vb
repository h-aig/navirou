Imports System

Module Program
    Sub Main(args As String())
        
        dim fillerExperienceChoice as string
        
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
        dim userInput as String
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
        Console.WriteLine("Game rules:")
        
        
        Console.ReadLine()
    End Sub
End Module

