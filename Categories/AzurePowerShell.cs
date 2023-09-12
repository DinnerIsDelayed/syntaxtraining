using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice.Categories
{
    internal class AzurePowerShell
    {
        public string type = "AzurePowerShell";
        public List<Problem> problems = new List<Problem>();
        public List<Problem> savedProblems = new List<Problem>();

        public AzurePowerShell() 
        {
            problems = new List<Problem>()
            {
                // How to login into Azure using PowerShell
                new Problem("How do you login into Azure using PowerShell?", "Connect-AzAccount", "The 'Connect-AzAccount' cmdlet opens a dialog asking you to enter your Azure login credentials.\nAfter successful authentication, you can perform tasks that require authentication such as resource creation, modification, and deletion."),

                // How to list all Azure subscriptions using PowerShell
                new Problem("How do you list all Azure subscriptions using PowerShell?", "Get-AzSubscription", "The 'Get-AzSubscription' cmdlet retrieves all the Azure subscriptions associated with your account.\nThis is useful for identifying which subscriptions you can deploy resources into."),

                // How to set a default Azure subscription in PowerShell
                new Problem("How do you set a default Azure subscription in PowerShell?", "Set-AzContext -Subscription 'SubscriptionNameOrID'", "The 'Set-AzContext' cmdlet sets a particular Azure subscription as your default subscription.\nThis is important if you have multiple subscriptions and want to specify which one to use for subsequent commands."),

                // How to create a new Azure Resource Group using PowerShell
                new Problem("How do you create a new Azure Resource Group using PowerShell?", "New-AzResourceGroup -Name 'ResourceGroupName' -Location 'Location'", "The 'New-AzResourceGroup' cmdlet creates a new Azure Resource Group.\nResource Groups are essentially containers that hold related resources for an Azure solution.\nThey help in logically organizing and managing your Azure resources."),

                // How to list all Azure Resource Groups using PowerShell
                new Problem("How do you list all Azure Resource Groups using PowerShell?", "Get-AzResourceGroup", "The 'Get-AzResourceGroup' cmdlet lists all the Resource Groups in your Azure subscription.\nKnowing your Resource Groups is essential for understanding how your resources are organized."),

                // How to create a new Azure Virtual Machine using PowerShell
                new Problem("How do you create a new Azure Virtual Machine using PowerShell?", "New-AzVm -ResourceGroupName 'ResourceGroupName' -Name 'VMName' -Location 'Location'", "The 'New-AzVm' cmdlet initializes a new Virtual Machine (VM) in your Azure environment.\nVirtual Machines are essential for running applications and services in Azure.\nSpecify the name, resource group, and data center location for the new VM."),

                // How to list all Azure Virtual Machines using PowerShell
                new Problem("How do you list all Azure Virtual Machines using PowerShell?", "Get-AzVm", "The 'Get-AzVm' cmdlet lists all the Virtual Machines in your Azure subscription.\nThis allows you to see the operational status, size, and other properties of your VMs."),

                // How to create a new Azure Storage Account using PowerShell
                new Problem("How do you create a new Azure Storage Account using PowerShell?", "New-AzStorageAccount -ResourceGroupName 'ResourceGroupName' -Name 'StorageAccountName' -Location 'Location' -SkuName 'SkuName'", "The 'New-AzStorageAccount' cmdlet creates a new Azure Storage Account.\nStorage Accounts provide scalable and secure storage solutions for your Azure resources.\nSpecify the name, resource group, location, and performance tier (SkuName) for the new storage account."),

                // How to list all Azure Storage Accounts using PowerShell
                new Problem("How do you list all Azure Storage Accounts using PowerShell?", "Get-AzStorageAccount", "The 'Get-AzStorageAccount' cmdlet lists all the Azure Storage Accounts in your subscription.\nThis is useful for managing and understanding your storage resources."),

                // How to create an Azure SQL Database using PowerShell
                new Problem("How do you create an Azure SQL Database using PowerShell?", "New-AzSqlDatabase -ResourceGroupName 'ResourceGroupName' -ServerName 'ServerName' -DatabaseName 'DatabaseName'", "The 'New-AzSqlDatabase' cmdlet establishes a new Azure SQL Database.\nSQL databases are fully managed relational databases that support SQL queries.\nYou need to specify the database name, the server where it will reside, and the resource group."),

                // How to list all Azure SQL Databases using PowerShell
                new Problem("How do you list all Azure SQL Databases using PowerShell?", "Get-AzSqlDatabase -ResourceGroupName 'ResourceGroupName' -ServerName 'ServerName'", "The 'Get-AzSqlDatabase' cmdlet lists all SQL Databases for a particular Azure SQL server and resource group.\nThis is useful for managing your databases and understanding your Azure SQL Database resources."),

                // How to create an Azure Kubernetes Cluster using PowerShell
                new Problem("How do you create an Azure Kubernetes Cluster using PowerShell?", "New-AzAks -ResourceGroupName 'ResourceGroupName' -Name 'ClusterName'", "The 'New-AzAks' cmdlet creates a new Azure Kubernetes Service (AKS) cluster.\nAKS is a managed Kubernetes service that simplifies deploying, managing, and scaling containerized applications.\nSpecify the resource group and cluster name when creating the new AKS cluster."),

                // How to list all Azure Kubernetes Clusters using PowerShell
                new Problem("How do you list all Azure Kubernetes Clusters using PowerShell?", "Get-AzAks", "The 'Get-AzAks' cmdlet lists all AKS clusters in your Azure subscription.\nThis helps you manage your clusters and understand their configurations and statuses."),

                // How to create an Azure Virtual Network using PowerShell
                new Problem("How do you create an Azure Virtual Network using PowerShell?", "New-AzVirtualNetwork -ResourceGroupName 'ResourceGroupName' -Name 'VirtualNetworkName' -AddressPrefix 'AddressPrefix'", "The 'New-AzVirtualNetwork' cmdlet creates a new Azure Virtual Network.\nVirtual Networks are essential for securely connecting Azure resources and isolating them from the public internet.\nSpecify the resource group, virtual network name, and address prefix for IP addresses."),

                // How to list all Azure Virtual Networks using PowerShell
                new Problem("How do you list all Azure Virtual Networks using PowerShell?", "Get-AzVirtualNetwork", "The 'Get-AzVirtualNetwork' cmdlet lists all the Azure Virtual Networks in your Azure subscription.\nThis helps you manage your networks and understand their configurations and statuses."),

                // How to create an Azure App Service Plan using PowerShell
                new Problem("How do you create an Azure App Service Plan using PowerShell?", "New-AzAppServicePlan -ResourceGroupName 'ResourceGroupName' -Name 'AppServicePlanName' -Location 'Location' -Tier 'Tier'", "The 'New-AzAppServicePlan' cmdlet creates a new Azure App Service Plan.\nAn App Service Plan defines the region and the amount of compute resources for hosting web apps.\nSpecify the resource group, plan name, data center location, and performance tier when creating the new plan."),

                // How to list all Azure App Services using PowerShell
                new Problem("How do you list all Azure App Services using PowerShell?", "Get-AzWebApp", "The 'Get-AzWebApp' cmdlet lists all the Azure Web Apps in your Azure subscription.\nIt's useful for understanding the web applications you have deployed, their statuses, and configurations."),

                // How to delete an Azure Resource Group using PowerShell
                new Problem("How do you delete an Azure Resource Group using PowerShell?", "Remove-AzResourceGroup -Name 'ResourceGroupName' -Force -AsJob", "The 'Remove-AzResourceGroup' cmdlet deletes a specified Azure Resource Group and all the resources it contains.\nUse the -Force parameter to skip the confirmation message.\nThe -AsJob parameter runs the command as a background job, useful for long-running operations."),

                // How to upload a blob to an Azure Blob Storage account using PowerShell
                new Problem("How do you upload a blob to an Azure Blob Storage account using PowerShell?", "Set-AzStorageBlobContent -Container 'ContainerName' -File 'LocalFilePath' -Blob 'BlobName' -Context $storageContext", "The 'Set-AzStorageBlobContent' cmdlet uploads a blob to an Azure Blob Storage container.\nBlob Storage is Azure's object storage solution for unstructured data.\nSpecify the container name, local file path, blob name, and storage context (usually retrieved using 'Get-AzStorageAccountKey')."),

                // How to list all blobs in an Azure Blob Storage container using PowerShell
                new Problem("How do you list all blobs in an Azure Blob Storage container using PowerShell?", "Get-AzStorageBlob -Container 'ContainerName' -Context $storageContext", "The 'Get-AzStorageBlob' cmdlet lists all blobs in a specified Azure Blob Storage container.\nThis allows you to manage your blobs and understand your Azure Blob Storage usage.\nSpecify the container name and storage context (usually retrieved using 'Get-AzStorageAccountKey')."),

                // How to import the Azure PowerShell module
                new Problem("How do you import the Azure PowerShell module?", "Import-Module Az", "The 'Import-Module Az' command imports the Azure PowerShell module into your session.\nThis allows you to use Azure-specific cmdlets."),

                // How to authenticate with Azure
                new Problem("How do you authenticate with Azure?", "Connect-AzAccount", "The 'Connect-AzAccount' cmdlet opens a dialog for signing into your Azure account.\nThis is necessary before executing other Azure PowerShell commands."),

                // How to get a list of all Azure VMs
                new Problem("How do you get a list of all Azure VMs?", "Get-AzVM", "The 'Get-AzVM' cmdlet retrieves all Azure VMs in the current subscription.\nThis allows you to manage and view your existing VM instances."),

                // How to start an Azure VM
                new Problem("How do you start an Azure VM?", "Start-AzVM -ResourceGroupName RESOURCE_GROUP_NAME -Name VM_NAME", "The 'Start-AzVM' cmdlet starts an existing Azure VM.\nYou need to specify the resource group and the name of the VM."),

                // How to stop an Azure VM
                new Problem("How do you stop an Azure VM?", "Stop-AzVM -ResourceGroupName RESOURCE_GROUP_NAME -Name VM_NAME", "The 'Stop-AzVM' cmdlet stops an existing Azure VM.\nYou need to specify the resource group and the name of the VM."),

                // How to get all resource groups
                new Problem("How do you get all resource groups?", "Get-AzResourceGroup", "The 'Get-AzResourceGroup' cmdlet retrieves all Azure resource groups in the current subscription.\nResource groups are containers that hold related resources."),

                // How to create a new resource group
                new Problem("How do you create a new resource group?", "New-AzResourceGroup -Name RESOURCE_GROUP_NAME -Location LOCATION", "The 'New-AzResourceGroup' cmdlet creates a new Azure resource group.\nYou need to specify the name and location for the new resource group."),

                // How to delete a resource group
                new Problem("How do you delete a resource group?", "Remove-AzResourceGroup -Name RESOURCE_GROUP_NAME", "The 'Remove-AzResourceGroup' cmdlet deletes an existing Azure resource group.\nYou need to specify the name of the resource group to be deleted."),

                // How to list all Azure subscriptions
                new Problem("How do you list all Azure subscriptions?", "Get-AzSubscription", "The 'Get-AzSubscription' cmdlet retrieves all Azure subscriptions that you have access to.\nThis is useful for managing multiple subscriptions."),

                // How to set the current Azure subscription
                new Problem("How do you set the current Azure subscription?", "Set-AzContext -Subscription SUBSCRIPTION_NAME_OR_ID", "The 'Set-AzContext' cmdlet sets the current Azure subscription for your session.\nYou need to specify the subscription name or ID."),

                // How to create a new VNet
                new Problem("How do you create a new VNet?", "New-AzVirtualNetwork -ResourceGroupName RESOURCE_GROUP_NAME -Location LOCATION -Name VNET_NAME -AddressPrefix ADDRESS_PREFIX", "The 'New-AzVirtualNetwork' cmdlet creates a new Azure Virtual Network.\nYou need to specify the resource group, location, VNet name, and address prefix."),

                // How to create a new subnet
                new Problem("How do you create a new subnet?", "New-AzVirtualNetworkSubnetConfig -Name SUBNET_NAME -AddressPrefix ADDRESS_PREFIX", "The 'New-AzVirtualNetworkSubnetConfig' cmdlet creates a new Azure Subnet configuration.\nYou need to specify the subnet name and the address prefix."),

                // How to get all storage accounts
                new Problem("How do you get all storage accounts?", "Get-AzStorageAccount", "The 'Get-AzStorageAccount' cmdlet retrieves all Azure Storage Accounts in the current subscription.\nThis allows you to manage and view your existing storage accounts."),

                // How to create a new storage account
                new Problem("How do you create a new storage account?", "New-AzStorageAccount -ResourceGroupName RESOURCE_GROUP_NAME -Name STORAGE_ACCOUNT_NAME -Location LOCATION -SkuName SKU_NAME", "The 'New-AzStorageAccount' cmdlet creates a new Azure Storage Account.\nYou need to specify the resource group, storage account name, location, and SKU name."),

                // How to delete a storage account
                new Problem("How do you delete a storage account?", "Remove-AzStorageAccount -ResourceGroupName RESOURCE_GROUP_NAME -Name STORAGE_ACCOUNT_NAME", "The 'Remove-AzStorageAccount' cmdlet deletes an existing Azure Storage Account.\nYou need to specify the resource group and the storage account name."),

                // How to upload a blob to a storage account
                new Problem("How do you upload a blob to a storage account?", "Set-AzStorageBlobContent -Container CONTAINER_NAME -File FILE_PATH -Blob BLOB_NAME -Context STORAGE_CONTEXT", "The 'Set-AzStorageBlobContent' cmdlet uploads a blob to an Azure Storage container.\nYou need to specify the container name, file path, blob name, and storage context."),

                // How to create an Azure SQL Database
                new Problem("How do you create an Azure SQL Database?", "New-AzSqlDatabase -ResourceGroupName RESOURCE_GROUP_NAME -ServerName SERVER_NAME -DatabaseName DATABASE_NAME -Edition EDITION -MaxSizeBytes MAX_SIZE", "The 'New-AzSqlDatabase' cmdlet creates a new Azure SQL Database.\nYou need to specify the resource group, server name, database name, edition, and maximum size."),

                // How to list all SQL Databases in a server
                new Problem("How do you list all SQL Databases in a server?", "Get-AzSqlDatabase -ResourceGroupName RESOURCE_GROUP_NAME -ServerName SERVER_NAME", "The 'Get-AzSqlDatabase' cmdlet retrieves all Azure SQL Databases in a given SQL Server and resource group.\nYou need to specify the resource group and server name."),

                // How to delete an Azure SQL Database
                new Problem("How do you delete an Azure SQL Database?", "Remove-AzSqlDatabase -ResourceGroupName RESOURCE_GROUP_NAME -ServerName SERVER_NAME -DatabaseName DATABASE_NAME", "The 'Remove-AzSqlDatabase' cmdlet deletes an existing Azure SQL Database.\nYou need to specify the resource group, server name, and database name."),

                // How to create an Azure App Service Plan
                new Problem("How do you create an Azure App Service Plan?", "New-AzAppServicePlan -ResourceGroupName RESOURCE_GROUP_NAME -Name PLAN_NAME -Location LOCATION -Tier TIER", "The 'New-AzAppServicePlan' cmdlet creates a new Azure App Service Plan.\nYou need to specify the resource group, plan name, location, and tier."),

                // How to get all App Service Plans
                new Problem("How do you get all App Service Plans?", "Get-AzAppServicePlan", "The 'Get-AzAppServicePlan' cmdlet retrieves all Azure App Service Plans in the current subscription.\nThis allows you to manage and view your existing plans."),

                // How to delete an App Service Plan
                new Problem("How to delete an App Service Plan?", "Remove-AzAppServicePlan -ResourceGroupName RESOURCE_GROUP_NAME -Name PLAN_NAME", "The 'Remove-AzAppServicePlan' cmdlet deletes an existing Azure App Service Plan.\nYou need to specify the resource group and the name of the plan."),

                // How to create a new Azure Web App
                new Problem("How do you create a new Azure Web App?", "New-AzWebApp -ResourceGroupName RESOURCE_GROUP_NAME -Name WEB_APP_NAME -Location LOCATION -AppServicePlan PLAN_NAME", "The 'New-AzWebApp' cmdlet creates a new Azure Web App.\nYou need to specify the resource group, web app name, location, and the app service plan."),

                // How to get all Web Apps
                new Problem("How do you get all Web Apps?", "Get-AzWebApp", "The 'Get-AzWebApp' cmdlet retrieves all Azure Web Apps in the current subscription.\nThis allows you to manage and view your existing web apps."),

                // How to delete a Web App
                new Problem("How do you delete a Web App?", "Remove-AzWebApp -ResourceGroupName RESOURCE_GROUP_NAME -Name WEB_APP_NAME", "The 'Remove-AzWebApp' cmdlet deletes an existing Azure Web App.\nYou need to specify the resource group and the name of the web app."),

                // How to list all Azure Kubernetes Services (AKS) clusters
                new Problem("How do you list all Azure Kubernetes Services (AKS) clusters?", "Get-AzAks", "The 'Get-AzAks' cmdlet retrieves all Azure Kubernetes Service clusters in the current subscription.\nThis allows you to manage and view your existing AKS clusters."),

                // How to create a new Azure Kubernetes Services (AKS) cluster
                new Problem("How do you create a new Azure Kubernetes Services (AKS) cluster?", "New-AzAks -ResourceGroupName RESOURCE_GROUP_NAME -Name CLUSTER_NAME -Location LOCATION", "The 'New-AzAks' cmdlet creates a new Azure Kubernetes Service cluster.\nYou need to specify the resource group, cluster name, and location."),

                // How to delete an Azure Kubernetes Services (AKS) cluster
                new Problem("How do you delete an Azure Kubernetes Services (AKS) cluster?", "Remove-AzAks -ResourceGroupName RESOURCE_GROUP_NAME -Name CLUSTER_NAME", "The 'Remove-AzAks' cmdlet deletes an existing Azure Kubernetes Service cluster.\nYou need to specify the resource group and the name of the cluster."),

                // How to list all Azure functions in a function app
                new Problem("How do you list all Azure functions in a function app?", "Get-AzFunction -FunctionAppName FUNCTION_APP_NAME", "The 'Get-AzFunction' cmdlet retrieves all functions in a specified Azure Function App.\nYou need to specify the name of the Function App."),

                // How to list all virtual networks
                new Problem("How do you list all virtual networks?", "Get-AzVirtualNetwork", "The 'Get-AzVirtualNetwork' cmdlet retrieves all virtual networks in the current Azure subscription.\nThis allows you to manage and view your existing virtual networks."),

                // How to delete a virtual network
                new Problem("How do you delete a virtual network?", "Remove-AzVirtualNetwork -ResourceGroupName RESOURCE_GROUP_NAME -Name VNET_NAME", "The 'Remove-AzVirtualNetwork' cmdlet deletes an existing virtual network.\nYou need to specify the resource group and the name of the virtual network."),

                // How to list all virtual network subnets
                new Problem("How do you list all virtual network subnets?", "Get-AzVirtualNetworkSubnetConfig -VirtualNetwork VIRTUAL_NETWORK", "The 'Get-AzVirtualNetworkSubnetConfig' cmdlet retrieves all subnets in a specified virtual network.\nYou need to specify the virtual network object or name."),

                // How to add a rule to a Network Security Group
                new Problem("How do you add a rule to a Network Security Group?", "New-AzNetworkSecurityRuleConfig -Name RULE_NAME -Description DESCRIPTION -Access ALLOW_OR_DENY -Protocol PROTOCOL -Direction INBOUND_OR_OUTBOUND -Priority PRIORITY", "The 'New-AzNetworkSecurityRuleConfig' cmdlet creates a new Network Security Group rule.\nYou need to specify the name, description, access type, protocol, direction, and priority."),

                // How to get Azure AD users
                new Problem("How do you get Azure AD users?", "Get-AzAdUser", "The 'Get-AzAdUser' cmdlet retrieves Azure Active Directory users in the current subscription.\nThis is useful for managing identity and access."),

                // How to list all managed disks
                new Problem("How do you list all managed disks?", "Get-AzDisk", "The 'Get-AzDisk' cmdlet retrieves all managed disks in the current Azure subscription.\nManaged disks are used for VMs and other services that require disk storage."),

                // How to create a new managed disk
                new Problem("How do you create a new managed disk?", "New-AzDisk -ResourceGroupName RESOURCE_GROUP_NAME -DiskName DISK_NAME -Location LOCATION -CreateOption CREATE_OPTION -DiskSizeGB SIZE_IN_GB", "The 'New-AzDisk' cmdlet creates a new Azure managed disk.\nYou need to specify the resource group, disk name, location, create option, and size in GB."),

                // How to delete a managed disk
                new Problem("How do you delete a managed disk?", "Remove-AzDisk -ResourceGroupName RESOURCE_GROUP_NAME -DiskName DISK_NAME", "The 'Remove-AzDisk' cmdlet deletes an existing Azure managed disk.\nYou need to specify the resource group and the disk name."),

                // How to attach a disk to a VM
                new Problem("How do you attach a disk to a VM?", "Add-AzVMDataDisk -VM VM -Name DISK_NAME -CreateOption ATTACH -ManagedDiskId MANAGED_DISK_ID", "The 'Add-AzVMDataDisk' cmdlet attaches a managed disk to an existing VM.\nYou need to specify the VM object, disk name, create option as 'Attach', and the managed disk ID."),

                // How to detach a disk from a VM
                new Problem("How do you detach a disk from a VM?", "Remove-AzVMDataDisk -VM VM -Name DISK_NAME", "The 'Remove-AzVMDataDisk' cmdlet detaches a managed disk from an existing VM.\nYou need to specify the VM object and the disk name.")

            };

            for (int i = 0; i < problems.Count; i++)
            {
                problems[i].problemNumber = i + 1;
            }
        }
    }
}
