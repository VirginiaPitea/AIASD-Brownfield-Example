---
name: create-aspnetcore-instructions
description: Generate or update ASP.NET Core API instruction guidelines for middleware, routing, auth, and endpoint behavior.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "aspnetcore", "webapi"]
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
  id: create-aspnetcore-instructions
  title: Create Aspnetcore Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/aspnetcore.instructions.md
  category: documentation
  output_format: markdown
---

# Create Aspnetcore Instructions

## Context

Create or update `.github/instructions/aspnetcore.instructions.md` for this ASP.NET Core Web API repository.

Inspect `Program.cs`, controllers, auth configuration, and environment-specific settings before drafting rules.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Define enforceable ASP.NET Core guidance for startup configuration, middleware ordering, auth, model validation, and API error semantics.

## Deliverable

Generate `.github/instructions/aspnetcore.instructions.md` with:

1. Full provenance front matter.
2. Rules for routing, action semantics, response types, and authentication/authorization.
3. Environment-specific security defaults and configuration binding guidance.
4. Validation checklist.

## Output Format

Return the full Markdown instruction file.
