---
name: create-json-instructions
description: Generate or update JSON configuration instruction guidelines for appsettings and environment overrides.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "json", "configuration"]
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
    duration: "00:02:00"
total_duration: "00:02:00"
ai_log: "ai-logs/2026/05/21/create-tech-stack-instruction-prompts-20260521/conversation.md"
source: "github-copilot-chat"
owner: "Development Team"
version: "1.0.0"
prompt_metadata:
  id: create-json-instructions
  title: Create Json Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/json.instructions.md
  category: documentation
  output_format: markdown
---

# Create Json Instructions

## Context

Create or update `.github/instructions/json.instructions.md` focused on `appsettings.json`, environment-specific overrides, and safe secret handling.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Define JSON configuration rules that keep production-safe defaults, avoid secrets in source control, and keep schema usage consistent.

## Deliverable

Generate `.github/instructions/json.instructions.md` with:

1. Full provenance front matter.
2. Guidance for key naming, nesting, and typed option binding compatibility.
3. Rules for environment override behavior and secret externalization.
4. Validation checklist.

## Output Format

Return the full Markdown instruction file.
