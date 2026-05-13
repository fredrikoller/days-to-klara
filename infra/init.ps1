$resourceGroupName = "oller-dtk"


az group create --name $resourceGroupName --location swedencentral

az deployment group create --resource-group $resourceGroupName --template-file .\main.bicep --parameters functionAppName="oller-dtk-function" storageAccountName="ollerdtkstorage" appInsightsName="oller-dtk-app-insights" 