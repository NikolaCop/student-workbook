Read Servers with Node/Express > MongoDb Relationships and answer the following questions
<!-- What are the three types of relationships? -->
One-To-One (1:1), One-To-Many (1:N), Many-To-Many (N:M)

<!-- What are the benefits of the traditional linking of relationships instead of Embedding -->

The reason we choose to embed all the references to categories in the books is due to there being lot more books in the drama category than categories in a book.

<!-- What are some of the challenges faced when deciding how to manage a many-to-many relationship that ultimately drive your decision on how to create it? -->

This makes it impracticable to embed all the books in a category document. Each book, however, can easily have categories embedded within it, as the rate of change of categories for a specific book might be very low.