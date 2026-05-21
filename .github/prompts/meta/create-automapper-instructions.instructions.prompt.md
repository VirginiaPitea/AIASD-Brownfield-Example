---
name: create-automapper-instructions
description: Generate or update AutoMapper instruction guidelines for profile organization and DTO mapping boundaries.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "automapper", "dto"]
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
  id: create-automapper-instructions
  title: Create Automapper Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/automapper.instructions.md
  category: documentation
  output_format: markdown
---

# Create Automapper Instructions

## Context

Create or update `.github/instructions/automapper.instructions.md` by inspecting mapping profiles and DTO/model transformations in this repository.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Define safe, explicit mapping rules that keep domain logic out of mappings and preserve API contract consistency.

## Deliverable

Generate `.github/instructions/automapper.instructions.md` with:

1. Full provenance front matter.
2. Rules for profile granularity and naming.
3. Rules for one-way vs two-way maps and update DTO behavior.
4. Guidance for null handling, ignored members, and mapping validation.
5. Validation checklist.

## Output Format

Return the full Markdown instruction file.
