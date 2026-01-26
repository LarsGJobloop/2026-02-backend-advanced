# Backend Advanced

![Backend Advanced Oversikt](/docs/backend-advanced-oversikt.excalidraw.png)

## Problemstilling

Vi trenger en API Tjeneste some kan lagre minner.

![Løsnings skisse](/docs/løsnings-skisse.png)

## Leveranse

Container Teknologi er det som er mest vanlig å  bruke for å lever i fra seg programmer i Web og Sky miljøer (lager du Apper/Native programmer så har vær platform sin "greie").

### Verktøy

- Docker Desktop (lokalt GUI program for å administrere containere)
- Docker CLI (kommer som del av Docker Desktop)
- Dockerfile: Oppskrift for å lage ett container bilde

#### Kommandoer

- Bygge et container bilde og lagre i det lokale registeret

    ```sh
    docker build --tag <directory-path>
    ```

- Kjøre et container bilde

    ```sh
    docker run <image-tag>
    ```

- Kjøre et container bilde og "koble" container porten til vertsystemets port

    ```sh
    docker run --publish <host-port>:<container-port> <image-tag>
    ```

## Tester

![Hva er tester?](/docs/hva-er-tester.excalidraw.png)
