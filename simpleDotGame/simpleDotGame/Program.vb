Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Devices
Imports System
Imports System.Threading


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
        ' this will be a line, no idea how to handle these exceptions :( can't force except on windows, bad things will happen.
        
        Console.Clear() 
        ' press m at any time to mute music - need that in there later. That's if I ever add music.
        'Console.WriteLine("Which grid size would you like?")
        ' add grid size choice
        
        elevenByElevenGrid()
        
    End Sub
    
    Sub ElevenByElevenGrid()
        
        
        
        
        
        Console.ForegroundColor = ConsoleColor.White
        'sound effects whilst building grid?
        
        console.WriteLine()
        Console.Write(" ")
        for a as Integer = 0 to 10
        for b as Integer = 0 to 10
            Console.Write("__")
            Threading.Thread.Sleep(10)
            Console.Write("|")
        ' wanted to add audio here + during game but the symbol couldn't be resolved for some reason :`(
            
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
            
            
            if treasureLocationLeft mod 3 <> 0 and (treasureLocationLeft + 1) mod 3 <> 0 ' makes sure it isn't in a barrier
                if treasureLocationLeft <> 16 AndAlso treasureLocationTop <> 6 or  treasureLocationLeft <> 17 AndAlso  treasureLocationTop <> 6 ' makes sure it isn't on the user starting position
                treasureLocationOkay = true
                    else
                        treasureLocationOkay = false
                    End If
                Else 
                    treasureLocationOkay = false
            End If
           
          '  if treasureLocationLeft mod 3 = 0 
           '     treasureLocationOkay = False
            'End If
                
            loop
        
            Console.SetCursorPosition(treasureLocationLeft, treasureLocationTop)
            Console.Write("__")
        ' REMOVE THE ABOVE LATER
        
        dim treasureFound as boolean = false
        Dim moveNumber As Integer = 0
        Dim numberOfSquaresAway as Integer
        dim trueTreasureLocationLeft as Integer 
        dim trueTreasureLocationTop as Integer
        dim userLocationLeft as Integer = 16
        dim userLocationTop as Integer = 6
        dim trueUserLocationLeft as Integer
        dim trueUserLocationTop as Integer
        dim noSquaresAwayLeft as Integer = Nothing
        dim noSquaresAwayTop as Integer = Nothing
        dim userDirection as Integer
        dim goingOutOfBounds as Boolean = false
        dim outOfBoundsPos(1)
        
        If treasureLocationLeft = 1 or treasureLocationLeft = 2
            trueTreasureLocationLeft = 1
        ElseIf treasureLocationLeft = 4 or treasureLocationLeft = 5
            trueTreasureLocationLeft = 2
        ElseIf treasureLocationLeft = 7 or treasureLocationLeft = 8
            trueTreasureLocationLeft = 3
        ElseIf treasureLocationLeft = 10 or treasureLocationLeft = 11
            trueTreasureLocationLeft = 4
        ElseIf treasureLocationLeft = 13 or treasureLocationLeft = 14
            trueTreasureLocationLeft = 5
        ElseIf treasureLocationLeft = 16 or treasureLocationLeft = 17
            trueTreasureLocationLeft = 6
        ElseIf treasureLocationLeft = 19 or treasureLocationLeft = 20
            trueTreasureLocationLeft = 7
        ElseIf  treasureLocationLeft = 22 or treasureLocationLeft = 23
            trueTreasureLocationLeft = 8
        ElseIf treasureLocationLeft = 25 or treasureLocationLeft = 26
            trueTreasureLocationLeft = 9
        ElseIf treasureLocationLeft = 28 or treasureLocationLeft = 29
            trueTreasureLocationLeft = 10
        ElseIf treasureLocationLeft = 31 or treasureLocationLeft = 32
            trueTreasureLocationLeft = 11
        End If
            
        trueTreasureLocationTop = treasureLocationtop
        
        If UserLocationLeft = 1 or UserLocationLeft = 2
            trueUserLocationLeft = 1
        ElseIf UserLocationLeft = 4 or UserLocationLeft = 5
            trueUserLocationLeft = 2
        ElseIf UserLocationLeft = 7 or UserLocationLeft = 8
            trueUserLocationLeft = 3
        ElseIf UserLocationLeft = 10 or UserLocationLeft = 11
            trueUserLocationLeft = 4
        ElseIf UserLocationLeft = 13 or UserLocationLeft = 14
            trueUserLocationLeft = 5
        ElseIf UserLocationLeft = 16 or UserLocationLeft = 17
            trueUserLocationLeft = 6
        ElseIf UserLocationLeft = 19 or UserLocationLeft = 20
            trueUserLocationLeft = 7
        ElseIf  UserLocationLeft = 22 or UserLocationLeft = 23
            trueUserLocationLeft = 8
        ElseIf UserLocationLeft = 25 or UserLocationLeft = 26
            trueUserLocationLeft = 9
        ElseIf UserLocationLeft = 28 or UserLocationLeft = 29
            trueUserLocationLeft = 10
        ElseIf UserLocationLeft = 31 or UserLocationLeft = 32
            trueUserLocationLeft = 11
        End If
            
        trueUserLocationTop = UserLocationTop
        
      dim firstmove as Boolean = true
      dim triggerMovement as boolean = true  
        
        do until treasureFound = True
            
            
            
            if trueTreasureLocationLeft > trueUserLocationLeft 
                noSquaresAwayLeft = trueTreasureLocationLeft - trueUserLocationLeft
                else
                    noSquaresAwayLeft = trueUserLocationLeft - trueTreasureLocationLeft
            End If
            
            if trueTreasureLocationTop > trueUserLocationTop
                noSquaresAwayTop = trueTreasureLocationTop - trueUserLocationTop
            else
                noSquaresAwayTop = trueUserLocationTop - trueTreasureLocationTop
            End If
            
            numberOfSquaresAway = noSquaresAwayLeft + noSquaresAwayTop
            
            if numberOfSquaresAway = 0 or numberOfSquaresAway = -0 ' ends game
                for i as Integer = 0 to 999
                    Console.WriteLine("YOU WIN!")
                Next
                End
            End If
            
            Console.ForegroundColor = ConsoleColor.cyan
            Console.SetCursorPosition(1, 14)
            Console.WriteLine("Move number: " & moveNumber)
            moveNumber = moveNumber + 1
            
            Console.ForegroundColor = ConsoleColor.Blue
            Console.SetCursorPosition(1, 15)
            
            if numberOfSquaresAway > -(numberOfSquaresAway)
            Console.WriteLine("No. squares away: " &  numberOfSquaresAway & " ")
                Else 
                    Console.WriteLine("No. squares away: " &  -(numberOfSquaresAway & " "))
            End If
                 
                
            
            ' remove below here
            Console.WriteLine("trueUserLocationLeft: " & trueUserLocationLeft & " ")
            Console.WriteLine("trueUserLocationTop: " & trueUserLocationTop & " ")
            Console.WriteLine("trueTreasureLocationLeft: " & trueTreasureLocationLeft & " ")
            Console.WriteLine("trueTreasureLocationTop: " & trueTreasureLocationTop & " ")
            ' remove above here
            
            userDirection = Console.ReadKey().Key
            
            if firstmove = true
                Console.SetCursorPosition(userLocationLeft, userLocationTop)
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("__")
                Else 
                    Console.SetCursorPosition(userLocationLeft - 1, userLocationTop)
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Write("__")
                End If
            
            
            
            If userDirection = ConsoleKey.W OrElse userDirection = ConsoleKey.UpArrow Then ' up
                if trueUserLocationTop <> 1
                userLocationTop = userLocationTop - 1
                    elseif trueUserLocationTop = 1
                        goingOutOfBounds = true
                        outOfBoundsPos(0) = Console.CursorLeft
                        outOfBoundsPos(1) = Console.CursorTop
                    End If
            ElseIf userDirection = ConsoleKey.A OrElse userDirection = ConsoleKey.LeftArrow Then ' left
                if trueUserLocationLeft <> 1
                userLocationLeft = userLocationLeft - 3
                elseif trueUserLocationLeft = 1
                    goingOutOfBounds = true
                    outOfBoundsPos(0) = Console.CursorLeft
                    outOfBoundsPos(1) = Console.CursorTop
                    End If
            ElseIf userDirection = ConsoleKey.S OrElse userDirection = ConsoleKey.DownArrow Then ' down
                if trueUserLocationTop <> 11
                userLocationTop = userLocationTop + 1
                elseif trueUserLocationTop = 11
                    goingOutOfBounds = true
                    outOfBoundsPos(0) = Console.CursorLeft
                    outOfBoundsPos(1) = Console.CursorTop
                    End If
            ElseIf userDirection = ConsoleKey.D OrElse userDirection = ConsoleKey.RightArrow Then ' right
                if trueUserLocationLeft <> 11
                userLocationLeft = userLocationLeft + 2
                elseif trueUserLocationLeft = 11
                    goingOutOfBounds = true
                    outOfBoundsPos(0) = Console.CursorLeft
                    outOfBoundsPos(1) = Console.CursorTop
                    End If
            ElseIf userDirection = consolekey.R
                Console.Clear()
                RegenGrid()
            End If
            
            
            
            If UserLocationLeft = 1 or UserLocationLeft = 2
                trueUserLocationLeft = 1
                UserLocationLeft = 2
            ElseIf UserLocationLeft = 4 or UserLocationLeft = 5
                trueUserLocationLeft = 2
                UserLocationLeft = 5
            ElseIf UserLocationLeft = 7 or UserLocationLeft = 8
                trueUserLocationLeft = 3
                UserLocationLeft = 8
            ElseIf UserLocationLeft = 10 or UserLocationLeft = 11
                trueUserLocationLeft = 4
                UserLocationLeft = 11
            ElseIf UserLocationLeft = 13 or UserLocationLeft = 14
                trueUserLocationLeft = 5
                UserLocationLeft = 14
            ElseIf UserLocationLeft = 16 or UserLocationLeft = 17
                trueUserLocationLeft = 6
                UserLocationLeft = 17
            ElseIf UserLocationLeft = 19 or UserLocationLeft = 20
                trueUserLocationLeft = 7
                UserLocationLeft = 20
            ElseIf  UserLocationLeft = 22 or UserLocationLeft = 23
                trueUserLocationLeft = 8
                UserLocationLeft = 23
            ElseIf UserLocationLeft = 25 or UserLocationLeft = 26
                trueUserLocationLeft = 9
                UserLocationLeft = 26
            ElseIf UserLocationLeft = 28 or UserLocationLeft = 29
                trueUserLocationLeft = 10
                UserLocationLeft = 29
            ElseIf UserLocationLeft = 31 or UserLocationLeft = 32
                trueUserLocationLeft = 11
                UserLocationLeft = 32
            End If
            
            trueUserLocationTop = UserLocationTop
            
            if firstmove <> true and goingOutOfBounds = false
           Console.SetCursorPosition(userLocationLeft - 1, userLocationTop)
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.Write("__")

                ElseIf  firstmove = true and userDirection = ConsoleKey.RightArrow 
                    Console.SetCursorPosition(userLocationLeft + 1, userLocationTop)
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.Write("__")
                    
            ElseIf  firstmove = true and userDirection = ConsoleKey.D
                Console.SetCursorPosition(userLocationLeft + 1, userLocationTop)
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.Write("__")
                    
                    ElseIf  firstmove = true
                        Console.SetCursorPosition(userLocationLeft - 1, userLocationTop)
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.Write("__")
                    end if 
            
            if firstmove = True  and userDirection = ConsoleKey.RightArrow 
                userLocationLeft = userLocationLeft + 2
            End If
            
            if firstmove = True  and userDirection = ConsoleKey.D
                userLocationLeft = userLocationLeft + 2
            End If
            
            if trueTreasureLocationLeft > trueUserLocationLeft 
                noSquaresAwayLeft = trueTreasureLocationLeft - trueUserLocationLeft
            else
                noSquaresAwayLeft = trueUserLocationLeft - trueTreasureLocationLeft
            End If
            
           
            if firstmove = true and userDirection = ConsoleKey.RightArrow
            
                trueUserLocationLeft = 7
                
            if trueTreasureLocationLeft > trueUserLocationLeft 
                noSquaresAwayLeft = trueTreasureLocationLeft - trueUserLocationLeft
            else
                noSquaresAwayLeft = trueUserLocationLeft - trueTreasureLocationLeft
            End If
            
            if trueTreasureLocationTop > trueUserLocationTop
                noSquaresAwayTop = trueTreasureLocationTop - trueUserLocationTop
            else
                noSquaresAwayTop = trueUserLocationTop - trueTreasureLocationTop
            End If
            
            numberOfSquaresAway = noSquaresAwayLeft + noSquaresAwayTop
            
                Console.SetCursorPosition(1, 15)
                
            if numberOfSquaresAway > -(numberOfSquaresAway)
                Console.WriteLine("No. squares away: " &  numberOfSquaresAway)
            Else 
                Console.WriteLine("No. squares away: " &  -(numberOfSquaresAway))
            End If
                
                
            
            End If
            
            if goingOutOfBounds = true
                
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.SetCursorPosition(outOfBoundsPos(0) - 2, outOfBoundsPos(1))
                Console.WriteLine("__")
                
                Console.SetCursorPosition(1, 20) ' change this to 17 after removing debugging outputs
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("That move would take you out of bounds! Inputs frozen for 1s (stackable with further inputs)!") 'anyone know how to make it precise?
                Threading.Thread.Sleep(1000)
                Console.SetCursorPosition(1, 20) ' change this as well!
                Console.WriteLine("                                                                         ")
                
                moveNumber = moveNumber - 1
                ' beep boop incorrect noise??
                goingOutOfBounds = false
            End If
            
            firstmove = false
            
            
            
            
            
        Loop
        
        Console.ReadLine()

    End Sub
    
    Function RegenGrid
        ElevenByElevenGrid()
    End Function
    
    
End Module

' I should add a timer lol do until treasureFound = True
            
'Console.ForegroundColor = ConsoleColor.cyan
'Console.SetCursorPosition(1, 14)
'Console.WriteLine("Move number: " & moveNumber)
'moveNumber = moveNumber + 1
            
'Loop
