---
ai_generated: true
model: "GPT-4.1"
operator: "GitHub Copilot"
chat_id: "workspace-core-tech-automapper-20260518"
prompt: |
  Create an instruction file for AutoMapper usage in this project.
started: "2026-05-18T00:00:00Z"
ended: "2026-05-18T00:00:00Z"
task_durations:
  - task: "AutoMapper instruction authoring"
    duration: "00:02:00"
total_duration: "00:02:00"
ai_log: "ai-logs/2026/05/18/workspace-core-tech-automapper-20260518/conversation.md"
source: "github-copilot-chat"
---

# AutoMapper Usage Instructions

- Define mapping profiles in Profiles/.
- Register all profiles in DI container at startup.
- Use AutoMapper for mapping between domain models and DTOs only.
- Keep mapping logic simple; avoid complex custom resolvers.
- Test mappings in unit tests for critical transformations.
