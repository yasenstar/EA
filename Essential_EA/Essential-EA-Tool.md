 Essential EA Tool

# 001 Introduction

## Essential Project Home Wedsite

## Essential University

# 002 Download and Install Essential Open-Source Packages

## Essential Open Source EA Tool download

## Pre-Requisites

### 1. Java: ensure version 1.8 or above
(I'm using openjdk 11.0.16.1 which is ok)

### 2. Protege Ontology Editor

#### Only support v3.5, use the package in this site

#### You can still use other Protege version along with this one for your other Ontologies, no conflict within Program Files

#### lax.nl.java.option.java.heap.size.max set to 2048000000

### 3. Tomcat, only support v8 or v9

Essential Viewer can be used with any Java web application server but the installer assumes Tomcat


### 4. Optional components

#### Database: you can ignore if you don't connect to DB

#### JDBC Driver: for selected DB

## Essential Core components

### 1. Widgets (v6.7)

#### A set of custom-built plug-ins for the Protege Ontology Editor. Run the installer and follow the on-screen instructions.

### 2. Meta-Model (v6.18)

#### The main repository files for Essential. Save this to a user accessible area such as your Documents folder, unzip and then open using Protege.

#### Rename the pprj file to your desired project name

### 3. Viewer (v6.18.7)

#### A Java Web Application for publishing, analysing and reporting against enterprise architecture models captured using the Essential Meta-Model. Copy this file to your Tomcat install 'webapps' folder

#### Rename the war file and copy to your active Tomcat webapps folder, wait it extracted

### 4. Import Utility (v2.8)

#### A Java Web Application for importing existing content from spreadsheets into the Essential repository. Copy this file to your Tomcat install 'webapps' folder

### 5. Import Utility Example Configuration (v2.0)

#### An example configuration of Import Activities for the Import Utility. Save this to a user accessible area such as your Documents folder and select it from within the Import Utility's System Settings tab, using the "Import Configuration..." button

## Installation Guide

### Standalone Install

### Multi-User Install

## Practice after installation

### 1. Open Meta-Model project in Protege

### 2. Open Viewer through web browser using viewer URL

### 3. Connect viewer from Protege and able to publish repository to viewer
