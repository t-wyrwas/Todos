#!/bin/bash

docker build -t restservice .
docker run -d -p 8081:80 restservice
