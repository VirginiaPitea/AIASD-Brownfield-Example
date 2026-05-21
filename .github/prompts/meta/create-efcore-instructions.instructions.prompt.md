---
name: create-efcore-instructions
description: Generate or update Entity Framework Core instruction guidelines for data access, context usage, and query safety.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "efcore", "data"]
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
  id: create-efcore-instructions
  title: Create Efcore Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/efcore.instructions.md
  category: documentation
  output_format: markdown
---

# Create Efcore Instructions

## Context

Create or update `.github/instructions/efcore.instructions.md` based on this repository's `ApplicationDbContext`, entities, and service-layer data access patterns.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Provide concise EF Core rules for context lifetime, query shaping, update behavior, and test-friendly configuration.

## Deliverable

Generate `.github/instructions/efcore.instructions.md` with:

1. Full provenance front matter.
2. Rules for `DbContext` usage and repository/service boundaries.
3. Guidance for LINQ query composition, include patterns, and mutation safety.
4. Guidance for in-memory provider caveats in tests versus production.
5. Validation checklist.

## Output Format

Return the full Markdown instruction file.
