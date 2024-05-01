# Query on Archi's HTML Exported Report

Use ArchiSurance finished model as sample, export HTML report from Archi ver5.3, the report file folder is [here](https://github.com/yasenstar/ArchiSurance_Practice/tree/main/ArchiSurance_HTML_5.3), like below file structure.

![archi-html-query-01](img/html-query-01.png)

## Open the HTML Report

Several methods:

1. Once you've exported the HTML report to your local disk, you can directly double-click the index.html file to open the report in your default web browser
2. Within `Archi`, from menu, select `Tools > Preview HTML Report`
3. You can copy / publish your exported report folder to any of your web server (local or remote), then use URL of your web server to access it

The third tab is the SQL window - alasql

![archi-html-query-02](img/html-query-02.png)

## Show TABLES of the HTML Report

You may imagine there's relational database structure of the HTML report, so let's use the first query statement to list the tables:

```sql
SHOW TABLES
```

You show see below list result:

![archi-html-query-03](img/html-query-03.png)

## Understand the Data Model

Here is the table relationships (built by RISE EDITOR):

![Archi-HTML-DB-Model](./ArchiHTML.png)

## Basic Query - Show Table Contents

Let's use `TOP x` to limit the numbers of return items.

To see first 10 rows of columns (fields) in the `Elements` table you may enter:

```sql
SELECT TOP 10 * FROM Elements
```

![archi-html-query-04](img/html-query-04.png)

