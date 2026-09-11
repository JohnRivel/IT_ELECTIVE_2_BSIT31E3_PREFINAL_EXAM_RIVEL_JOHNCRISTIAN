# ExamReviewer

this is a simple MVC application where i show the question and answer with someone decent design

# Questions & Answers

1. What is the main problem solved by using a database instead of an in-memory collection?
   Answer: C 
   
2. Which approach is being used when an existing database is used to generate EF Core entity classes?
   Answer: B 

3. What is the primary purpose of Entity Framework Core?
   Answer: C
   
4. Which EF Core component is primarily responsible for communicating with the database?
   Answer: A 

5. What does the following command primarily do? `dotnet ef dbcontext scaffold "ConnectionString" Microsoft.EntityFrameworkCore.SqlServer -o Models`
   Answer: C 

6. Where is a database connection string commonly stored in an ASP.NET Core MVC application?
   Answer: A 

7. A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?
   Answer: B 

8. In the following example, what is SectionId? public int SectionId { get; set; }  public Section Section { get; set; }
   Answer: B 

9. What is the purpose of a navigation property such as public Section Section { get; set; }?
   Answer: B 

10. What does .Include() generally allow EF Core to do?
    Answer: B 

11. Why might a ViewModel be used when displaying Student and Section information?
    Answer: B 

12. Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?
    Answer: A 

13. Which type of validation occurs in the browser before a request is sent to the server?
    Answer: D 

14. Why is server-side validation still necessary if client-side validation exists?
    Answer: B 

15. A school requires every student to have a unique Student Number. Which rule best represents this requirement?
    Answer: B 

16. Which is the best reason for having a database-level unique constraint on StudentNumber?
    Answer: A 

17. What is the purpose of a try...catch block in a controller?
    Answer: B 

18. Which middleware is commonly used in ASP.NET Core for centralized exception handling?
    Answer: B

19. A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?
    Answer: B

20. A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?
    Answer: A 
