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

## Reference Links for Alasql

- [AlaSQL GitHub Projects](https://github.com/AlaSQL)
- [The AlaSQL Wiki](https://github.com/AlaSQL/alasql/wiki)
- [A nice article: Analysis of Archimate models using SQL queries](https://fightingcomputers.nl/Guides/Analysis-of-Archimate-model-using-SQL-queries)

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

---

## Basic Query - Show Table Contents

Let's use `TOP x` to limit the numbers of return items.

### Table: Elements

To see first 10 rows of columns (fields) in the `Elements` table you may enter:

```sql
SELECT TOP 10 * FROM Elements
```

![archi-html-query-04](img/html-query-04.png)

Below are the TOP 5 reference for all other tables:

### Table: Relationships

```sql
SELECT TOP 5 * FROM Relationships
```

![archi-html-query-05](img/html-query-05.png)

### Table: Properties

```sql
SELECT TOP 5 * FROM Properties
```

![archi-html-query-06](img/html-query-06.png)

### Table: Views

```sql
SELECT TOP 5 * FROM Views
```

![archi-html-query-07](img/html-query-07.png)

### Table: ViewsContent

```sql
SELECT TOP 5 * FROM ViewsContent
```

![archi-html-query-08](img/html-query-08.png)

### Table: Folders

```sql
SELECT TOP 5 * FROM Folders
```

![archi-html-query-09](img/html-query-09.png)

### Table: FoldersContent

```sql
SELECT TOP 5 * FROM FoldersContent
```

![archi-html-query-10](img/html-query-10.png)

---

## More Query Practices

Here I'm listing several sample from variable use cases, it may not cover all but intend to show you the approach of making more complex and specific querying.

### List Specific Type of Elements

Use case: show all `capability`

```sql
SELECT TOP 10 * FROM Elements As e WHERE e.type = 'Capability'
```

![archi-html-query-11](img/html-query-11.png)

Please be noted that it's case sensitive within SQL statements, so if you put `'capability'`, you will get empty result.

In order to key in the correct wording, it would be useful that you gradually summarize certain "dictionary" for your self using, e.g. all of the `Elements.type`, let's use below query to get that list in unique value:

```sql
SELECT DISTINCT Elements.type FROM Elements;
```

Then you can have below 38 Element Types as one list:

![archi-html-query-12](img/html-query-12.png)
