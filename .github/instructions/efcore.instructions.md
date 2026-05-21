---
ai_generated: true
model: "GPT-4.1"
operator: "GitHub Copilot"
chat_id: "workspace-core-tech-efcore-20260518"
prompt: |
  Create an instruction file for Entity Framework Core usage in this project.
started: "2026-05-18T00:00:00Z"
ended: "2026-05-18T00:00:00Z"
task_durations:
  - task: "EF Core instruction authoring"
    duration: "00:03:00"
total_duration: "00:03:00"
ai_log: "ai-logs/2026/05/18/workspace-core-tech-efcore-20260518/conversation.md"
source: "github-copilot-chat"
---

# Entity Framework Core Usage Instructions

- Define DbContext in Data/ and register in DI container.
- Use code-first migrations for schema changes.
- Never expose EF entities directly in API responses (use DTOs).
- Query with LINQ; avoid raw SQL unless necessary.
- Use async methods for all database operations.
- Seed test data in development only.
- Use in-memory provider for integration tests.
