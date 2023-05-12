  static string catAndMouse(int x, int y, int z)
    {
        //Start both Cat A and Cat B location at 0
            int catALocation = 0;
            int catBLocation = 0;
            // X is Cat A location , y is Cat B location, z is the mouse location
            // if Cat A location is less than the mouse location subtract the mouse location from Cat A location
            // if Cat A location is more than the mouse location subtract Cat A location from the mouse location 
        
            if(x < z)
            {
                catALocation = z - x;
            }
          if(x > z)
            {
                catALocation = x - z;
            }
        // Do the same for Cat B, that is done for Cat A
            if(y < z)
            {
                catBLocation = z - y;
            }
           
            if(y > z)
            {
                catBLocation = y - z;
            }
        // If Cat B location is more than Cat A location that means Cat A caught the mouse. Return "Cat A"
            if(catBLocation > catALocation)
            {
                return "Cat A";
            }
        //If Cat A location is more than Cat B location that means Cat B caught the mouse. Return "Cat B"
            if(catALocation > catBLocation)
            {
                return "Cat B";
            }
        // else the Cats are at the same location and are fighting so the mouse gets away. Return "Mouse C"    
            else
            {
                return "Mouse C";
            }

    }

