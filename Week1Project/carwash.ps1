

foreach($package in $args){
    if($package -match 'basic'){
        Write-Output "You have selected the basic wash. Your total is 7 dollars."
    }
    elseif($package -match 'deluxe'){
        Write-Output "You have selected the deluxe wash. Your total is 9 dollars."
    }
    elseif($package -match 'premium'){
        Write-Output "You have selected the Premium wash. Your total is 12 dollars."
    }
    else{
        Write-Output "Invalid Entry"
    }
}