---
ai_generated: true
model: "GPT-4.1"
operator: "GitHub Copilot"
chat_id: "workspace-architecture-standards-20260518"
prompt: |
  Create an instruction file for this project that includes:
  - architecture boundaries
  - coding standards
  - testing rules
  - modernization guidelines
started: "2026-05-18T00:00:00Z"
ended: "2026-05-18T00:00:00Z"
task_durations:
  - task: "instruction authoring"
    duration: "00:10:00"
total_duration: "00:10:00"
ai_log: "ai-logs/2026/05/18/workspace-architecture-standards-20260518/conversation.md"
source: "github-copilot-chat"
---

# Project Architecture & Coding Standards Instructions

## 1. Architecture Boundaries

- **Layered Structure:**
  - **Controllers:** Handle HTTP requests, validate input, and delegate to services. No business logic.
  - **Services:** Contain business logic, orchestrate workflows, and interact with repositories/data.
  - **Data Layer:** Entity Framework DbContext and models. No direct data access from controllers.
  - **DTOs:** Used for all API input/output. Never expose domain models directly.
  - **Profiles:** Use AutoMapper profiles for DTO ↔ Model mapping.
  - **Exceptions:** Centralized exception handling. Never throw raw exceptions from controllers.
- **No Cross-Layer Leakage:**
  - Controllers must not access the data layer directly.
  - Services must not reference controllers.
  - DTOs must not contain business logic.
- **Configuration:**
  - All secrets and environment-specific settings must be in configuration files, not source code.

## 2. Coding Standards

- **C#:**
  - Use PascalCase for class, method, and property names.
  - Use camelCase for local variables and parameters.
  - Always use explicit access modifiers.
  - Prefer expression-bodied members for simple properties/methods.
  - Use async/await for all I/O operations.
  - Avoid magic strings/numbers; use constants or enums.
  - Write XML doc comments for all public APIs.
- **HTML/JS:**
  - Use semantic HTML5 elements.
  - Prefer const/let over var in JS.
  - No inline event handlers; use addEventListener.
  - Use strict equality (===) in JS.
  - Keep scripts modular and decoupled from DOM structure.
- **General:**
  - Remove dead code and unused dependencies promptly.
  - Keep methods short and focused (max ~20 lines if possible).
  - Use meaningful names for all symbols.
  - Follow .editorconfig and .gitignore conventions.

## 3. Testing Rules

- **Unit Tests:**
  - All business logic in services must be covered by unit tests.
  - Use xUnit for .NET tests; keep test methods small and descriptive.
  - Mock dependencies (e.g., DbContext, external services) in unit tests.
  - Test both success and failure paths.
- **Integration Tests:**
  - Cover API endpoints and data access.
  - Use in-memory database for integration tests.
  - Never depend on external systems for CI tests.
- **Test Coverage:**
  - Maintain >80% code coverage for business logic.
  - Add tests for all bug fixes and new features.
- **Test Naming:**
  - Use Arrange-Act-Assert pattern.
  - Name tests as MethodName_StateUnderTest_ExpectedBehavior.

## 4. Modernization Guidelines

- **.NET:**
  - Target the latest LTS version of .NET (currently .NET 8).
  - Use SDK-style projects and nullable reference types.
  - Prefer dependency injection for all services.
  - Remove legacy or deprecated packages promptly.
- **Security:**
  - Never store secrets in source control.
  - Use environment variables or secret managers for sensitive config.
  - Enable HTTPS and validate JWT settings.
- **Frontend:**
  - Use modern JS (ES6+) and CSS features.
  - Ensure accessibility (a11y) for all UI.
  - Minimize direct DOM manipulation; prefer frameworks or vanilla JS modules.
- **Documentation:**
  - Update README and docs with all major changes.
  - Document architecture decisions (ADRs) for significant shifts.
- **Evergreen Practices:**
  - Regularly review dependencies for updates and vulnerabilities.
  - Refactor for clarity and maintainability, not just feature delivery.
  - Follow the Evergreen Software Development Principles in .github/instructions/evergreen-software-development.instructions.md

---

**Location:** .github/instructions/architecture-coding-testing-modernization.instructions.md
**Owner:** Development Team
**Last Updated:** 2026-05-18
