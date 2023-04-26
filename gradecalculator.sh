#!/usr/bin/bash

for grade in "$@"
do 
	if [ $grade -gt 89 ]
	then
		echo "A"
	elif [[ $grade -gt 79 && $grade -lt 90 ]]
	then 
		echo "B"
	elif [[ $grade -gt 69 && $grade -lt 80 ]]
	then 
		echo "C"
	elif [[ $grade -gt 59 && $grade -lt 70 ]]
	then 
		echo "D"
	elif [[ $grade -lt 61 && $grade -ge 0 ]]
	then 
		echo "F"
	else 
		echo " Invalid entry"
	fi
done

