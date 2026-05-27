# How-To Switch Java JDK from Oracle to OpenJDK

- [How-To Switch Java JDK from Oracle to OpenJDK](#how-to-switch-java-jdk-from-oracle-to-openjdk)
  - [Background](#background)
  - [Dependencies Analysis](#dependencies-analysis)
    - [Multiple JDK Versions Co-Existed](#multiple-jdk-versions-co-existed)
    - [Usage of Java JDK from Essential Tool](#usage-of-java-jdk-from-essential-tool)
  - [Switch to RedHat Jave 1.8.0 OpenJDK](#switch-to-redhat-jave-180-openjdk)
    - [Switch TomCat Java from Oracle to RedHat](#switch-tomcat-java-from-oracle-to-redhat)
    - [Switch Essential Protégé Java Usage](#switch-essential-protégé-java-usage)
  - [Conclusion](#conclusion)
  - [Post Migration: Purge Leftover Oracle Variables](#post-migration-purge-leftover-oracle-variables)

## Background

In the Essential open source edition's installation page (https://enterprise-architecture.org/products/essential-open-source/essential-os-download/), as below, the required JRE is still version 1.8.

![eas_os_jre_req](img/eas_os_jre_req.png)

When clicking the `View` link, it opens https://www.java.com/en/download/help/index_installing.html, which is Oracle JRE site:

![java_website](img/java_website.png)

However, this is the non-compliant version which is not recommended from my company side, it is required to replace it with RedHat OpenJDK.

## Dependencies Analysis

As the JRE is required to run both Protege and Apache Tomcat, below analyze the dependencies in the Windows 11 computer.

### Multiple JDK Versions Co-Existed

The complexity in the machine I'm running is I already have higher Java version from OpenJDK for some other applications.

In command terminal, the Java version is by default point to the JDK21, as below:

```bash
C:\>java -version
openjdk version "21.0.5" 2024-10-15 LTS
OpenJDK Runtime Environment Microsoft-10377968 (build 21.0.5+11-LTS)
OpenJDK 64-Bit Server VM Microsoft-10377968 (build 21.0.5+11-LTS, mixed mode, sharing)
```

This is because the JDK21 is configured in `JAVA_HOME` system variable, as below:

![jdk21-system-variable](img/jdk21-system-variable.png)

The Oracle JRE 1.8.0 - downloaded from the link (java.com) Essential appinted - is installed separagely and set in the System `Path`, so I can have both versions mixed in the machine:

![java-coexist](img/java-coexist.png)

> [!Tip] OpenJDK 21.0.5.11 is 64bit and in `C:\Program Files`, while Oracle JDK 1.8.0 is 32bit, so it's in `C:\Program Files (x86)`

Further checking, found I also have one 64bit Java 1.8.0 installed in the folder `C:\Program Files\Java\jre1.8.0_431`.

Thus, below are the summary of the Java Running Environments currently:

| Version | Screen for Folder | Java version check |
| --- | --- | --- |
| Oracle Java 1.8.0_431 | ![java1.8.0_431](img/java1.8.0_431.png) | ![Java1.8.0_ver](img/Java1.8.0_ver.png) |
| Java 1.8.0_431-b10 | ![Java1.8_64bit](img/Java1.8_64bit.png) | ![Java1.8_64bit_ver](img/Java1.8_64bit_ver.png) |
| OpenJDK 21.0.5 | ![OpenJDK21_ms](img/OpenJDK21_ms.png) | ![OpenJDK21_ms_ver](img/OpenJDK21_ms_ver.png) |

### Usage of Java JDK from Essential Tool

For checking `Java` used by Tomcat, go to tomcat path:

`C:\Program Files\Apache Software Foundation\Tomcat 9.0\bin`

run `tomcat9w.exe`, you may see below, switch to `Java` tab:

![tomcat_jvm_setting](img/tomcat_jvm_setting.png)

The path of JVM is `C:\Program Files\Java\jre1.8.0_431\bin\server\jvm.dll`, which is using the Oracle Java 1.8.0 64bit edition.

For checking `Java` used by Protégé, go to `Protege_3.5` installation folder:

`C:\Program Files\Protege_3.5`

open the configuration file `Protege.lax`, as below:

![Protege3.5_jvm](img/Protege3.5_jvm.png)

The path of JVS is `C:\\Program Files\\Java\\jre1.8.0_431\\bin\\java.exe`

Thus, both Protégé and Tomcat are pointed to the 64bit Oracle JDK 1.8.0_431.

## Switch to RedHat Jave 1.8.0 OpenJDK

Installing folder for RedHat JDK is:

`C:\Program Files\RedHat\java-1.8.0-openjdk-1.8.0.462-2`

![rh-openjdk1.8.0](img/rh-openjdk1.8.0.png)

### Switch TomCat Java from Oracle to RedHat

Previous `jvm.dll` path:

`C:\Program Files\Java\jre1.8.0_431\bin\server\jvm.dll`

Change to:

`C:\Program Files\RedHat\java-1.8.0-openjdk-1.8.0.462-2\jre\bin\server\jvm.dll`

as below:

![tomcat9-using-rh-jre](img/tomcat9-using-rh-jre.png)

Go to Windows `Services`, find `Apache Tomcat 9.0 Tomcat9` and click `Restart`:

![tomcat9-service-restart](img/tomcat9-service-restart.png)

Checked from server status `http://localhost:8080/manager/status`, confirms the Java JVM is now using Red Hat.

![tomcat_java_switched_to_redhat](img/tomcat_java_switched_to_redhat.png)

Check local Essential viewer, it's working:

![Essential_View_over_RedHat_Java](img/Essential_View_over_RedHat_Java.png)

### Switch Essential Protégé Java Usage

Edit the configuration file `Protege.lax`, change line

`lax.nl.current.vm=C:\\Program Files\\Java\\jre1.8.0_431\\bin\\java.exe`

to
`lax.nl.current.vm=C:\\Program Files\\RedHat\\java-1.8.0-openjdk-1.8.0.462-2\\bin\\java.exe`

You need administrative permission to change the configuration file, after changing, the Protégé is loading without issue:

![Essential-Protege3.5-switch-java-to-redhat](img/Essential-Protege3.5-switch-java-to-redhat.png)

## Conclusion

With RedHat Java, the Essential EAS OpenSource edition is working well.

![Essential_Modeling_Publishing](img/Essential_Modeling_Publishing.png)

## Post Migration: Purge Leftover Oracle Variables

If you don't delete the remnants of your old environments, automatic Windows security software scans might flag the obsolete, unpatched Oracle JDK 8 directory still.

1. Press `Win + R`, type `sysdm.cpl`, and hit `Enter` to pull up **System Porperties**.
2. Go to **Advanced -> Environment Variables**.
3. Under *System Variables*, scroll down to double-check that `JAVA_HOME` points entirely to RedHat JDK, normally should be `C:\Program Files\RedHat\java-1.8.0-openjdk-...`, see below screen in my machine:
   ![System_Variable_rhjava](img/System_Variable_rhjava.png)
4. Look into your local program folders (`C:Program Files\Java\`) and safely **uninstall or compress and archive** the old `jdk1.8.0_xxx` or `jre1.8.0_xxx` paths once you verify the Essential tool and viewer portal are both fully functional.

---

Change log:
- 2026/05/27: adding Post Migration activities
- 2026/05/26: initialize