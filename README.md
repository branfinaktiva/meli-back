# Operación Fuego de Quasar
## Brandon Steven Montoya Usuga

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

A continuación se realizará una descripcion tecnica de la solucion desarrollada para la prueba tecnica de MELI Fuego de Quasar


## Estructura del la solución
| Pre Requisitos |
| ------ |
| [Visual Studio 2022](https://code.visualstudio.com/download) | [Visual]|
| [Net6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) |

Nota: Tambien se puede utilizar [Visual Studio Code](https://code.visualstudio.com/download)

## Ejecución
```sh
cd MeliBackQuasar
dotnet build
dotnet run
Open Browser http://localhost:5175/swagger/index.html
```

## Arquitectura
El proyecto esta compuesto por una arquitectura de 2 Capas: Dominio, Presentación en la cual se realizara una descripción de cada una de las capas
## Dominio 🔩
Esta capa comprende todo lo relacionado con la logica que negocio del proyecto.
La cual tiene dos Servicios:
- LocationService: Este servicio esta encargado de realizar toda la logica para triangular la posición de la nave.
- MessageService: Este servicio se encarga de realizar la logica para encontrar el mensaje de auxilio.

## Presentación 🛠️
Esta capa expone los endpoint encargados de recibir las peticiones de la nave portacarga.

 Servicios

* /topsecret/ - Este Servicio recibe el siguiente formato:
    ```
    {
      "satellites": [
        {
          "name": "kenobi",
          "distance": 100,
          "message": [
            "este", "", "", "mensaje", ""
          ]
        },
        {
          "name": "skywalker",
          "distance": 115.5,
          "message": [
            "", "es", "", "", "secreto"
          ]
        },
        {
          "name": "sato",
          "distance": 142.7,
          "message": [
            "este", "", "un", "", ""
          ]
        }
      ]
    }
    ```
    Respuesta Code 200
    ```
        {
        "position": {
            "x": -487,
            "y": 1557,
            "r": 0
        },
        "message": "este es un mensaje secreto "
    }
    ```
    Respuesta Code 400
        No hay información suficiente
    
* /topsecret_split/{name} - Este Servicio recibe el siguiente formato:
    ```
    {
      "distance": 100,
      "message": [
        "", "este","es","","mensaje"
      ]
    }
    ```
    
## Hosting
El proyecto se encuentra alojado en un Google App Engine utilizando la siguiente Guia [Create-app](https://cloud.google.com/appengine/docs/flexible/dotnet/create-app)

![Screenshot](https://github.com/branmous/meli-back/blob/main/images/projectName.png?raw=true)

## Docker

Para la publicación del proyecto se ejecutaron los siguientes comandos de docker

```sh
cd MeliBackQuasar
docker build -t mebackquasar-image  -f Dockerfile .
docker tag mebackquasar-image us-central1-docker.pkg.dev/meliappback/meli-app-api-repo/mebackquasar-image:latest
docker push us-central1-docker.pkg.dev/meliappback/meli-app-api-repo/mebackquasar-image:latest
```

## Proyecto

![Screenshot](https://github.com/branmous/meli-back/blob/main/images/project.png?raw=true)



Puede ingresar dando click [aquí](https://mebackquasar-image-zeityctk4q-uc.a.run.app/swagger/index.html)
