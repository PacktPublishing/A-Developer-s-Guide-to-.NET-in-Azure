# A Developer's Guide to .NET in Azure

<a href="https://www.packtpub.com/product/a-developers-guide-to-net-in-azure/9781837633012"><img src="https://m.media-amazon.com/images/I/81NYbUNw8vL._SY385_.jpg" alt="Book Name" height="256px" align="right"></a>

This is the code repository for [A Developer's Guide to .NET in Azure](https://www.packtpub.com/product/a-developers-guide-to-net-in-azure/9781837633012), published by Packt.

**Build quick, scalable cloud-native applications and microservices with .NET 6.0 and Azure**

## What is this book about?
A Developer’s Guide to .NET in Azure helps you embark on a transformative journey through Microsoft Azure that is tailored to .NET developers. This book is a curated compendium that’ll enable you to master the creation of resilient, scalable, and highly available applications.
The book is divided into four parts, with Part 1 demystifying Azure for you and emphasizing the portal's utility and seamless integration. The chapters in this section help you configure your workspace for optimal Azure synergy. You’ll then move on to Part 2, where you’ll explore serverless computing, microservices, containerization, Dapr, and Azure Kubernetes Service for scalability, and build pragmatic, cost-effective applications using Azure Functions and Container apps. Part 3 delves into data and storage, showing you how to utilize Azure Blob Storage for unstructured data, Azure SQL Database for structured data, and Azure Cosmos DB for document-oriented data. The final part teaches you about messaging and security, utilizing Azure App Configuration, Event Hubs, Service Bus, Key Vault.

This book covers the following exciting features: 
* Discover how to create serverless apps and services
* Design microservices with Azure Kubernetes service
* Get to grips with different Azure databases and storage services
* Familiarize yourself with event-driven architecture
* Understand how to leverage Azure Service Bus and Azure Event Hubs
* Find out how to protect APIs and apps using Azure B2C

If you feel this book is for you, get your [copy](https://www.amazon.com/Developers-Guide-NET-Azure-microservices-ebook/dp/B0CC28Y2L9) today!

<a href="https://www.packtpub.com/?utm_source=github&utm_medium=banner&utm_campaign=GitHubBanner"><img src="https://raw.githubusercontent.com/PacktPublishing/GitHub/master/GitHub.png" alt="https://www.packtpub.com/" border="5" /></a>

## Instructions and Navigations
All of the code is organized into folders. For example, Chapter03.

The code will look like the following:
```
app.MapGet("/weatherforecast", async (HttpClient httpClient,DaprClient daprClient) =>
{
   var weatherForecasts = await daprClient.GetStateAsync<WeatherForecast[]>("statestore", "weatherforecast");
   if (weatherForecasts == default)
   {
       weatherForecasts = await httpClient.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");
       await daprClient.SaveStateAsync("statestore","weatherforecast", weatherForecasts);
   }
   return weatherForecasts;
})
.WithName("GetWeatherForecast");

```

**Following is what you need for this book:**
This book is for .NET developers and architects who are eager to master the art of creating and deploying robust applications using .NET and Azure. A foundational understanding of .NET and Azure will enable you to enhance your skills with this resourceful guide. Developers aspiring to explore the realms of microservices and serverless applications within the .NET and Azure landscapes will find this book invaluable.

With the following software and hardware list you can run all code files present in the book (Chapter 1-13).

### Software and Hardware List

| Chapter  | Software required                                                              | OS required                        |
| -------- | -------------------------------------------------------------------------------| -----------------------------------|
| 1-13     | NET 6.0, Microsoft Azure, Visual Studio Code, Visual Studio 2022, Docker, Dapr | Windows, Mac OS X, and Linux (Any) |


### Related products <Other books you may enjoy>
* Azure for Developers - Second Edition [[Packt]](https://www.packtpub.com/product/azure-for-developers-second-edition/9781803240091) [[Amazon]](https://www.amazon.com/Azure-Developers-ecosystems-containers-serverless/dp/1803240091)

* FinOps Handbook for Microsoft Azure [[Packt]](https://www.packtpub.com/product/finops-handbook-for-microsoft-azure/9781801810166) [[Amazon]](https://www.amazon.com/FinOps-Handbook-Microsoft-Azure-Empowering/dp/1801810168)

## Get to Know the Authors
**Anuraj Parameswaran**
He is  is a seasoned IT expert with over 19 years of experience, starting in 2004, with a strong focus on Azure and .NET technologies. Currently serving as the Chief Technology Officer (CTO) of Socxo Solutions Pvt. Ltd., he has received seven prestigious Microsoft MVP awards. Anuraj actively participates in mentoring programs, delivers speeches at various events, and contributes extensively to both Microsoft and Azure communities. His commitment to sharing knowledge and embracing lifelong learning is exemplified by his involvement as a technical reviewer for Packt books.

**Tamir Al Balkhi**
He is a technology problem solver with 15 years of experience developing innovative and effective solutions for clients across various industries, including healthcare, finance, and retail. From steering small to medium-sized business projects to overseeing large enterprise implementations, Tamir has consistently demonstrated exceptional leadership and technical prowess. As a cloud architect and Chief Technology Officer (CTO), Tamir specializes in designing and delivering best-in-class cloud solutions within the Microsoft Azure ecosystem. His agile-first mindset and commitment to a test-driven delivery approach have been instrumental in his ability to deliver projects on time, within budget, and beyond client expectations.
