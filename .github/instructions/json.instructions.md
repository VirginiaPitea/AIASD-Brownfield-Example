---
ai_generated: true
model: "GPT-4.1"
operator: "GitHub Copilot"
chat_id: "workspace-core-tech-json-20260518"
prompt: |
  Create an instruction file for JSON usage in this project.
started: "2026-05-18T00:00:00Z"
ended: "2026-05-18T00:00:00Z"
task_durations:
  - task: "JSON instruction authoring"
    duration: "00:01:00"
total_duration: "00:01:00"
ai_log: "ai-logs/2026/05/18/workspace-core-tech-json-20260518/conversation.md"
source: "github-copilot-chat"
---

# JSON Usage Instructions

- Use JSON for configuration files (appsettings.json, libman.json).
- Keep configuration files environment-specific when needed.
- Validate JSON syntax before committing.
- Never store secrets or credentials in JSON files in source control.
- Document all configuration keys in README or docs.
