if [ ! "$(docker ps -q -f name=tenon-api-postgres)" ]; then
    if [ "$(docker ps -aq -f status=exited -f name=tenon-api-postgres)" ]; then
        # cleanup
        docker rm tenon-api-postgres
    fi
    # run container with database
    docker run -d --name tenon-api-postgres -e POSTGRES_DB=tenon -e POSTGRES_USER=tenonuser -e POSTGRES_PASSWORD=Test123456 -p 5432:5432 library/postgres
fi