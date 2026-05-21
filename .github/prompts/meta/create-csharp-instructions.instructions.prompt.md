---
name: create-csharp-instructions
description: Generate or update C# coding instruction guidelines aligned to this repository's service and controller patterns.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "csharp", "dotnet"]
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
  id: create-csharp-instructions
  title: Create Csharp Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/csharp.instructions.md
  category: documentation
  output_format: markdown
---

# Create Csharp Instructions

## Context

Create or update `.github/instructions/csharp.instructions.md` for application logic in this API project.

Read real C# files in controllers, services, models, DTOs, and tests first.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Produce concrete C# rules for readability, validation, error handling, async behavior, and maintainability that fit this codebase.

## Deliverable

Generate `.github/instructions/csharp.instructions.md` with:

1. Full provenance front matter.
2. `applyTo: "**/*.cs"`.
3. Rules for controller-service separation and DTO mapping boundaries.
4. Guidance for null safety, exceptions, async calls, and testable design.
5. Validation checklist.

## Output Format

Return the full Markdown instruction file.
