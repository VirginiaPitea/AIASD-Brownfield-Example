---
ai_generated: true
model: "GPT-4.1"
operator: "GitHub Copilot"
chat_id: "<copilot-chat-id>"
prompt: |
  Create an instruction file for .NET testing conventions and best practices in this repository.
started: "2026-05-21T00:10:00Z"
ended: "2026-05-21T00:15:00Z"
task_durations:
  - task: "requirements gathering"
    duration: "00:02:00"
  - task: "instruction authoring"
    duration: "00:03:00"
total_duration: "00:05:00"
ai_log: "ai-logs/2026/05/21/<copilot-chat-id>/conversation.md"
source: "github-copilot-chat"
name: dotnet-testing
applyTo: "**/*"
description: Guidance for .NET testing practices in this repository
version: "1.0.0"
author: "GitHub Copilot"
tags: ["dotnet", "testing", "xunit", "unit-tests", "integration-tests"]
owner: "Development Team"
reviewedDate: "2026-05-21"
nextReview: "2026-08-21"
---

# .NET Testing Instructions

## Overview

This file defines conventions and best practices for writing and running tests in .NET projects within this repository. Follow these guidelines for all unit, integration, and API tests.

## Test Framework

- Use xUnit as the primary test framework.
- Place all test projects in a `*.Tests` folder or project.
- Name test classes with the `Tests` suffix (e.g., `UserServiceTests`).

## Test Organization

- Group tests by feature or SUT (System Under Test).
- Use `[Fact]` for single-case tests and `[Theory]` for parameterized tests.
- Keep test methods small and focused on one behavior.

## Test Naming

- Use descriptive method names: `MethodName_StateUnderTest_ExpectedBehavior`.
- Example: `Login_WithValidCredentials_ReturnsToken()`

## Test Data

- Use in-memory databases (e.g., InMemory provider) for integration tests.
- Use test doubles (mocks, stubs) for dependencies.
- Avoid external dependencies in unit tests.

## Running Tests

- Use `dotnet test` to run all tests.
- Run tests in CI before merging PRs.
- Ensure all tests pass before committing.

## Best Practices

- Arrange-Act-Assert (AAA) pattern for test structure.
- Avoid logic in tests; keep assertions clear and direct.
- Test both positive and negative scenarios.
- Use FluentAssertions or xUnit assertions for clarity.
- Clean up resources in test teardown.

## Code Coverage

- Aim for high coverage, but prioritize meaningful tests over 100% coverage.
- Use coverage tools (e.g., Coverlet) to measure coverage.

## References

- [xUnit Documentation](https://xunit.net/docs/)
- [.NET Testing Overview](https://docs.microsoft.com/dotnet/core/testing/)

---

**Document Version**: 1.0.0
**Last Updated**: 2026-05-21
**Maintainer**: Development Team
**Related Instructions**: [.github/instructions/ai-assisted-output.instructions.md](.github/instructions/ai-assisted-output.instructions.md), [.github/instructions/evergreen-software-development.instructions.md](.github/instructions/evergreen-software-development.instructions.md)
