# Resume Editor

## Scope

The aim of this console application is to allow the user to fill his resume information and generate a document in pdf format.

I have created two projects :

- **ResumeEditor.Console**

  Contains the console menus, and code. 

- **ResumeEditor.BusinessLogic**
  
  Contains the models, enums and any shared code that can be used by other clients aventually (web, desktop, ...)
  
## PDF Export

I have used iTextSharp library to create the PDF documents. The library dll is included in the project.

## Starting the project

```js
// Clone the repository
git clone https://github.com/nabill/ResumeEditor.git

// Open the console application folder
cd ResumeEditor/src/ResumeEditor.Console

// run the application
dotnet run
```
