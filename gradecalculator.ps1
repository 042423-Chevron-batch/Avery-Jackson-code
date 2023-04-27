
foreach($grade in $args){
  if($grade -gt 89){
    Write-Output "$grade :A"
  } 
  elseif(($grade -gt 79) -and ($grade -lt 90)){
    Write-Output "$grade : B"
  }
  elseif(($grade -gt 69) -and ($grade -lt 80)){
    Write-Output "$grade :C"
  }
  elseif(($grade -gt 59) -and ($grade -lt 70)){
    Write-Output "$grade :D"
  }
  elseif(($grade -lt 61) -and ($grade -ge 0)){
    Write-Output "$grade :F"
  }
  else{
    Write-Output "Invalid entry"
  }
}