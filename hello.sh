#If-Statement

#1 Multi-line comment
<<comment
 "Code" or "Comments"
comment

#2Multi-line comments
<<WHOAcomment
comments 
comments 
comments
WHOAcomment


Quack[0]="Quack!"
Quack[1]="Quack!"
Quack[2]="Quack! Quack!"
Quack[3]="Quack! Quack! Quack!"
Quack[4]="Quack! Quack! Quack! Qua.."

condition="true"
while [ "$condition" != "false" ]
do
        echo "Do you want to repeat? (true or false)"
        read condition
        echo "You typed: $condition"

if [ "$condition" == "duck" ]
	then
	echo "quack!"
	else
	echo "not a duck"
	fi
done




