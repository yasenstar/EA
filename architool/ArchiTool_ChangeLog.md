# Archi Change Log

## Archi 5.5.0 (Early Access)

New Features

- Add line style to diagram objects (solid, dotted, dashed and none)
- Delete container object in a diagram and keep children
- Add Views to Models Tree search filter
- User Property keys are now selected in a dialog in the Models Tree search filter
- Diagram connections are now hidden when nested

Improvements

- Bundled Java Runtime is version 17.0.13
- Nested connection to connections are no longer deleted but are now hidden
- Ensure a minimum label width of labels in Property sections
- Add support for default values of internal features
- Template management optimised and some fixes applied
- Update Jasper Reports to version 6.12.2

Fixes

- Fix diagram objects not selected on right-click (regression in version 5.4)
- Fix possible dangling connections when nesting connections with connections
- Fix possible empty/zombie diagram editors with a "This View is no longer available" message after performing "Save As" (added at 2025/01/14 build): ref issue is [here](https://forum.archimatetool.com/index.php?topic=1603.msg8178;topicseen#msg8178)
- Fix possible NPE when using "Link to View" with empty/zombie diagram editors
- Fix Preferences not retrieving default font if set in custom preferences file
- Internal improvements and fixes