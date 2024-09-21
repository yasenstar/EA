# SPARQL for Querying LeanIX Meta-Model Ontology

## PREFIX

```sql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX owl: <http://www.w3.org/2002/07/owl#>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
PREFIX leanix: <http://www.semanticweb.org/yasen/ontologies/2024/8/metamodel-leanix#>
```

## Queries

### Select base on Specific Relation - FILTER

```sql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX owl: <http://www.w3.org/2002/07/owl#>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
PREFIX leanix: <http://www.semanticweb.org/yasen/ontologies/2024/8/metamodel-leanix#>
SELECT ?subject ?relation ?object
	WHERE { ?subject ?relation ?object .
		FILTER ( ?relation = leanix:uses )
}
```

### Another way to select specific relation - BIND

```sql
PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
PREFIX owl: <http://www.w3.org/2002/07/owl#>
PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>
PREFIX xsd: <http://www.w3.org/2001/XMLSchema#>
PREFIX leanix: <http://www.semanticweb.org/yasen/ontologies/2024/8/metamodel-leanix#>
SELECT ?subject ?relation ?object
	WHERE { 
	BIND ( leanix:uses AS ?relation )
	?subject ?relation ?object .
}
```

