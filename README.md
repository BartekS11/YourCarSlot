# YourCarSlot
## _Web API .NET 6 C# application_

YourCarSlot is an application to manage parking space in company. It is created in .NET 6 Web API created with clean architecutre, CQRS, Mediator behavioral design pattern. YCS is using mssql as database hosted in docker container. In application there are performance tests, unit tests, integration tests.

## Run App
    docker compose up && ./start.sh
- Also available script to run dotnet app in release configuration (./start-release.sh)


## Run Tests
    ./tests.sh

# REST API

Sample REST API request, at the moment only ReservationRequest endpoint is not secured by authorization (feature is commented but implemented). Basic endpoints:
ParkingSlot - to get info and manage parking slots,
Reservation Request - to manage reservations,
Vehicle - to create and manage vehicles,
User - to manage users.


### Request

`GET /api/ReservationRequest`

    curl -X 'GET' \ 'https://localhost:7276/api/ReservationRequest' \ -H 'accept: text/plain'

### Response

    [
      {
        "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        "parkingSlotRequesting": 0,
        "reserved": true,
        "plateNumber": "string",
        "userRequestingId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
        "createdAt": "2023-02-26T20:11:30.579Z",
        "dateModified": "2023-02-26T20:11:30.579Z"
      }
    ]

# TODO:
Create more CQRS commands and queries to add new features, split database to store auth feature and users seperately, write more tests, create frontend.
