$package = Read-Host "Which wash package would you like (Basic, Deluxe, or Premium)?"


    if($package -eq 'basic'){
        Write-Output "You have selected the basic wash. Your total is 7 dollars."
       
        
    }
    elseif($package -eq 'deluxe'){
        Write-Output "You have selected the deluxe wash. Your total is 9 dollars."
        
    }
    elseif($package -eq 'premium'){
        Write-Output "You have selected the Premium wash. Your total is 12 dollars."
        
    }
    else{
        Write-Output "Invalid Entry. Please select either basic, deluxe, or premium!"
    }
$money = Read-Host " You may pay now. Please enter your money. Enter either 10 or 20 dollars."

    Write-Output "Thank you, you may proceed for your wash. Please take your change."

