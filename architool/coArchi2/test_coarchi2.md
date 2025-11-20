# Archi coArchi2 Plug-In

- [Archi coArchi2 Plug-In](#archi-coarchi2-plug-in)
  - [Installing coArchi2](#installing-coarchi2)

## Installing coArchi2

You may run Archi through one portable ZIP package so that it is not impacting your main Archi instance.

Edit the `Archi.ini` in your portable Archi folder and change folder to your actual path, not the default system path.

Here is the default `Archi.ini`:

```bash
-startup
plugins/org.eclipse.equinox.launcher_1.6.800.v20240513-1750.jar
--launcher.library
plugins/org.eclipse.equinox.launcher.win32.win32.x86_64_1.2.1000.v20240507-1834
-cleanConfig
--launcher.defaultAction
openFile
-eclipse.keyring
@user.home/AppData/Roaming/Archi/secure_storage
-vmargs
-Dosgi.requiredJavaVersion=21
-Dfile.encoding=UTF-8
-Declipse.p2.data.area=@config.dir/p2
-Ddata.location=@user.home/Documents/Archi
-Dslf4j.internal.verbosity=ERROR
--add-modules=ALL-SYSTEM
-Dosgi.instance.area=@user.home/AppData/Roaming/Archi
-Dosgi.configuration.area=@user.home/AppData/Roaming/Archi/config
-Dorg.eclipse.equinox.p2.reconciler.dropins.directory=%user.home%/AppData/Roaming/Archi/dropins
```

Here my portable Archi is placed in `D:\tool\Archi_coArchi2` folder, so you need to update the configuration file as below:

```bash
-startup
plugins/org.eclipse.equinox.launcher_1.6.800.v20240513-1750.jar
--launcher.library
plugins/org.eclipse.equinox.launcher.win32.win32.x86_64_1.2.1000.v20240507-1834
-cleanConfig
--launcher.defaultAction
openFile
-eclipse.keyring
D:/tool/Archi_coArchi2/secure_storage
-vmargs
-Dosgi.requiredJavaVersion=21
-Dfile.encoding=UTF-8
-Declipse.p2.data.area=@config.dir/p2
-Ddata.location=D:/tool/Archi_coArchi2/Documents/Archi
-Dslf4j.internal.verbosity=ERROR
--add-modules=ALL-SYSTEM
-Dosgi.instance.area=D:/tool/Archi_coArchi2
-Dosgi.configuration.area=D:/tool/Archi_coArchi2/config
-Dorg.eclipse.equinox.p2.reconciler.dropins.directory=D:/tool/Archi_coArchi2/dropins
```

After that, you can open both Archi instances in Windows at the same time:

![co-run Archi](img/corun-archi.png)

In the instance of clean Archi, install the latest testing version of coArchi2, as below:

![coArchi version 20251120](img/coarchi2_version_20251120.png)