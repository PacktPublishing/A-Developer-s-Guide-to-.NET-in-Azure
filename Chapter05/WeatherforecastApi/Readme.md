# Deploying the docker image to Azure Container apps

## Creating docker image

1. First we need to execute the command to create the docker image - `docker build -t Weatherforecastapi .`

2. To check the created image working, we can execute the following command - `docker run -p 8080:80 weatherforecastapi` and browse http://localhost:8080/weatherforecast - If it is returning a JSON output, docker image is working fine.

## Creating Azure container app in Azure

1. Create Azure resource group - `az group create --name chapter05 --location centralus`
2. Create Azure container registry - `az acr create --resource-group chapter05 --name packtbookchapter05  --sku Basic --admin-enabled true `
3. Change tag of the docker image to publish to Azure container registry - `docker tag weatherforecastapi:latest packtbookchapter05.azurecr.io/weatherforecastapi:latest`
4. Login to Azure container registry - `az acr login --name packtbookchapter05`
5. Publish the docker image to Azure container registry - `docker push packtbookchapter05.azurecr.io/weatherforecastapi:latest`
6. Create container apps environment - `az containerapp env create --name chapter05env --resource-group chapter05 --location centralus`
7. Create Azure container app and configure ingress - `az containerapp create  --name webapi --resource-group chapter05 --environment chapter05env --image packtbookchapter05.azurecr.io/weatherforecastapi:latest --target-port 80 --ingress 'external'  --registry-server packtbookchapter05.azurecr.io --query properties.configuration.ingress.fqdn `
