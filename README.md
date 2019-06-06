# WebApiCoreWithJWT
Implementação de WebAPI em .NET Core 2.1 com autorização JWT

## Utilização via postman
Autenticar (get token)
```sh
POST URL =>  https://localhost:44319/users/authenticate
BODY => {"Username": "user", "Password":"user"} OR {"Username": "admin", "Password":"admin"}
```
Get Usuario (Somente admin)
```sh
GET => https://localhost:44319/users
HEADER => KEY: Authorization - VALUE: Bearer (TOKEN) 
```
Get Usuario (user 1 somente admin)
```sh
GET => https://localhost:44319/users/1 OR https://localhost:44319/users/2
HEADER => KEY: Authorization - VALUE: Bearer (TOKEN) 
```
