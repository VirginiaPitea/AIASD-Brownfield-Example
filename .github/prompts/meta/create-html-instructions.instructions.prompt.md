---
name: create-html-instructions
description: Generate or update HTML instruction guidelines for standalone pages and static UI artifacts in this repository.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "html", "frontend"]
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
  id: create-html-instructions
  title: Create Html Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/html.instructions.md
  category: documentation
  output_format: markdown
---

# Create Html Instructions

## Context

Create or update `.github/instructions/html.instructions.md` using existing static page artifacts such as `calculator.html`.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Define lightweight HTML guidance for semantic markup, accessibility, and predictable behavior in standalone UI files.

## Deliverable

Generate `.github/instructions/html.instructions.md` with:

1. Full provenance front matter.
2. Rules for semantic structure, labels, keyboard accessibility, and script placement.
3. Guidance for maintainable IDs/classes and minimal coupling to backend internals.
4. Validation checklist.

## Output Format

Return the full Markdown instruction file.
