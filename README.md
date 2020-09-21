# What is Microservice ?

Microservices are architectures that divide the services provided in a large-scale project into small-scale services.

# How Microservices Communicate ?

RabbitMQ messaging technology was used in this project for microservices to communicate with each other.
With the help of EventBus, a message is sent from one service to another. It includes SendCommand, Publish and Subscribe methods in EventBus.


## Send Command

The Send Command method is the first step in getting the command containing the message content to RabbitMQ queue.

## Publish

The Publish method queues the command on the RabbitMQ server. The microservice to which the message was sent will then read the message from this queue.

## Subscribe

The microservice to which the message is sent "consumes" the message from the queue to which it is subscribed.

![alt text](https://github.com/SadettinKepenek/.Net-Core-Microservices/blob/master/RabbitMQ_EventBus.jpg?raw=true)
