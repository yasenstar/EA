# Query on Archi's HTML Exported Report

Use ArchiSurance finished model as sample, export HTML report from Archi ver5.3, the report file folder is [here](https://github.com/yasenstar/ArchiSurance_Practice/tree/main/ArchiSurance_HTML_5.3), like below file structure.

![archi-html-query-01](img/html-query-01.png)

## Open the HTML Report

Several methods:

1. Once you've exported the HTML report to your local disk, you can directly double-click the index.html file to open the report in your default web browser
2. Within `Archi`, from menu, select `Tools > Preview HTML Report`
3. You can copy / publish your exported report folder to any of your web server (local or remote), then use URL of your web server to access it

The third tab is the SQL window - alasql

![archi-htmo-query-02](img/html-query-02.png)

## Show TABLES of the HTML Report

You may imagine there's relational database structure of the HTML report, so let's use the first query statement to list the tables:

```sql
SHOW TABLES
```

## Understand the 