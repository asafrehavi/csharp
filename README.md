# csharp
# RabbitMq C# example 
<br />
#install rabbit mq by the instructions at https://www.rabbitmq.com/install-windows.html
<br />
#run program cs
<br />
#now you can see at the console of the recieve.js the message that send by send.js
<br />
The sender class send messages to nodejs every 10 seconds
<br />
The reciever waiting for events from c# 
<br />
The nodejs side exist at the nodejs repo
<br />
<b>
In order to set the management url on  we should  do the following steps 
</b>
<br />
go to the rabbitmq install  folder (sbin) folder 
<br />
run the follwing command
<br />
rabbitmq-plugins.bat enable rabbitmq_management
<br />
after run this command restart rabbitmq service (windows)
<br />
for more information you can see good medium article:
<br />
https://medium.com/geekculture/installing-rabbitmq-on-windows-4411f5114a84

#thanks to https://www.rabbitmq.com/tutorials/tutorial-one-javascript.html for the example
