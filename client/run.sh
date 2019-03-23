#!/bin/bash

npm run build
docker build -t client .
docker run -d -p 8080:80 client
