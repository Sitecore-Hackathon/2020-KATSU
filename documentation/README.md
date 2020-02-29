# Documentation

## Summary

**Category:** Sitecore Marketplace Website

The Solution tries to enhance the current Marketplace website by enabling the Sitecore developers and community to install packages directly from the Sitecore instance 

This solution consists of two parts

#####1. Sample Marketplace website

The new sample website enable contributors to upload their module package. Each new module will go through a certain workflow. 

The website also uses Sitecore CMS with Solr to enhance search experiences for users. The solution is trying to exploit as much as possible of Sitecore services to insure the maximum reusability and maintainability of the system with providing the optimum workflow for Sitecore developers.

#####2. Marketplace Installer Module

The Marketplace Installer Module tries to help developers with installing marketplace Sitecore packages, and save their time downloading and installing packages by providing a simple interface to install package by name.

This module is built on top of Sitecore Powershell Extension Module.

The two parts of this solution intend to simplify a developers task by helping them find the best match marketplace module and minimize the steps to install the correct package.


## Pre-requisites

####Marketplace Installer Module
- Sitecore 9.3 
- Sitecore Powershell Extension -version 6
- Marketplace new sample website

####Marketplace website
- Sitecore 9.3

## Installation

Provide detailed instructions on how to install the module, and include screenshots where necessary.

1. Use the Sitecore Installation wizard to install the [package](#link-to-package)
2. ???
3. Profit

## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

####Marketplace website

The sample website will contains the following

**Home Page**

The main page in the website contains navigation items to other parts of the website

**Contribute Page**
Contribute pages allows Sitecore community members to upload a new module package. The submitted packages will be saved as Sitecore items in Sitecore tree. The packages will go through a specific workflow before sharing with the community.


**Discover Page**

This page is used to search for available packages.
A list of packages is displayed based on search keyword.


**Details Page**

This page shows all package details. Also, a download link is available if a user prefers traditional package installation. 


![Random](https://placeimg.com/480/240/any "Random")

##Enhancements

## Video

