# Vidly-Mvc5 Web Appliaction

Vidly is a kind of MovieRental store where a Customer can pick any memebership type and watch movies according to it. a user have a option of register/login via Facebook Authentication.

## Technologies I used

- Asp.net web Framework
- Codefirst migrations with EF
- HTML/CSS/Javascript/C#

## Installation of Vidly To Your Machine.

Clone this repo to your machine. If you need help with this part, GitHub has [great documentation](https://help.github.com/articles/fork-a-repo/)

I have done this whole Project in Visual Sudio 2019 Community Version.if you don't have Visual Studio setup in ur computer ,download it by [clicking here](https://visualstudio.microsoft.com/vs/)

after Clone, make sure you're in the `Vidly-mvc5/` directory and then open the Vidly.sLn(i.e Visual Studio Solution file).

If You are using Visual studio 2019 community Version make sure you have done the following steps:
Select the Tools > Options > NuGet Package Manager. Set both options under Package Restore. Select OK.

by doing above steps, all NuGet required packages are automatically restore.

Now ,one thing you need to manually do was that. In this project i've not disclose my facebook authentication access secret key n all that for security reasons. uh can manually generate your own by [clicking here](https://developers.facebook.com/)

We're getting so close!one last thing you need to manually do was that:
`<connectionStrings>
		<add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=aspnet-Vidly-adc52a57-90a8-45f6-82b4-9f9803dd9ae7;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnet-Vidly-adc52a57-90a8-45f6-82b4-9f9803dd9ae7.mdf" providerName="System.Data.SqlClient" />
	</connectionStrings>`
simply, remove the `;AttachDBFilename=|DataDirectory|\aspnet-Vidly-adc52a57-90a8-45f6-82b4-9f9803dd9ae7.mdf` code, so that you can simply connect this web application with your database.

Now,one last step. open the package manager console(Tools> NuGet Package Manager > Package Manager Console) and type the cmd.
`update-database`

run this application by clicking `ctrl + f5` together in developnet mode.

 
## NOTE

And if you are using any other editor like Visual studio code(this was the fav. of programmers), then make sure uh have install the C# extension and restore the all required NuGet packages for this project.
checkout this amazing [article](https://code.visualstudio.com/docs/languages/dotnet) for more details.


## About the author

[LinkedIn - Nikhil Mahajan](https://www.linkedin.com/in/nikhil-mahajan-92b9631a0/ "Nikhil Mahajan's LinkedIn profile")

```

```
