# Documentation

## Summary

**Category:** Sitecore Marketplace Website

This solution consists of two parts
1- A new look for the Marketplace website
2- Marketplace Installer Module

The Marketplace Installer Module tries to help developers with installing marketplace sitecore packages, and save their time downloading and installign packages by providing a simple interface to install package by name and version.

This moule acts as a client side module that can be downloaded on any sitecore instances and uses the new Marketplace website as serverside.

The enhancements on the Marketplace are building a new API to provide pacages to the Marketplace Installer Module. Additionally, provide a new looks and feels for the Marketplace website.

The website also uses Sitecore CMS with Solr to inhance search experiences for users. The soution is trying to exploit as much as possible of Sitecore services to insure the maximum reusibility and maintainability of the system with providing the optimum workflow for Sitecore developers.

The two parts of this solution intend to simplify a developers task by helping them find the best match marketplace module and minimize the steps to install the correct package.


## Pre-requisites
Marketplace Installer Module
- Sitecore 9.3 
- Sitecore powershell Extension v6

Marketplace website
-Sitecore 9.3

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

Provide documentation  about your module, how do the users use your module, where are things located, what do icons mean, are there any secret shortcuts etc.

Please include screenshots where necessary. You can add images to the `./images` folder and then link to them from your documentation:

![Hackathon Logo](images/hackathon.png?raw=true "Hackathon Logo")

You can embed images of different formats too:

![Deal With It](images/deal-with-it.gif?raw=true "Deal With It")

And you can embed external images too:

![Random](https://placeimg.com/480/240/any "Random")

## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
