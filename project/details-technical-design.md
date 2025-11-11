[< Back to Project Overview](README.md#technical-design)

# Technical Design Instructions and Rubric

At this point, you have devoted considerable time to thinking about and working on your project. You should have excellent ideas on how to implement your solution. Now that you have this knowledge and insight, you will produce a technical design detailing how you will build the most critical pieces of the system.

### Requirements

1.  [Start by carefully reading the Technical Design phase of the project.](README.md#technical-design)
2.  Produce all documentation in Markdown and properly integrate it into your team's GitHub project repository so it is easily found and read. Ensure that you write a concise introduction to the technical design.
3.  Your Technical Design includes the following 8 deliverables in your Technical Design document (prefaced by a Table of Contents linked to each section):
    1.  **Implementation Language(s) and Framework(s)** (2 sections, A-B)
        1.  **A. Implementation Language(s) including *why* your team selected them** For example, if you are using Flask, your languages are Python and HTML. Flask and Spring and ASP.NET are not languages - they are frameworks built in Python, Java, and C#. As always, write using bullets, lists, and tables... avoid huge paragraphs. Include links to your language's documentation, useful tutorials, etc. Your goal here is to help a developer understand why you chose the language and quickly learn more about it.
        2.  **B. Implementation Framework(s) including *why* your team selected them** For example, if you are using Java, the framework is Spring. Consider using a CSS framework, such as Bootstrap. Spring is a Java-based framework. Blazor is a C#-based framework. Include useful links to documentation for your framework(s). Your goal here is to help a developer understand your architecture and quickly learn more about it. Links to tutorials and videos are also quite helpful. As always, write using bullets, lists, and tables... avoid huge paragraphs.
    2.  **C. Data Storage Plan** (1 section, C)
        How will your application store data? Your choices are CSV, JSON, and SQL. Describe the libraries and technologies you will use to store data. For example, if you are using C#, you might use Dapper or Entity Framework for data access to write to an embedded SQLite database. If you are using Java, you might use a JDBC driver to access a Postgres database. Write this as a series of steps or bullet points. Avoid long, dull paragraphs. *Remember that the data you change/add must remain available the next time you start the application. This is a class project, but it needs to operate like a real application. Starting fresh every time you launch the application is not realistic. Therefore, you must have persistent data storage - not just memory storage. As always, write using bullets, lists, and tables... avoid huge paragraphs.*
    3.  **Entity Relationship Diagram, Entity/Field Descriptions and Data Examples** (4 sections, D-G)
        All the data your system manages, along with its relationships to each data type, will be visually depicted here. Your ERD design is not an academic exercise - it must align with what you actually plan to implement. Therefore, plan carefully, keeping in mind the data your User Interface design shows your application displaying and managing.
        -  **D. Entity Relationship Diagram:** Show every entity using Crows Foot notation, fields in the entity, plus the relationships and multiplicity.* I recommend drawing this in [Mermaid](https://mermaid.live/edit#pako:eNp1Uk1vwjAM_StWdtkk-AHtreJDmhgFFdhh6w5ea9qINqmcsIkB_30p7bSVjlziOM_2e7aPItEpCV8QjyVmjGWswJ1REMHpNBzqI4TBfDIejqPH50kEPmBR6E_zizo2Zn2MZakyYMqkM9FKrcJ9-U4My1kPVeKO-k5Hprj2vr5BhWzbmufmWk6i1SK8wVGaDqhPMWX5QWyeZELKkKMHsVjnBEXruIvFdcy95z3AVrKxIZbk8AtVHMDzIMmRMbEuHSBT0x9K-wmgwCa291HlWhFs_vRIKguYUUdxR2NfUoIc_df4AUxnN_Rf5CfUAbXF5kG4mQaj9SZyxXSttKZoNXwRa9DsJuW01vP3L5M0YiBK4hJl6pbpwi4WNienVvjOTJF3dUvODod7q1cHlQjf8p4GYl-laKldvx9nhepFa_fcYmHo_A0pm9Hm). Do *not* draw your ERD using [Chen Notation](https://vertabelo.com/blog/chen-erd-notation/). You must use [Crows Foot Notation](https://www.freecodecamp.org/news/crows-foot-notation-relationship-symbols-and-how-to-read-diagrams/). Your diagram must be displayed inline in your technical design document.

        -  **E. Table of Field Descriptions for each entity** List and describe every field of every entity and the data type. Include data type sizes you are using SQL (for example, nvarchar 50 is a 50 character Unicode string in SQL Server.) Note whether the field is required or nullable (can be empty). If the field is a key, note if it is a primary or foreign key. If the key is a foreign key, note the origin table of the value. 

        -  **F. Example Data** For each entity in your entity relationship diagram, create a table showing 3-5 sample records. Make sure they follow your data types described in the Table of Field Descriptions and are properly related to one another if there are foreign keys to other entities. Your goal here is to ensure a developer reading your entity design plan can see realistic examples of the types of data and how they related to one another.
        -  **G. Database Seed Data**
           When you start your application, what is *already* in the system? [We call this "seed data"](https://en.wikipedia.org/wiki/Database_seeding). Typically that includes at least one administrator account, your inventory items and photos, etc. This is *not* the same as example data. This is actual data your application requires to simply start the first time and will be present in your implementation. *Create a table describing your seed data for each entity that will contain data when the application starts.
    4.  [**H. Coding Style Guide**](https://www.cs.cornell.edu/courses/JavaAndDS/JavaStyle.html) (1 section, H)
        Here you will link to your language's coding style guide, plus add any coding style instructions you expect all developers to follow. A common feature of a coding style guide is source control management, such as use of git and perhaps a branch management strategy such as [GitFlow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow#:~:text=What is Gitflow%3F,lived branches and larger commits.) The ultimate goal is that all code follows a consistent style and appears to have been written by one person. Think about what will help future developers will need to understand your system, including commenting guidelines, naming conventions, filename conventions, etc. As always, write using bullets, lists, and tables... avoid huge paragraphs.
    5.  **Presentation** (1 section)
        Include a link that points to your technical design Loom presentation. Make sure the Loom presentation is public.

### Submission Steps

The entire team will work execute the technical design EFFORT. *All of you need* to review the completed work. This is a team effort and the team will succeed or fail as a group.

Submission is via your team GitHub repo. Material not in your team GitHub repo (or linked to Loom) will not be graded. Do not spread your project over multiple repositories.

### Grading Rubric

#### Component Percentages

1.  Implementation Language(s) and Framework(s) (2 sections, A & B) - 20%
2.  Data Storage Plan (1 section, C) - 15%
3.  Entity Design (4 sections, D, E, F & G) - 50%
4.  Coding Style Guide (1 section, H) - 5%
5.  3-5 minute video presentation describing your plan, technology selection and team assignments (Github) - 10%

#### File Structure (0% if correct, -10% if incorrect)

- Carefully follow the instructions *where* to place your Technical Design and how to format your materials. By this point, you know how. Therefore, there is no credit for this. But there is a penalty if you do not follow the instructions properly. Avoid penalties by carefully reviewing the requirements document and the grading rubric.

#### A. Implementation Language(s) and B. Framework(s) (20% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some writing or organizational issues.
-  70% to 79%: meets most requirements, may have some writing or organizational issues.
-  69% or below: does not meet most requirements or is very poorly written.

*Note: Written work not posted to Github using Markdown will not be graded.*

#### C. Data Storage Plan (10% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some minor graphical issues or organizational issues.
-  70% to 79%: meets most requirements, may have some minor graphical or organizational issues.
-  69% or below: does not meet most requirements or is very poorly drawn or contains incorrect information.

*Note: Documentation not posted to Github and linked to your Markdown will not be graded.*

#### Entity Design (50% of total), sections D, E, F, & G

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some minor graphical issues or organizational issues.
-  70% to 79%: meets most requirements, may have some minor graphical or organizational issues.
-  69% or below: does not meet most requirements or is very poorly drawn or contains incorrect information.

*Note: Documentation and diagrams not posted to Github and linked to your Markdown will not be graded.*

#### H. Coding Style Guide (5% of total)

-  90 to 100%: meets all requirements, well-written well organized, and highly professional. Polished work gets the top grade.
-  80% to 89%: meets all requirements, may have some minor graphical issues or organizational issues.
-  70% to 79%: meets most requirements, may have some minor graphical or organizational issues.
-  69% or below: does not meet most requirements or is very poorly drawn or contains incorrect information.

*Note: Documentation not posted to Github and linked to your Markdown will not be graded.*

#### Presentation Scoring (10% total)

*Do not just read requirements!*

-  90% to 100%: meets all requirements, well-organized, easy to follow audio. Polished work gets the top grade.
-  80% to 89%: meets all requirements, easy to follow audio, may have some organization issues.
-  70% to 79%: meets most requirements, may have some organization or audio issues.
-  69% or below: does not meet most requirements or has little or no audio.

*Note: Presentations not linked from Github to Loom will not be graded.*

### Academic Honesty

Your work must be your own. Do not plagiarize under any circumstances. All work is subject to review by TurnItIn, etc.

More importantly, this course is a waste of your time if you do not do the work yourself. If you are tempted to cheat, you need to ask yourself why you are here and what you hope to accomplish in your career if you get the grade, but have minimal ability to perform the work after you leave the University.

### Team Grading

Everyone on the team will receive the same grade with one exception. It follows.

Anyone not participating in the project may be removed from the team and have to perform the project alone. Before anyone can be "fired" from a team, I must meet with the *entire team* and hear what is happening. Do not fire anyone from your team without my explicit prior agreement.

---

[< Back to Project Overview](README.md#technical-design)
