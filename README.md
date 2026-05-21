# PostHubAPI

The **PostHubAPI** is a blog API that provides complete CRUD (Create, Read, Update, Delete) functionalities for Posts and Comments, along with user registration capabilities.

## Technologies Used

- **C#**: Programming language used for API logic development.
- **ASP.NET Web API**: Framework used to create RESTful APIs on the .NET platform.
- **Entity Framework In Memory**: Object-Relational Mapping (ORM) tool that simplifies database access and manipulation.
- **AutoMapper**: Library simplifying object mapping in .NET applications.

## Features

- **CRUD for Posts**: Create, read, update, and delete blog posts.
- **CRUD for Comments**: Manage comments associated with each post.
- **User Registration**: Enable user registration and management to interact with the blog.
- **Calculator Endpoint**: Perform basic arithmetic operations (add, subtract, multiply, divide) via API.

## AI-Assisted Artifacts

- **calculator.html**: Standalone browser calculator UI with keyboard support and basic arithmetic operations.
- **PROJECT_REQUIREMENTS.md**: Project requirements document covering purpose, business rules, workflows, and tech stack architecture.
- **AI log (PROJECT_REQUIREMENTS.md)**: `ai-logs/2026/05/21/0224c69e-c6eb-4d85-9422-09cc4686a992/conversation.md`
- **Tech-stack instruction prompts**: Meta prompt files for generating stack-specific instruction files under `.github/prompts/meta/`.
- **AI log (tech-stack instruction prompts)**: `ai-logs/2026/05/21/create-tech-stack-instruction-prompts-20260521/conversation.md`
- **JWT auth instructions**: Repository guidance for JWT authentication and authorization at `.github/instructions/auth-jwt.instructions.md`.
- **AI log (JWT auth instructions)**: `ai-logs/2026/05/21/create-auth-jwt-instructions-20260521/conversation.md`

## How to Use

1. **Clone the Repository**:

```

git clone https://github.com/your-username/PostHubAPI.git

```

2. **Environment Setup**:

- Ensure you have Visual Studio or another .NET compatible IDE installed.
- Confirm that Entity Framework and AutoMapper are configured in the environment.

3. **Execution**:

- Open the project in your IDE.
- Run the application.

4. **Using the API**:

- Utilize the provided routes and endpoints to interact with the API functionalities.

## Authentication Configuration

- In `Development`, JWT `RequireHttpsMetadata` is disabled to support local non-HTTPS metadata scenarios.
- In non-development environments, JWT `RequireHttpsMetadata` is enabled by default.
- Configure `JWT:Secret` outside source control before starting the API.

### Local Secret Setup

1. Initialize user secrets for the project:

```powershell
dotnet user-secrets init --project .\PostHubAPI.csproj
```

2. Store a development JWT signing secret locally:

```powershell
dotnet user-secrets set "JWT:Secret" "replace-with-a-long-random-secret" --project .\PostHubAPI.csproj
```

3. As an alternative, set the `JWT__Secret` environment variable instead of using user secrets.

### Secret Rotation

1. Generate a new signing secret.
2. Update the user secret or `JWT__Secret` environment variable.
3. Restart the API so new tokens are issued with the rotated secret.
