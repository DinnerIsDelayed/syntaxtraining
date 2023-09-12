using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice.Categories 
{
    internal class AzureCommandLine 
    {
        public string type = "AzureCommandLine";
        public List<Problem> problems = new List<Problem>();
        public List<Problem> savedProblems = new List<Problem>();

        internal AzureCommandLine()
        {
            problems = new List<Problem>()
            {
                // How to login into Azure Command Line
                new Problem("How do you login into Azure Command Line?", "az login", "The 'az login' command opens a web page asking you to enter your Azure login credentials.\nAfter successful authentication, the CLI can perform tasks that require authentication such as resource creation, modification, and deletion."),

                // How to list all Azure subscriptions
                new Problem("How do you list all Azure subscriptions?", "az account list", "The 'az account list' command retrieves all the Azure subscriptions associated with your account.\nThis is useful for identifying which subscriptions you can deploy resources into."),

                // How to set a default Azure subscription
                new Problem("How do you set a default Azure subscription?", "az account set --subscription 'Subscription_Name_or_ID'", "The 'az account set' command sets a particular Azure subscription as your working context.\nThis is important if you have multiple subscriptions and need to specify which one to use for subsequent commands."),

                // How to create a new Azure Resource Group
                new Problem("How do you create a new Azure Resource Group?", "az group create --name 'ResourceGroupName' --location 'Location'", "The 'az group create' command creates a new Azure Resource Group.\nResource Groups are essentially containers that hold related resources for an Azure solution.\nThey help in logically organizing and managing your Azure resources."),

                // How to list all Resource Groups
                new Problem("How do you list all Resource Groups?", "az group list", "The 'az group list' command lists all the Resource Groups in your Azure subscription.\nKnowing your Resource Groups is essential for understanding how your resources are organized."),

                // How to create a new Virtual Machine
                new Problem("How do you create a new Virtual Machine?", "az vm create --name 'VMName' --resource-group 'ResourceGroupName' --image 'ImageName'", "The 'az vm create' command initializes a new Virtual Machine (VM) in your Azure environment.\nVMs are the backbone of many services, allowing you to run applications and host services in a cloud environment.\nSpecify the name, associated Resource Group, and OS image for the new VM."),

                // How to list all Virtual Machines
                new Problem("How do you list all Virtual Machines?", "az vm list", "The 'az vm list' command enumerates all Virtual Machines under your Azure subscription.\nIt's useful to see the operational status, size, and other properties of your VMs."),

                // How to create a new Azure Blob Storage account
                new Problem("How do you create a new Azure Blob Storage account?", "az storage account create --name 'StorageAccountName' --resource-group 'ResourceGroupName' --location 'Location' --sku 'StorageSKU'", "The 'az storage account create' command creates a new Azure Blob Storage account.\nBlob Storage is designed to store unstructured data like documents, images, and videos.\nThe command requires the storage account name, resource group, data center location, and the performance tier (SKU)."),

                // How to list all Azure Blob Storage accounts
                new Problem("How do you list all Azure Blob Storage accounts?", "az storage account list", "The 'az storage account list' command lists all the Azure Blob Storage accounts associated with your Azure subscription.\nThis helps you manage and allocate storage resources."),

                // How to create a new Azure SQL Database
                new Problem("How do you create a new Azure SQL Database?", "az sql db create --name 'DatabaseName' --resource-group 'ResourceGroupName' --server 'ServerName'", "The 'az sql db create' command establishes a new Azure SQL Database.\nAzure SQL Databases are fully managed relational databases that support SQL queries.\nYou need to specify the database name, the server where it will reside, and the resource group."),

                // How to list all Azure SQL Databases
                new Problem("How do you list all Azure SQL Databases?", "az sql db list --resource-group 'ResourceGroupName' --server 'ServerName'", "The 'az sql db list' command enumerates all SQL Databases within a particular Azure server and resource group.\nThis is useful for managing your databases and understanding your Azure SQL Database resources."),

                // How to create a new Azure Kubernetes Service
                new Problem("How do you create a new Azure Kubernetes Service?", "az aks create --resource-group 'ResourceGroupName' --name 'ClusterName'", "The 'az aks create' command provisions a new Azure Kubernetes Service (AKS) cluster.\nAKS is a managed Kubernetes service used for deploying, managing, and scaling containerized applications.\nThe command requires you to specify a resource group and cluster name."),

                // How to list all Azure Kubernetes Service clusters
                new Problem("How do you list all Azure Kubernetes Service clusters?", "az aks list", "The 'az aks list' command shows all AKS clusters under your Azure subscription.\nThis helps in managing your clusters and understanding their configurations and statuses."),

                // How to create a new Azure App Service Plan
                new Problem("How do you create a new Azure App Service Plan?", "az appservice plan create --name 'PlanName' --resource-group 'ResourceGroupName' --sku 'SKUNAME'", "The 'az appservice plan create' command creates a new Azure App Service Plan.\nAn App Service Plan defines the region and the amount of compute resources for hosting web apps.\nYou have to specify the name, resource group, and SKU (performance tier)."),

                // How to list all Azure App Services
                new Problem("How do you list all Azure App Services?", "az webapp list", "The 'az webapp list' command lists all the Azure Web Apps under your Azure subscription.\nIt's a useful command for understanding the web applications you have deployed, their statuses, and configurations."),

                // How to upload a file to Azure Blob Storage
                new Problem("How do you upload a file to Azure Blob Storage?", "az storage blob upload --account-name 'StorageAccountName' --container-name 'ContainerName' --name 'BlobName' --file 'FilePath'", "The 'az storage blob upload' command uploads a file to a specific blob container in Azure Blob Storage.\nThis is useful for storing files and data that can be accessed or downloaded later.\nSpecify the storage account name, container name, blob name, and the path to the file."),

                // How to delete an Azure Resource Group
                new Problem("How do you delete an Azure Resource Group?", "az group delete --name 'ResourceGroupName' --yes --no-wait", "The 'az group delete' command removes an Azure Resource Group and all the resources it contains.\nUse this command with caution as it will permanently delete all resources in the group.\nThe --yes flag confirms your intention, and the --no-wait flag allows the operation to run asynchronously."),

                // How to start an Azure Virtual Machine
                new Problem("How do you start an Azure Virtual Machine?", "az vm start --name 'VMName' --resource-group 'ResourceGroupName'", "The 'az vm start' command starts a previously stopped Azure Virtual Machine.\nThis is useful when you want to resume operations on a VM that has been halted.\nSpecify the VM's name and its associated resource group."),

                // How to stop an Azure Virtual Machine
                new Problem("How do you stop an Azure Virtual Machine?", "az vm stop --name 'VMName' --resource-group 'ResourceGroupName'", "The 'az vm stop' command stops a running Azure Virtual Machine.\nUse this when you want to halt all processes and possibly deallocate resources.\nSpecify the VM's name and its associated resource group."),

                // How to list all resource groups in a subscription
                new Problem("How do you list all resource groups in a subscription?", "az group list", "The 'az group list' command lists all resource groups available in the Azure subscription.\nResource groups are containers that hold related resources for an Azure solution."),

                // How to delete a resource group
                new Problem("How do you delete a resource group?", "az group delete --name RESOURCE_GROUP_NAME", "The 'az group delete' command deletes a resource group and all its contained resources.\nThe '--name' flag specifies the name of the resource group to be deleted."),

                // How to create an Azure SQL Database
                new Problem("How do you create an Azure SQL Database?", "az sql db create --name DB_NAME --server SERVER_NAME --resource-group RESOURCE_GROUP_NAME --service-objective SLO", "The 'az sql db create' command creates a new Azure SQL Database.\nYou need to specify the database name, server name, resource group, and service objective (SLO)."),

                // How to list all virtual machines in a subscription
                new Problem("How do you list all virtual machines in a subscription?", "az vm list", "The 'az vm list' command lists all virtual machines in an Azure subscription.\nThis helps you manage and view your existing VM instances."),

                // How to stop a running virtual machine
                new Problem("How do you stop a running virtual machine?", "az vm stop --name VM_NAME --resource-group RESOURCE_GROUP_NAME", "The 'az vm stop' command stops a running virtual machine.\nYou need to specify the VM name and the resource group it belongs to."),

                // How to start a stopped virtual machine
                new Problem("How do you start a stopped virtual machine?", "az vm start --name VM_NAME --resource-group RESOURCE_GROUP_NAME", "The 'az vm start' command starts a stopped virtual machine.\nYou need to specify the VM name and the resource group it belongs to."),

                // How to create a virtual network
                new Problem("How do you create a virtual network?", "az network vnet create --name VNET_NAME --resource-group RESOURCE_GROUP_NAME --address-prefix ADDRESS_PREFIX", "The 'az network vnet create' command creates a new virtual network.\nYou need to specify the virtual network name, resource group, and address prefix."),

                // How to add a rule to a Network Security Group (NSG)
                new Problem("How do you add a rule to a Network Security Group (NSG)?", "az network nsg rule create --name RULE_NAME --nsg-name NSG_NAME --priority PRIORITY --resource-group RESOURCE_GROUP_NAME", "The 'az network nsg rule create' command adds a new rule to a Network Security Group (NSG).\nYou need to specify the rule name, NSG name, priority, and resource group."),

                // How to list all available Azure subscriptions
                new Problem("How do you list all available Azure subscriptions?", "az account list", "The 'az account list' command lists all Azure subscriptions that you can use.\nThis is useful for managing and switching between different Azure subscriptions."),

                // How to set a default subscription
                new Problem("How do you set a default subscription?", "az account set --subscription SUBSCRIPTION_ID_OR_NAME", "The 'az account set' command sets the default subscription to use.\nThe '--subscription' flag specifies which subscription to set as the default."),

                // How to upload a file to a blob storage container
                new Problem("How do you upload a file to a blob storage container?", "az storage blob upload --account-name ACCOUNT_NAME --container-name CONTAINER_NAME --name BLOB_NAME --file FILE_PATH", "The 'az storage blob upload' command uploads a file to a blob storage container.\nYou need to specify the storage account name, container name, blob name, and the path to the file."),

                // How to download a file from a blob storage container
                new Problem("How do you download a file from a blob storage container?", "az storage blob download --account-name ACCOUNT_NAME --container-name CONTAINER_NAME --name BLOB_NAME --file FILE_PATH", "The 'az storage blob download' command downloads a file from a blob storage container.\nYou need to specify the storage account name, container name, blob name, and the file path where the blob will be downloaded to."),

                // How to delete a blob from a storage container
                new Problem("How do you delete a blob from a storage container?", "az storage blob delete --account-name ACCOUNT_NAME --container-name CONTAINER_NAME --name BLOB_NAME", "The 'az storage blob delete' command deletes a blob from a storage container.\nYou need to specify the storage account name, container name, and blob name."),

                // How to list all blobs in a container
                new Problem("How do you list all blobs in a container?", "az storage blob list --account-name ACCOUNT_NAME --container-name CONTAINER_NAME", "The 'az storage blob list' command lists all blobs in a specific container.\nYou need to specify the storage account name and container name."),

                // How to create an Azure Function
                new Problem("How do you create an Azure Function?", "az functionapp create --name FUNCTION_NAME --storage-account STORAGE_ACCOUNT --resource-group RESOURCE_GROUP_NAME --consumption-plan-location LOCATION", "The 'az functionapp create' command creates a new Azure Function.\nYou need to specify the function name, storage account, resource group, and location for the consumption plan."),

                // How to deploy code to an Azure Function
                new Problem("How do you deploy code to an Azure Function?", "az functionapp deployment source config-zip --name FUNCTION_NAME --resource-group RESOURCE_GROUP_NAME --src SRC_DIRECTORY", "The 'az functionapp deployment source config-zip' command deploys code to an Azure Function.\nYou need to specify the function name, resource group, and the source directory where the code resides."),

                // How to create an Azure App Service Plan
                new Problem("How do you create an Azure App Service Plan?", "az appservice plan create --name PLAN_NAME --resource-group RESOURCE_GROUP_NAME --sku SKU", "The 'az appservice plan create' command creates a new Azure App Service Plan.\nYou need to specify the plan name, resource group, and the SKU (pricing tier)."),

                // How to delete an Azure App Service Plan
                new Problem("How do you delete an Azure App Service Plan?", "az appservice plan delete --name PLAN_NAME --resource-group RESOURCE_GROUP_NAME", "The 'az appservice plan delete' command deletes an existing Azure App Service Plan.\nYou need to specify the plan name and the resource group it belongs to."),

                // How to list all Kubernetes clusters in a subscription
                new Problem("How do you list all Kubernetes clusters in a subscription?", "az aks list", "The 'az aks list' command lists all Azure Kubernetes Service (AKS) clusters in a subscription.\nThis is useful for managing your Kubernetes clusters in Azure."),

                // How to delete a Kubernetes cluster
                new Problem("How do you delete a Kubernetes cluster?", "az aks delete --name CLUSTER_NAME --resource-group RESOURCE_GROUP_NAME --yes --no-wait", "The 'az aks delete' command deletes an existing Azure Kubernetes Service (AKS) cluster.\nYou need to specify the cluster name and the resource group it belongs to. The '--yes' flag confirms the action, and '--no-wait' makes the operation non-blocking."),

                // How to get information about a specific resource group
                new Problem("How do you get information about a specific resource group?", "az group show --name RESOURCE_GROUP_NAME", "The 'az group show' command retrieves detailed information about a specific resource group.\nYou need to specify the name of the resource group you want to query."),

                // How to update tags for a resource group
                new Problem("How do you update tags for a resource group?", "az group update --name RESOURCE_GROUP_NAME --set tags.KEY=VALUE", "The 'az group update' command allows you to update the properties of a resource group.\nUsing the '--set' flag with 'tags.KEY=VALUE' allows you to update the tags associated with the resource group."),

                // How to create an Azure storage account
                new Problem("How do you create an Azure storage account?", "az storage account create --name ACCOUNT_NAME --resource-group RESOURCE_GROUP_NAME --location LOCATION --sku SKU_NAME", "The 'az storage account create' command creates a new Azure storage account.\nYou need to specify the account name, resource group, location, and SKU (performance tier)."),

                // How to list all storage accounts in a subscription
                new Problem("How do you list all storage accounts in a subscription?", "az storage account list", "The 'az storage account list' command lists all storage accounts in the Azure subscription.\nThis is useful for managing and understanding your existing storage solutions."),

                // How to create an Azure Key Vault
                new Problem("How do you create an Azure Key Vault?", "az keyvault create --name VAULT_NAME --resource-group RESOURCE_GROUP_NAME --location LOCATION", "The 'az keyvault create' command creates a new Azure Key Vault.\nYou need to specify the vault name, resource group, and location."),

                // How to list all secrets in an Azure Key Vault
                new Problem("How do you list all secrets in an Azure Key Vault?", "az keyvault secret list --vault-name VAULT_NAME", "The 'az keyvault secret list' command lists all secrets stored in a specific Azure Key Vault.\nYou need to specify the vault name."),

                // How to set a secret in an Azure Key Vault
                new Problem("How do you set a secret in an Azure Key Vault?", "az keyvault secret set --name SECRET_NAME --vault-name VAULT_NAME --value SECRET_VALUE", "The 'az keyvault secret set' command stores a new secret in an Azure Key Vault.\nYou need to specify the secret name, vault name, and the secret value."),

                // How to retrieve a secret from an Azure Key Vault
                new Problem("How do you retrieve a secret from an Azure Key Vault?", "az keyvault secret show --name SECRET_NAME --vault-name VAULT_NAME", "The 'az keyvault secret show' command retrieves information about a specific secret from an Azure Key Vault.\nYou need to specify the secret name and vault name."),

                // How to list all active deployments in a resource group
                new Problem("How do you list all active deployments in a resource group?", "az deployment group list --resource-group RESOURCE_GROUP_NAME", "The 'az deployment group list' command lists all active deployments in a specific resource group.\nYou need to specify the resource group name."),

                // How to create an Azure Virtual Network Gateway
                new Problem("How do you create an Azure Virtual Network Gateway?", "az network vnet-gateway create --name GATEWAY_NAME --public-ip-addresses PUBLIC_IP_NAME --resource-group RESOURCE_GROUP_NAME --vnet VNET_NAME", "The 'az network vnet-gateway create' command creates a new Azure Virtual Network Gateway.\nYou need to specify the gateway name, public IP address name, resource group, and virtual network."),

                // How to create an Azure DNS Zone
                new Problem("How do you create an Azure DNS Zone?", "az network dns zone create --name DNS_NAME --resource-group RESOURCE_GROUP_NAME", "The 'az network dns zone create' command creates a new Azure DNS Zone.\nYou need to specify the DNS name and resource group."),

                // How to create a record set in an Azure DNS Zone
                new Problem("How do you create a record set in an Azure DNS Zone?", "az network dns record-set TYPE create --name RECORD_SET_NAME --resource-group RESOURCE_GROUP_NAME --zone-name DNS_NAME", "The 'az network dns record-set TYPE create' command creates a new record set in an Azure DNS Zone.\nYou need to specify the record set type (e.g., 'A', 'CNAME'), record set name, resource group, and DNS zone name."),

                // How to add a record to a record set in Azure DNS
                new Problem("How do you add a record to a record set in Azure DNS?", "az network dns record-set TYPE add-record --record-set-name RECORD_SET_NAME --resource-group RESOURCE_GROUP_NAME --zone-name DNS_NAME --ipv4-address IP_ADDRESS", "The 'az network dns record-set TYPE add-record' command adds a new record to an existing record set in an Azure DNS Zone.\nYou need to specify the record type (e.g., 'A', 'CNAME'), record set name, resource group, DNS zone name, and IP address for 'A' records or target domain for 'CNAME' records."),

                // How to remove a record from a record set in Azure DNS
                new Problem("How do you remove a record from a record set in Azure DNS?", "az network dns record-set TYPE remove-record --record-set-name RECORD_SET_NAME --resource-group RESOURCE_GROUP_NAME --zone-name DNS_NAME --ipv4-address IP_ADDRESS", "The 'az network dns record-set TYPE remove-record' command removes a record from an existing record set in an Azure DNS Zone.\nYou need to specify the record type (e.g., 'A', 'CNAME'), record set name, resource group, DNS zone name, and IP address for 'A' records or target domain for 'CNAME' records."),

                // How to list all available VM sizes in an Azure region
                new Problem("How do you list all available VM sizes in an Azure region?", "az vm list-sizes --location LOCATION", "The 'az vm list-sizes' command lists all available VM sizes for a given Azure region.\nThis is useful for determining what VM sizes can be deployed in a particular region."),

                // How to update the size of an existing VM
                new Problem("How do you update the size of an existing VM?", "az vm resize --resource-group RESOURCE_GROUP_NAME --name VM_NAME --size NEW_VM_SIZE", "The 'az vm resize' command changes the size of an existing VM.\nYou need to specify the resource group, VM name, and the new VM size."),

                // How to attach a managed disk to a VM
                new Problem("How do you attach a managed disk to a VM?", "az vm disk attach --resource-group RESOURCE_GROUP_NAME --vm-name VM_NAME --name DISK_NAME", "The 'az vm disk attach' command attaches a managed disk to an existing VM.\nYou need to specify the resource group, VM name, and the disk name."),

                // How to detach a managed disk from a VM
                new Problem("How do you detach a managed disk from a VM?", "az vm disk detach --resource-group RESOURCE_GROUP_NAME --vm-name VM_NAME --name DISK_NAME", "The 'az vm disk detach' command detaches a managed disk from an existing VM.\nYou need to specify the resource group, VM name, and the disk name."),

                // How to restart a VM
                new Problem("How do you restart a VM?", "az vm restart --resource-group RESOURCE_GROUP_NAME --name VM_NAME", "The 'az vm restart' command restarts an existing VM.\nYou need to specify the resource group and the VM name."),

                // How to list all available VM images in a specific region
                new Problem("How do you list all available VM images in a specific region?", "az vm image list --location LOCATION --output table", "The 'az vm image list' command lists all available VM images in a specific Azure region.\nUsing '--output table' formats the output as a table for easier reading.")


            };

            for (int i = 0; i < problems.Count; i++) 
            {
                problems[i].problemNumber = i + 1;
            }
        }
    }
}
