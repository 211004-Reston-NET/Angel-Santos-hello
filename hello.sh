echo Hello
echo World

msg="Hello World!"

echo $msg

condition="true"
while [ "$condition" != "false" ]
do
	echo "Do you want to repeat? (true or false)"
	read condition
	echo "You typed: $condition"
done

#if-statement with shell
