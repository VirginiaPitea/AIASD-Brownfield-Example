---
name: create-dotnet-instructions
description: Generate or update .NET project instruction guidelines for this repository's SDK-style .csproj usage.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "dotnet", "csproj"]
ai_generated: true
model: "openai/gpt-5.3-codex@unknown"
operator: "github-copilot"
chat_id: "create-tech-stack-instruction-prompts-20260521"
prompt: |
  create prompts for creating instruction files for the tech stack
started: "2026-05-21T00:00:00Z"
ended: "2026-05-21T00:00:00Z"
task_durations:
  - task: "prompt authoring"
    duration: "00:03:00"
total_duration: "00:03:00"
ai_log: "ai-logs/2026/05/21/create-tech-stack-instruction-prompts-20260521/conversation.md"
source: "github-copilot-chat"
owner: "Development Team"
version: "1.0.0"
prompt_metadata:
  id: create-dotnet-instructions
  title: Create Dotnet Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/dotnet.instructions.md
  category: documentation
  output_format: markdown
---

# Create Dotnet Instructions

## Context

Create or update `.github/instructions/dotnet.instructions.md` for this repository's .NET project configuration and build workflow.

Use actual repository evidence from the solution file, project file, launch settings, appsettings files, and existing tests.

**CRITICAL**: All generated artifacts MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Produce concise, enforceable instruction guidance for maintaining SDK-style `.csproj` and solution-level .NET conventions in this repo.

## Deliverable

Generate `.github/instructions/dotnet.instructions.md` with:

1. YAML front matter including required provenance metadata.
2. Description focused on .NET 8 project setup and maintenance.
3. `applyTo: "**/*.csproj"`.
4. Rules for package references, project settings, configuration sources, and build consistency.
5. A validation checklist and summary.

### Required Provenance Fields

```yaml
ai_generated: true
model: "<provider>/<model-name>@<version>"
operator: "<operator-username>"
chat_id: "<chat-id>"
prompt: |
  <exact-prompt-text>
started: "<ISO8601>"
ended: "<ISO8601>"
task_durations:
  - task: "<task>"
    duration: "<hh:mm:ss>"
total_duration: "<hh:mm:ss>"
ai_log: "ai-logs/<yyyy>/<mm>/<dd>/<chat-id>/conversation.md"
source: "<source>"
```

## Output Format

Return the complete Markdown instruction file content.
