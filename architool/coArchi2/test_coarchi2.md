# Archi coArchi2 Plug-In

- [Archi coArchi2 Plug-In](#archi-coarchi2-plug-in)
  - [Resources about coArchi2](#resources-about-coarchi2)
  - [Installing coArchi2](#installing-coarchi2)
  - [Initial Collaboration Model in coArchi2 and Compare with coArchi1](#initial-collaboration-model-in-coarchi2-and-compare-with-coarchi1)
    - [Open Local Model](#open-local-model)
    - [`Collaboration` Menu](#collaboration-menu)
    - [Create Empty Repository (GitHub)](#create-empty-repository-github)
    - [`Add Local Model to Workspace`](#add-local-model-to-workspace)

## Resources about coArchi2

- [Why Move to coArchi2](https://github.com/archimatetool/archi-modelrepository-plugin2/wiki/Why-coArchi2)
- [Wiki for coArchi2](https://github.com/archimatetool/archi-modelrepository-plugin2/wiki)
- [coArchi2 Change Log](https://github.com/archimatetool/archi-modelrepository-plugin2/wiki/Change-Log)
- [GitHub Page for Reporting Issues on coArchi2](https://github.com/archimatetool/archi-modelrepository-plugin2/issues)

## Installing coArchi2

Before formally release, you may download coArchi2 beta version from [Archi project in Patreon](https://www.patreon.com/cw/architool).

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

In the instance of clean Archi, install the latest testing version of coArchi2, as below (as of 2025/11/20, it's version 1.2.5):

![coArchi version 20251120](img/coarchi2_version_20251120.png)

## Initial Collaboration Model in coArchi2 and Compare with coArchi1

In below comparison, left is coArchi1, right is coArchi2

### Open Local Model

I'm using one same "Archi-Meta-Model" local file as example.

On the same screen resolution, icons size in coArchi2 looks slightly bigger than coArchi1.

And there's one new icon "Toggle Tags" is added in coArchi2

![open local model, plug-in icons](img/01_plug-in-icons.png)

### `Collaboration` Menu

Here is the difference when show `Collaboration` menu:

| coArchi1 | coArchi2|
| --- | --- |
| ![menu_coArchi1](img/02_collaboration-menu_coArchi1.png) | ![menu_coArchi2](img/02_collaboration-menu_coArchi2.png) |

In coArchi2, the first item doesn't have `... and Publish` text.

### Create Empty Repository (GitHub)

| coArchi1 | coArchi2|
| --- | --- |
| ![coArchi1 new repo](img/03_new-repo_coArchi1_result.png) | ![coArchi2 new repo](img/03_new-repo_coArchi2_result.png) |
| URL: https://github.com/yasenstar/Archi_Test_coArchi1 | URL: https://github.com/yasenstar/Archi_Test_coArchi2 |

### `Add Local Model to Workspace`

Choose from menu [Collaboration]->[Add Model to Workspace...], or right click model name in the model tree, choose from pop-up menu.

Enter or create a `Primary Password`, it's pop up `New Mode Repository` dialog, fill in URL / User Name  / Passwork (Token).

When adding model in coArchi2, no `Primary Password` popup, directly display the "Add Model to Workspace" dialog, while, after publishing, there's asking for a `password hint`:

![coArchi2 pwd hint](img/04_add-local-model-to-workspace_coArchi2_pwd-hint.png)

The `New Model Repository` dialog is different:
- coArchi1: only have OK / Cancel, so when you click OK, it will do "Add" and "Publish" together
- coArchi2: now have Add / Add & Publish / Cancel, so you may more precisely choose the action. (here I choose `Add & Publish` directly)

The remote repository structure is different:
- coArchi1: show as `model` folder
- coArchi2: show single `model.archimate` file

The local collaboration tab display is different:
- coArchi1: show just model name, here is `Archi-Meta-Model`
- coArchi2: show branch name after model name, here is `Archi-Meta-Model [Main]`


| Steps | coArchi1 | coArchi2|
| --- | --- | --- |
| 1. Choose Add Model Menu | ![add model to workspace coArchi1](img/04_add-local-model-to-workspace_coArchi1.png) | ![add model to workspace coArchi2](img/04_add-local-model-to-workspace_coArchi2.png) |
| 2. Set Repo Paramenter | ![repo param coArchi1](img/04_add-local-model-to-workspace_coArchi1_repo-param.png) | ![repo param coArchi2](img/04_add-local-model-to-workspace_coArchi2_repo-param.png) |
| 3. Published to Remote Repo | ![repo published coArchi1](img/04_add-local-model-to-workspace_coArchi1_repo-published.png) | ![repo published coArchi2](img/04_add-local-model-to-workspace_coArchi2_repo-published.png) |
| 4. Collaboration Tab with Model | ![local collab tab coArchi1](img/04_add-local-model-to-workspace_coArchi1_local-collaboration-tab.png) | ![local collab tab coArchi2](img/04_add-local-model-to-workspace_coArchi2_local-collaboration-tab.png) |

---

Updated at 11/20/2025, 10:16:26 AM 