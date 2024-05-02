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
- [The AlaSQL Wiki in GitHub](https://github.com/AlaSQL/alasql/wiki)
- [alasql wiki site](https://alasql-wiki.readthedocs.io/en/latest/readme.html)
- [SQL Queries in the HTML Report in Archi GitHub](https://github.com/archimatetool/archi/wiki/SQL-queries-in-the-HTML-report)
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

### List Sepcific Properties with their Value

First, as we learnt just now, let's get the full list of the Properties (name) in your model, so that you can use them for querying:

```sql
SELECT DISTINCT Properties.propkey FROM Properties
```

Luckily, our `ArchiSurance` model doesn't have too many Properties, like below result:

![archi-html-query-13](img/html-query-13.png)

Then, let's try to query the value of Property with key as `Phase`, and hope the results are in unique value

```sql
SELECT DISTINCT propkey, propvalue FROM Properties WHERE propkey = 'Phase'
```

![archi-html-query-14](img/html-query-14.png)

If you don't point out `DISTINCT`, below will be the result as reference:

![archi-html-query-15](img/html-query-15.png)

Using this way, you can query any values from those 7 tables.

### List All Types of Relationship Used in the Model

```sql
SELECT DISTINCT Relationships.type FROM Relationships
```

![archi-html-query-17](img/html-query-17.png)

---

## Query from Combined Tables

Now let's move to next level, the actual power of learn from your Archi model is to general insights from multiple tables instead of single plain table, let's practice the `JOIN` clause

### List Some Elements with their Properties

In ArchiSurance model, we created two Properties - "Capability Level" & "Phase" - for some Business Capabilties, let's query those Capabilities together with those Properties Key and Value, as below:

```sql
SELECT e.name, p.propkey, p.propvalue
FROM Elements e JOIN Properties p
ON e.id = p.conceptid
WHERE e.type = 'Capability'
```

You may aware, alasql automatically add `INNER` before `JOIN`, for Archi model, it's same as direct `JOIN` without `INNER`. However, if you use `OUTER JOIN` you will get wrong (incorrect) results.

![archi-html-query-16](img/html-query-16.png)

### List Application Coorperation Relationships

In ArchiSurance Figure-22, we modeled the application to application relationship with Flow-Relation notation, let's write a query to list those.

```sql
SELECT r.sourceid, e1.name AS sourceName, r.type, r.targetid, e2.name AS targetName
FROM Relationships r
INNER JOIN Elements e1 ON r.sourceid = e1.id
INNER JOIN Elements e2 ON r.targetid = e2.id
WHERE
    r.type = 'FlowRelationship' AND
    e1.type = 'ApplicationComponent' AND
    e2.type = 'ApplicationComponent'
```

![archi-html-query-18](img/html-query-18.png)

---

## Summary

This article only list limited query use cases, however, I hope from basic to combined query demo, you are now familiar of the table structures of Archi's HTML exported report, and from those samples, you can write your query to fit in your own data scenario.

Welcome to hear any of your comments.

Author: Xiaoqi Zhao
Date: May 1st, 2024 (Montreal)