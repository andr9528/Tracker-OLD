# How to Understand

## Contracts

Any entity interface inherits from:
- IEntity
- ISearchable<Insert Entity Name>

The ISearchable interface contains all properties that is searchable from a Database connection handler, 
as not everything is possible or needed to search by.
The ISearchable interfaces inherits from:
- ISearchableEntity
- I<Insert Entity Name>Dto

The IDto interfaces contain all properties that a user somehow has to
directly or indictly supply when an entity of the Dto type has to be generated.