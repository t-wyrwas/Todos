#!/bin/bash

docker build -t client .
docker run -d -p 8080:80 client
