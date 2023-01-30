
Install-Module Az
Update-Module Az

Connect-AzAccount -Subscription $subscriptionName

$region = "westus"
$resourceGroup = "aks-demoapp-rg"

Get-AzAksVersion -Location $region |

New-AzAksCluster -ResourceGroupName $resourceGroup `
                    -Name aks-demoapp-cluster `
                    -NodeCount 2 `
                    -NodeVmSize Standard_DS3_v2 `
                    -KubernetesVersion 1.24.6
