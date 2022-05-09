# hash-tables

A [hash table](https://en.wikipedia.org/wiki/Hash_table) is an associative data structure with an array/list to contain the data. It is often that this structure is of fixed size. Items are stored in the structure at particular locations, but this location is calculated from their value. Thus the _key_ into the list is a _hash_ of their value, derived with a specific algorithm (possibly _seeded_ with some constant extra value). 

The hashing algorithm is designed to allow for uniform coverage of all possible location indices. 

## Collisions 

Given there are fewer slots in the structure than there are possible values to store, there will be occasions where two items will have identicial keys, these are called _collisions_. 

What to do in these cases? There are two approaches: _linear probing_ and _chaining_. 

(Well, strictly there's a third, to resize the array, but that's expensive and needs *all* keys to be recalculated.) 

## Further Reading 

- Bond 1, pp285--298. 
- [Baeldung.com](https://www.baeldung.com/cs/hash-tables) 
- [wikipedia](https://en.wikipedia.org/wiki/Hash_table)
- [wikibooks](https://en.wikibooks.org/wiki/Data_Structures/Hash_Tables)

## Tasks

See the [shared document](https://docs.google.com/document/d/1lXkSRJYWdgIysSzLaU5dLR_b3a0rKdVCAc9pabMqvec/edit?usp=sharing) for some things to do. 

*NB* there is a built-in `Hashtable` class, you should ignore this for now. 

There is an IHashTable.cs file in this repo which you could choose to use as the basis for the work outlined in the document. 
