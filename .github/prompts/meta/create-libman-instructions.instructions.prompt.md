---
name: create-libman-instructions
description: Generate or update LibMan instruction guidelines for managing static web dependencies in this repository.
temperature: 0.2
tags: ["instructions", "promptfile", "meta", "libman", "frontend-assets"]
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
  id: create-libman-instructions
  title: Create Libman Instructions
  owner: github-copilot
  version: 1.0.0
  output_path: .github/instructions/libman.instructions.md
  category: documentation
  output_format: markdown
---

# Create Libman Instructions

## Context

Create or update `.github/instructions/libman.instructions.md` by inspecting `libman.json` and static asset usage in the repository.

**CRITICAL**: Generated output MUST comply with `.github/instructions/ai-assisted-output.instructions.md`.

## Objective

Provide practical rules for repeatable client-library restoration, version pinning, destination paths, and dependency hygiene.

## Deliverable

Generate `.github/instructions/libman.instructions.md` with:

1. Full provenance front matter.
2. Rules for source providers, package version strategy, and folder conventions.
3. Guidance for restoring and validating client libraries.
4. Validation checklist.

## Output Format

Return the full Markdown instruction file.
