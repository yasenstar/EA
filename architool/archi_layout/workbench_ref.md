# Reference on `elementId` in `workbench.xmi`

Purpose of this file is to map the front-end layout components with their `elementId` used in `workbench.xmi`.

The `xmi` file is used to store persistently the layout of Archi screens, it can be found in below path:

- Linux or MacOS: `<user.home>/.archi/.metadata/.plugins/org.eclipse.e4.workbench/workbench.xmi`
- Windows (win11): `C:\Users\<userID>\AppData\Roaming\Archi\.metadata\.plugins\org.eclipse.e4.workbench\workbench.xmi`

Here is the key components mapping:

| Component in Archi Screen | elementId in workbench.xmi |
| --- | --- |
| Branches | org.archicontribs.modelrepository.branchesView |
| Change History | org.archicontribs.modelrepository.historyView |
| Collaboration Workspace | org.archicontribs.modelrepository.modelRepositoryView |
| Hints | com.archimatetool.help.hintsView |
| Lightbox | com.archimatetool.vista.vistaView |
| Models | com.archimatetool.editor.treeModelView |
| Palette | org.eclipse.gef.ui.palette_view |
| Properties | com.archimatetool.editor.propertiesView |
| Scripts Console | com.archimatetool.script.consoleView |
| Scripts Manager | com.archimatetool.script.scriptsView |
| Validator | com.archimatetool.hammer.validatorView |
| Visualiser | com.archimatetool.zest.zestView |

The file is updated everytime you close the Archi tool.