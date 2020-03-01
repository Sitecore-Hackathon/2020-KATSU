# Documentation

## Summary

**Category:** Sitecore Marketplace Website

The Solution tries to enhance the current Marketplace website by enabling the Sitecore developers and community to install packages directly from the Sitecore instance 

This solution consists of two parts

**1. Sample Marketplace website**

The new sample website enable contributors to upload their module package. Each new module will go through a certain workflow. 

The website also uses Sitecore CMS with Solr to enhance search experiences for users. The solution is trying to exploit as much as possible of Sitecore services to insure the maximum reusability and maintainability of the system with providing the optimum workflow for Sitecore developers.

**2. Marketplace Installer Module**

The Marketplace Installer Module tries to help developers with installing marketplace Sitecore packages, and save their time downloading and installing packages by providing a simple interface to install package by name.

This module is built on top of Sitecore Powershell Extension Module.

The two parts of this solution intend to simplify a developers task by helping them find the best match marketplace module and minimize the steps to install the correct package.


## Pre-requisites

### Marketplace Installer Module
- Sitecore 9.3 
- Sitecore Powershell Extension -version 6
- Marketplace new sample website

### Marketplace website
- Sitecore 9.3

## Installation

The installation packages are available in this repository in the following path 

*/sc.package*

### Marketplace website

1. Install a clean Sitecore instance version 9.3
2. Install pckage */sc.package/KATSU-1.zip* using Installation Wizard 
3. For dll choose No to All and for Sitecore Items choose overite all 

### Marketplace Installer Module

1. Install a clean Sitecore instance version 9.3
2. Install Sitecore Poweshell Extension Module version 6
3. Install */sc.package/KATSU-1.zip* using Installation Wizard
 
Check the configuration section for after installation steps 


## Configuration

#### Marketplace website

Change the site configuration with the correct instance name 

*2020-KATSU/src/Project/KATSU/website/App_Config/Include/Project/Project.KATSU.config*

```xml
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <sites>
      <site name="KATSU" patch:after="site[@name='modules_website']" targetHostName="$(rootHostName).sc.dev.local"
            enableTracking="true" virtualFolder="/" physicalFolder="/" rootPath="/sitecore/content/KATSU"
            dictionaryDomain="{8AC9D0C5-F969-4CFD-B0B3-4554638069A7}" startItem="/home" database="web"
            domain="extranet" allowDebug="true" cacheHtml="true" htmlCacheSize="50MB" registryCacheSize="0"
            viewStateCacheSize="0" xslCacheSize="25MB" filteredItemsCacheSize="10MB" enablePreview="true"
            enableWebEdit="true" enableDebugger="true" disableClientData="false" cacheRenderingParameters="true"
            renderingParametersCacheSize="10MB" language="en" patch:source="Sitecore.LanguageFallback.config"
            itemwebapi.mode="Off" itemwebapi.access="ReadOnly" itemwebapi.allowanonymousaccess="false"
            enableItemLanguageFallback="false" enableFieldLanguageFallback="false" />
    </sites>
  </sitecore>
</configuration>
```

#### Marketplace Installer Module

The Marketplace Installer Module uses this setting "KATSU.Marketplace.Url"  should contain the sampl website url 
After installing the module package check the settings under file *Feature.MarketplaceInstaller.config*

Example
```xml
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
    <sitecore>
        <settings>
            <setting name="KATSU.Marketplace.Url" value="https://katsu.dev.local/-/media/Project/KATSU/Packages/" />
        </settings>
    </sitecore>
</configuration>
```

## Usage

#### Marketplace website

The sample website will contains the following

**Home Page**

The main page in the website contains navigation items to other parts of the website
![Home Page](images/home.png?raw=true "Home Page")

**Contribute Page**
Contribute pages allows Sitecore community members to upload a new module package. 

![Contribute Page](images/cont.png?raw=true "Contribute Page")

The submitted packages will be saved as Sitecore items in Sitecore tree. 

![Sitecore Tree](images/SitecoreTree.PNG?raw=true "Sitecore Tree")

The packages will go through a specific workflow before sharing with the community.

![Wokflow](images/Workflow.PNG?raw=true "Wokflow")


The approved packages will now be available in *Discover Page*

**Discover Page**

This page is used to search for available packages.
A list of packages is displayed based on search keyword.

![Discover Page](images/disc.png?raw=true "Discover Page")


**Details Page**

This page shows all package details. Also, a download link is available if a user prefers traditional package installation. 

![Details Page](images/details.png?raw=true "Details Page")


#### Marketplace Installer Module
The Marketplace Installer Module will allow the user to install packages with only packages

The first step is to install the package "Marketplace Installer Package.zip"  your website as shown below

![Installation](images/install.png?raw=true "install")

Then you need to make sure that the setting "KATSU.Marketplace.Url"

After that, the Install package button will appear under the Developer Ribbon

![Package Installer](images/package_Installer.png?raw=true "Package Installer")

once you click on it allows you to enter the package name then it will automatically download the package and install it in your Sitecore instance  

![Package Installer Step 1](images/package_Installer_step1.png?raw=true "Package Installer Step 1")

![Package Installer Step 2](images/package_Installer_step2.png?raw=true "Package Installer Step 2")



## Enhancements

The following are the planed enhancments on this solution 

1. Create an API to be used by th module 
2. User Account Management
3. Improvement on security and workflow mangement 
4. Provide versioning for packages

## Video

Following is a youtube video that explains our feature:

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/sBm7SLdjieM/0.jpg)](https://www.youtube.com/watch?v=sBm7SLdjieM)
