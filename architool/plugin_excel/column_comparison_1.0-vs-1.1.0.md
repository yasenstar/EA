# Excel Export Plug-in - Column Comparison

- [Excel Export Plug-in - Column Comparison](#excel-export-plug-in---column-comparison)
- [Brief](#brief)
  - [Tab - Elements](#tab---elements)
  - [Tab - Relationships](#tab---relationships)
  - [Tab - Properties](#tab---properties)
  - [Tab - Specializations](#tab---specializations)

# Brief

Export to Excel plug-in (version 1.0.0) had been released at Feb 3rd, 2023, after more than 2 years, at September 18th 2025, the version 1.1.1 has been released.

It is good to enjoy the newer version with the added features, however, during initial usage, I found the column headers' name changes need to be aware, since that's making my data load & transformation in Power BI (and other analytical tool) crash in certain steps. This document intends to compare the differences and as the guide to update all of those transformation queries in Power BI (just one sample of tool).

## Tab - Elements

| Excel Plug-in 1.0.0 | Excel Plug-in 1.1.1| Memo |
| --- | --- | --- |
| Name | Name | |
| Type | Type | |
| ID | Id | Changed |
| Documentation | Documentation | |
| Specialization | Specialization | |

## Tab - Relationships

| Excel Plug-in 1.0.0 | Excel Plug-in 1.1.1| Memo |
| --- | --- | --- |
| Name | Name | |
| Type | Type | |
| ID | Id | Changed |
| Documentation | Documentation | |
| Source | Source | |
| Source ID | Source Id | Changed |
| Target | Target | |
| Target ID | Target Id | Changed |
| Specialization | Specialization | |

## Tab - Properties

| Excel Plug-in 1.0.0 | Excel Plug-in 1.1.1| Memo |
| --- | --- | --- |
| Owner | Owner Name | Changed |
| Type | Owner Type | Changed |
| ID | Owner Id | Changed |
| Key | Key | |
| Value | Value | |

## Tab - Specializations

New in ver 1.1.0, with following columns:

- Name
- Type
- Id