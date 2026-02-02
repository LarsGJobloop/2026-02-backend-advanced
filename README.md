# Backend Advanced

![Backend Advanced Oversikt](/docs/backend-advanced-oversikt.excalidraw.png)

## System Arkitektur

![Løsnings Arkitektur](/docs/2026-01-27-service-composition.excalidraw.png)

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

## Teknologier

- [ASP .NET](https://dotnet.microsoft.com/en-us/apps/aspnet): C# web framework
- [xUnit](https://xunit.net/?tabs=cs): C# testing library
- [PostgreSQL](https://www.postgresql.org/): Relational Database
- [Traefik](https://traefik.io/traefik): Application Proxy/Reverse Proxy/Ingress
- [Docker Desktop](https://docs.docker.com/desktop/): Local container runtime and UI
- [OCI Manifests](https://github.com/opencontainers/image-spec/blob/main/manifest.md): Standard distribution format for Containers
- [Terraform](https://developer.hashicorp.com/terraform): Imperative IaC tooling
