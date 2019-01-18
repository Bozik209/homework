# MongoDB Final task 
## boaz yakobi
### 313352437
1. Connect to a local running mongo instance, use a database named mongo_practice.
```
cmd->mongod 
new cmd->mongo  
use mongo_practice
```

2. Insert the following documents into a movies collection.
```
db.createCollection("movies")
```
```
db.movies.insert([
	{
        "title" : "Fight Club",
        "writer" : "Chuck Palahniuk",
        "year" : 1999,
        "actors" : [
        "Brad Pitt",
        "Edward Norton",
        ]
	},
	{
		"title" : "Pulp Fiction",
        "writer" : "Quentin Tarantino",
        "year" : 1994,
        "actors" : [
        "John Travolta",
        "Uma Thurman",
        ]
	},
	{
        "title" : "Inglorious Basterds",
        "writer" : "Quentin Tarantino",
        "year" : 2009,
        "actors" : [
        "Brad Pitt",
        "Diane Kruger",
        "Eli Roth",
        ]
	},
    {
        "title" : "The Hobbit: An Unexpected Journey",
        "writer" : "J.R.R. Tolkein",
        "year" : 2012,
        "franchise" : "The Hobbit"
    },
    {
        "title" : "The Hobbit: The Desolation of Smaug",
        "writer" : "J.R.R. Tolkein",
        "year" : 2013,
        "franchise" : "The Hobbit"
    },
    {
        "title" : "The Hobbit: The Battle of the Five Armies",
        "writer" : "J.R.R. Tolkein",
        "year" : 2012,
        "franchise" : "The Hobbit",
        "synopsis" : "Bilbo and Company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness."
    },
    {
        "title" : "Pee Wee Herman's Big Adventure"
    },
    {
        "title" : "Avatar"
    }
])
```

* pretty() = Configures the cursor to display results in an easy-to-read format.

3. get all documents
```
db.movies.find().pretty()
```

4. get all documents with writer set to "Quentin Tarantino"
```
db.movies.find({"writer":"Quentin Tarantino"}).pretty()
```


5. get all documents where actors include "Brad Pitt"
```
db.movies.find({"actors":"Brad Pitt"}).pretty()
```


6. get all documents with franchise set to "The Hobbit"
```
db.movies.find({"franchise":"The Hobbit"}).pretty()
```
7. get all movies released in the 90s year 
``` 
db.movies.find({"year":{$gte:1990,$lte:2000}}).pretty()
```

8. get all movies released before the year 2000 or after 2010
```
db.movies.find( {$or: [ {"year":{$gte:2010}},{"year":{$lte:2000}}]} ).pretty()

```

9. add a synopsis to "The Hobbit: An Unexpected Journey" : "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home - and the gold within it - from the dragon Smaug."
```
db.movies.update(
    {"title" : "The Hobbit: An Unexpected Journey",},
    { $push: { "synopsis": "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home - and the gold within it - from the dragon Smaug." } }
)
```

10. add a synopsis to "The Hobbit: The Desolation of Smaug" : "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug. Bilbo Baggins is in possession of a mysterious and magical ring."
```
db.movies.update(
    {"title" : "The Hobbit: The Desolation of Smaug",},
    { $push: { "synopsis": "The dwarves, along with Bilbo Baggins and Gandalf the Grey, continue their quest to reclaim Erebor, their homeland, from Smaug. Bilbo Baggins is in possession of a mysterious and magical ring." } }
)
```


11. add an actor named "Samuel L. Jackson" to the movie "Pulp Fiction"
```
db.movies.update(
    {"title" : "Pulp Fiction",},
    { $push: { "actors" :"Samuel L. Jackson"} }
)
```

12. find all movies that have a synopsis that contains the word "Bilbo" 
```
db.movies.createIndex( { synopsis: "text" } )
db.movies.find( { $text: { $search: "Bilbo" } } ).pretty()
```


13. find all movies that have a synopsis that contains the word "Gandalf"
```
db.movies.find( { $text: { $search: "Gandalf" } } ).pretty()
```

14. find all movies that have a synopsis that contains the word "Bilbo" and not the word "Gandalf"
```
db.movies.find( { $text: { $search: "Bilbo -Gandalf" } } ).pretty()
```
15. find all movies that have a synopsis that contains the word "dwarves" or "hobbit"
```
db.movies.find({$text: {$search: "dwarves hobbit"}}).pretty()
```

16. find all movies that have a synopsis that contains the word "gold" and "dragon"
```
db.movies.find({$text: {$search: "gold dragon"}}).pretty()
```

17. delete the movie "Pee Wee Herman's Big Adventure"
```
db.movies.remove({"title":"Pee Wee Herman's Big Adventure"})
```

18. delete the movie "Avatar"
```
db.movies.remove({"title":"Avatar"})

```