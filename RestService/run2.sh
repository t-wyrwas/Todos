#!/bin/bash

docker build -t restservice .
docker run -p 8081:80 restservice
